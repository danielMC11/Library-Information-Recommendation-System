using Auth.Application.DTOs;
using Auth.Application.Interfaces;

namespace Auth.Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public List<StudentListItemDto> GetAllStudents()
    {
        return _userRepository.GetAllStudents().Select(s => new StudentListItemDto
        {
            StudentId = s.Id,
            Name = s.User.Username,
            Email = s.User.Email,
            CareerName = s.Career.CareerName
        }).ToList();
    }

    public StudentDetailDto? GetStudentById(long id)
    {
        var student = _userRepository.FindStudentById(id);
        if (student is null) return null;

        return new StudentDetailDto
        {
            StudentId = student.Id,
            Name = student.User.Username,
            Email = student.User.Email,
            CareerName = student.Career.CareerName,
            Subjects = student.Subjects.Select(s => new SubjectDto
            {
                Id = s.Id,
                SubjectName = s.SubjectName
            }).ToList()
        };
    }
}
