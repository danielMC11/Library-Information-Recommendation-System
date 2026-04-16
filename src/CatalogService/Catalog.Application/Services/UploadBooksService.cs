using Catalog.Application.DTOs;
using Catalog.Application.Interfaces;
using Catalog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Catalog.Application.Services;

public class UploadBooksService
{
    private readonly IBookRepository _repository;
    private readonly ILogger<UploadBooksService> _logger;   

    public UploadBooksService(IBookRepository repository, ILogger<UploadBooksService> logger)
    {
        _repository = repository;
        _logger = logger;
    }


    public async Task<UploadResponseDto> ProcessIso2709Async(byte[] fileBytes)
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        var encoding = Encoding.GetEncoding("iso-8859-1",
            new EncoderReplacementFallback(" "), new DecoderReplacementFallback(" "));

        var response = new UploadResponseDto();

        // 1. CARGA DE CACHES
        var existingBooks = await _repository.GetExistingBooksWithAuthorsAsync();
        var authorsDb = (await _repository.GetAllAuthorsAsync()).ToDictionary(a => a.Name);
        var topicsDb = (await _repository.GetAllTopicsAsync()).ToDictionary(t => t.Name);

        var newBooks = new List<Book>();
        var records = SplitBytes(fileBytes, 0x1D);

        // ASIGNAMOS EL TOTAL PROCESADO
        response.TotalProcessed = records.Count;

        int currentRecordIndex = 0;
        int skippedCount = 0;

        foreach (var raw in records)
        {
            currentRecordIndex++;
            if (raw.Length == 0)
            {
                skippedCount++;
                continue;
            }

            var fields = ParseRecord(raw, encoding);
            if (fields == null)
            {
                _logger.LogWarning("Registro #{Index}: Error MARC.", currentRecordIndex);
                skippedCount++;
                continue;
            }

            var isbn = GetField(fields, "020", 'a');
            var title = CleanMarcText(GetAllSubfields(fields, "245", 'a', 'b')) ?? "Sin Título";

            var currentBook = new Book
            {
                Isbn = string.IsNullOrWhiteSpace(isbn) ? null : isbn,
                Title = title,
                Year = ExtractYearFrom008(fields)
            };

            var authorName = CleanMarcText(GetField(fields, "100", 'a'));
            if (!string.IsNullOrWhiteSpace(authorName))
            {
                if (!authorsDb.TryGetValue(authorName, out var author))
                {
                    author = new Author { Name = authorName };
                    authorsDb[authorName] = author;
                }
                currentBook.Authors.Add(author);
            }

            // 2. LÓGICA DE DUPLICADOS
            if (existingBooks.Any(b => b.Equals(currentBook)) || newBooks.Any(b => b.Equals(currentBook)))
            {
                _logger.LogInformation("Registro #{Index}: Saltado (Duplicado). Título: {Title}", currentRecordIndex, title);
                skippedCount++;
                continue;
            }

            // ... resto de la lógica de Temas ...
            var topicName = CleanMarcText(GetField(fields, "650", 'a'));
            if (!string.IsNullOrWhiteSpace(topicName))
            {
                if (!topicsDb.TryGetValue(topicName, out var topic))
                {
                    topic = new Topic { Name = topicName };
                    topicsDb[topicName] = topic;
                }
                currentBook.Topics.Add(topic);
            }

            newBooks.Add(currentBook);
        }

        // 3. ASIGNAMOS VALORES FINALES AL DTO
        response.TotalSaved = newBooks.Count;
        response.TotalSkipped = skippedCount;

        if (newBooks.Any())
        {
            try
            {
                await _repository.SaveAllAsync(newBooks);
                _logger.LogInformation("Carga terminada. Guardados: {Saved}, Saltados: {Skipped}", response.TotalSaved, response.TotalSkipped);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error en DB");
                response.Errors.Add("Error al persistir los datos.");
            }
        }

        return response;
    }



    private record MarcField(string Tag, string? Value, List<(char Code, string Value)>? Subfields);

    private List<MarcField>? ParseRecord(byte[] raw, Encoding encoding)
    {
        if (raw.Length < 24) return null;
        try
        {
            var leader = Encoding.ASCII.GetString(raw, 0, 24);
            int baseAddr = int.Parse(leader.Substring(12, 5));
            var dirBytes = raw[24..(baseAddr - 1)];

            var tags = new List<string>();
            for (int i = 0; i < dirBytes.Length; i += 12)
                if (i + 3 <= dirBytes.Length)
                    tags.Add(Encoding.ASCII.GetString(dirBytes, i, 3));

            var dataArea = raw[baseAddr..];
            var fieldChunks = SplitBytes(dataArea, 0x1E);
            var fields = new List<MarcField>();

            for (int i = 0; i < tags.Count && i < fieldChunks.Count; i++)
            {
                var tag = tags[i];
                var chunk = fieldChunks[i];

                if (string.Compare(tag, "010") < 0)
                {
                    fields.Add(new MarcField(tag, encoding.GetString(chunk).Trim(), null));
                }
                else
                {
                    if (chunk.Length < 2) continue;
                    var subfields = new List<(char Code, string Value)>();
                    var parts = SplitBytes(chunk[2..], 0x1F);

                    foreach (var part in parts)
                    {
                        if (part.Length == 0) continue;
                        subfields.Add(((char)part[0], encoding.GetString(part[1..]).Trim()));
                    }
                    fields.Add(new MarcField(tag, null, subfields));
                }
            }
            return fields;
        }
        catch { return null; }
    }

    // Limpia caracteres como " /", " :", o "." al final de los textos (el rstrip de Python)
    private string? CleanMarcText(string? text)
    {
        if (string.IsNullOrWhiteSpace(text)) return null;
        return text.Trim().TrimEnd('/', ':', '.', ',').Trim();
    }

    private string? GetField(List<MarcField> fields, string tag, char? code = null)
    {
        var f = fields.FirstOrDefault(x => x.Tag == tag);
        if (f == null) return null;

        // Si no pides subcampo (code == null), devolvemos el valor directo del campo
        if (code == null) return f.Value;

        // Buscamos el subcampo. 
        // s.Code es el char, s.Value es el string.
        var subfield = f.Subfields?.FirstOrDefault(s => s.Code == code);

        // USAMOS EL OPERADOR ?. PARA ACCEDER AL STRING 'Value' DENTRO DE LA TUPLA
        // Esto evita la ambigüedad de subfield.Value.Value
        return subfield?.Value;
    }
    private string? GetAllSubfields(List<MarcField> fields, string tag, params char[] codes)
    {
        var f = fields.FirstOrDefault(x => x.Tag == tag);
        if (f == null || f.Subfields == null) return null;
        var vals = f.Subfields.Where(s => codes.Contains(s.Code)).Select(s => s.Value);
        return string.Join(" ", vals).Trim();
    }

    private string? ExtractYearFrom008(List<MarcField> fields, bool returnLanguage = false)
    {
        var f008 = GetField(fields, "008");
        if (f008 == null || f008.Length < 40) return null;

        // El año está en las posiciones 7-10, el idioma en 35-37
        return returnLanguage ? f008.Substring(35, 3) : f008.Substring(7, 4).Replace("#", "").Trim();
    }

    private List<byte[]> SplitBytes(byte[] source, byte separator)
    {
        var result = new List<byte[]>();
        int start = 0;
        for (int i = 0; i < source.Length; i++)
        {
            if (source[i] == separator)
            {
                result.Add(source[start..i]);
                start = i + 1;
            }
        }
        if (start < source.Length) result.Add(source[start..]);
        return result;
    }
}