using Auth.Domain.Entities;

namespace Auth.Application.Interfaces;

public interface ICareerRepository
{
    List<Career> GetAll();
    Career? GetById(int id);
    List<Subject> GetSubjectsByCareerAndSemester(int careerId, int semesterNumber);
}
