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

    public async Task SaveAllAsync(IEnumerable<Book> books)
    {
        using var transaction = await _context.Database.BeginTransactionAsync();
        try
        {
            _context.Books.AddRange(books);
            await _context.SaveChangesAsync();
            await transaction.CommitAsync();
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



}

