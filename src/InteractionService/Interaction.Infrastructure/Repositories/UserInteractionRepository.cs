using Interaction.Application.Interfaces;
using Interaction.Domain.Entities;
using Interaction.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Interaction.Domain.Entities;
using Interaction.Infrastructure.Persistence;

namespace Interaction.Infrastructure.Repositories;

public class UserInteractionRepository : IUserInteractionRepository
{
    private readonly AppDbContext _context;

    public UserInteractionRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task SaveUserInteractionAsync(IEnumerable<InteractionEvent> interactionEvents)
    {
        await _context.InteractionEvents.AddRangeAsync(interactionEvents);
        await _context.SaveChangesAsync();
    }

    public async Task<List<InteractionEvent>> GetUserInteractionsAsync(Guid userId)
    {
        return await _context.InteractionEvents
            .Where(i => i.UserId == userId)
            .ToListAsync();
    }
}
