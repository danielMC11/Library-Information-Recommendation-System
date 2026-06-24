using MiniIdentityApi.Application.Interfaces;
using MiniIdentityApi.Domain.Entities;

namespace MiniIdentityApi.Application.Services;

public class UserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public List<User> GetAll() => _userRepository.GetAll();

    public User? GetById(Guid id) => _userRepository.FindById(id);

    public void UpdateCareerAndSemester(Guid userId, int career, int semester)
    {
        var user = _userRepository.FindById(userId) ?? throw new KeyNotFoundException("User not found.");

        if (career <= 0)
            throw new ArgumentException("Career must be a positive integer.");

        if (semester <= 0)
            throw new ArgumentException("Semester must be a positive integer.");

        user.UpdateCareerAndSemester(career, semester);
    }
}
