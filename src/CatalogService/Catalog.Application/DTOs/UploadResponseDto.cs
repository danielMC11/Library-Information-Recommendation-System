using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Application.DTOs;
public class UploadResponseDto
{
    public int TotalProcessed { get; set; } // Total de registros en el archivo
    public int TotalSaved { get; set; }     // Guardados con éxito
    public int TotalSkipped { get; set; }   // Ignorados (duplicados o errores)
    public List<string> Errors { get; set; } = new List<string>();
}

