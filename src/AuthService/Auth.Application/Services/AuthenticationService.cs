using Auth.Application.DTOs.Auth;
using Auth.Application.Interfaces;
using Auth.Domain.Entities;
using Shared.Events;

namespace Auth.Application.Services;

public class AuthenticationService : IAuthenticationService
{
    private readonly IUserRepository _userRepository;
    private readonly IPasswordHasher _passwordHasher;
    private readonly ITokenService _tokenService;
    private readonly IStudentRegisteredPublisher _studentRegisteredPublisher;

    public AuthenticationService(
        IUserRepository userRepository,
        IPasswordHasher passwordHasher,
        ITokenService tokenService,
        IStudentRegisteredPublisher studentRegisteredPublisher)
    {
        _userRepository = userRepository;
        _passwordHasher = passwordHasher;
        _tokenService = tokenService;
        _studentRegisteredPublisher = studentRegisteredPublisher;
    }

    public void RegisterAdmin(RegisterRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Username))
            throw new ArgumentException("Username is required.");

        if (string.IsNullOrWhiteSpace(request.Email))
            throw new ArgumentException("Email is required.");

        if (string.IsNullOrWhiteSpace(request.Password))
            throw new ArgumentException("Password is required.");

        var existing = _userRepository.FindByUsernameOrEmail(request.Username)
                      ?? _userRepository.FindByUsernameOrEmail(request.Email);

        if (existing is not null)
            throw new InvalidOperationException("User already exists.");

        var salt = _passwordHasher.GenerateSalt();
        var hash = _passwordHasher.Hash(request.Password, salt);

        var credential = new Credential(hash, salt);
        var user = new User(request.Username, request.Email, credential, Role.ADMIN);

        _userRepository.Save(user);
    }

    public async Task RegisterStudent(RegisterStudentRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Username))
            throw new ArgumentException("Username is required.");

        if (string.IsNullOrWhiteSpace(request.Email))
            throw new ArgumentException("Email is required.");

        if (string.IsNullOrWhiteSpace(request.Password))
            throw new ArgumentException("Password is required.");

        var existing = _userRepository.FindByUsernameOrEmail(request.Username)
                      ?? _userRepository.FindByUsernameOrEmail(request.Email);

        if (existing is not null)
            throw new InvalidOperationException("User already exists.");

        var career = _userRepository.FindCareerById(request.CareerId)
            ?? throw new ArgumentException($"Career with id {request.CareerId} not found.");

        var subjects = _userRepository.FindSubjectsByIds(request.SubjectIds);
        if (subjects.Count != request.SubjectIds.Count)
            throw new ArgumentException("One or more subject ids are invalid.");

        var salt = _passwordHasher.GenerateSalt();
        var hash = _passwordHasher.Hash(request.Password, salt);

        var credential = new Credential(hash, salt);
        var user = new User(request.Username, request.Email, credential, Role.STUDENT);

        var student = new Student(user, career);
        foreach (var subject in subjects)
        {
            student.Subjects.Add(subject);
        }
        user.Student = student;

        _userRepository.Save(user);

        var @event = new StudentRegisteredEvent
        {
            StudentId = student.Id,
            Description = student.ToString()
        };
        await _studentRegisteredPublisher.PublishAsync(@event);
    }

    public AuthResponse Login(LoginRequest request)
    {
        var user = _userRepository.FindByUsernameOrEmail(request.UsernameOrEmail);

        if (user is null)
            throw new UnauthorizedAccessException("Invalid credentials.");

        var isValid = _passwordHasher.Verify(
            request.Password,
            user.Credential.Salt,
            user.Credential.PasswordHash);

        if (!isValid)
            throw new UnauthorizedAccessException("Invalid credentials.");

        return new AuthResponse
        {
            Id = user.Id,
            AccessToken = _tokenService.GenerateToken(user),
            Username = user.Username,
            Email = user.Email,
            Roles = new List<string> { user.Role.ToString() }
        };
    }
}