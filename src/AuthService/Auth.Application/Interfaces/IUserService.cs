using Auth.Application.DTOs;

namespace Auth.Application.Interfaces;

public interface IUserService
{
    List<StudentListItemDto> GetAllStudents();
    StudentDetailDto? GetStudentById(long id);
}
