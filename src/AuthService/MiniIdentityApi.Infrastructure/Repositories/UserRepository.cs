using Microsoft.EntityFrameworkCore;
using MiniIdentityApi.Application.Interfaces;
using MiniIdentityApi.Domain.Entities;
using MiniIdentityApi.Infrastructure.Persistence;

namespace MiniIdentityApi.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _db;

    public UserRepository(AppDbContext db) => _db = db;

    public User? FindById(Guid id) =>
        _db.Users.FirstOrDefault(u => u.Id == id);

    public User? FindByUsernameOrEmail(string value) =>
        _db.Users.FirstOrDefault(u =>
            u.Username == value || u.Email == value);

    public List<User> GetAll() =>
        _db.Users.ToList();

    public void Save(User user)
    {
        _db.Users.Add(user);
        _db.SaveChanges();
    }

    public Career? FindCareerById(int careerId) =>
        _db.Careers.FirstOrDefault(c => c.Id == careerId);

    public List<Subject> FindSubjectsByIds(List<int> subjectIds) =>
        _db.Subjects.Where(s => subjectIds.Contains(s.Id)).ToList();
}
