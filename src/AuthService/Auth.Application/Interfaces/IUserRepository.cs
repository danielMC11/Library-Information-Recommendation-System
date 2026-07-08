using Auth.Domain.Entities;

namespace Auth.Application.Interfaces;

public interface IUserRepository
{
    User? FindById(Guid id);
    User? FindByUsernameOrEmail(string value);
    List<User> GetAll();
    void Save(User user);
    Career? FindCareerById(int careerId);
    List<Subject> FindSubjectsByIds(List<int> subjectIds);
    List<Student> GetAllStudents();
    Student? FindStudentById(long id);
}