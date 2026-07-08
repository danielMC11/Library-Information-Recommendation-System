using Microsoft.EntityFrameworkCore;
using Auth.Application.Interfaces;
using Auth.Domain.Entities;
using Auth.Infrastructure.Persistence;

namespace Auth.Infrastructure.Repositories;

public class CareerRepository : ICareerRepository
{
    private readonly AppDbContext _db;

    public CareerRepository(AppDbContext db) => _db = db;

    public List<Career> GetAll() => _db.Careers.ToList();

    public Career? GetById(int id) =>
        _db.Careers.FirstOrDefault(c => c.Id == id);

    public List<Subject> GetSubjectsByCareerAndSemester(int careerId, int semesterNumber) =>
        _db.CareerSubjects
            .Where(cs => cs.Career.Id == careerId && cs.SemesterNumber == semesterNumber)
            .Include(cs => cs.Subject)
            .Select(cs => cs.Subject)
            .ToList();
}
