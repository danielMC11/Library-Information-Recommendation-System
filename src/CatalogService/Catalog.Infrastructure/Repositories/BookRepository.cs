using Catalog.Application.Interfaces;
using Catalog.Domain.Entities;
using Catalog.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;



namespace Catalog.Infrastructure.Repositories;
public class BookRepository: IBookRepository
{

    private readonly AppDbContext _context;

    public BookRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Book>> SaveAllAsync(IEnumerable<Book> books)
    {
        var booksList = books.ToList();

        using var transaction = await _context.Database.BeginTransactionAsync();
        try
        {
            await _context.Books.AddRangeAsync(booksList);
            await _context.SaveChangesAsync();
            await transaction.CommitAsync();

            return booksList;
        }
        catch
        {
            await transaction.RollbackAsync();
            throw;
        }
    }

    public async Task<List<Book>> GetExistingBooksWithAuthorsAsync()
    {
        return await _context.Books
            .Include(b => b.Authors)
            .ToListAsync();
    }

    public async Task<IEnumerable<Author>> GetAllAuthorsAsync()
    {
        return await _context.Authors.ToListAsync();
    }

    public async Task<IEnumerable<Topic>> GetAllTopicsAsync()
    {
        return await _context.Topics.ToListAsync();
    }


    public async Task<Book?> GetBookDetailsAsync(Guid bookId)
    {
        return await _context.Books
            .Include(b => b.Authors)
            .Include(b => b.Topics)
            .AsNoTracking()
            .FirstOrDefaultAsync(b => b.Id == bookId);
    }

    public async Task<List<Book>> GetBooksPagedAsync(int page, int pageSize)
    {
        return await _context.Books
            .Include(b => b.Authors)
            .Include(b => b.Topics)
            .AsNoTracking()
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<List<Book>> SearchBooksAsync(string name)
    {
        return await _context.Books
            .Include(b => b.Authors)
            .Include(b => b.Topics)
            .AsNoTracking()
            .Where(b => b.Title.Contains(name))
            .Take(50)
            .ToListAsync();
    }

    public async Task<List<Book>> GetBooksByIdsAsync(List<Guid> ids)
    {
        return await _context.Books
            .Include(b => b.Authors)
            .Include(b => b.Topics)
            .AsNoTracking()
            .Where(b => ids.Contains(b.Id))
            .ToListAsync();
    }
}

