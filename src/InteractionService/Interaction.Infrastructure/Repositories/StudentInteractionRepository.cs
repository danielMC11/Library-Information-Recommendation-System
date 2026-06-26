using Interaction.Application.Interfaces;
using Interaction.Domain.Entities;
using Interaction.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Interaction.Infrastructure.Repositories;

public class StudentInteractionRepository : IStudentInteractionRepository
{
    private readonly AppDbContext _context;

    public StudentInteractionRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task SaveStudentInteractionAsync(IEnumerable<InteractionEvent> interactionEvents)
    {
        await _context.InteractionEvents.AddRangeAsync(interactionEvents);
        await _context.SaveChangesAsync();
    }

    public async Task<List<InteractionEvent>> GetStudentInteractionsAsync(long studentId)
    {
        return await _context.InteractionEvents
            .Where(i => i.StudentId == studentId)
            .ToListAsync();
    }
}
