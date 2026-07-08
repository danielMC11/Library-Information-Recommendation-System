using Auth.Domain.Entities;

namespace Auth.Application.Interfaces;

public interface ITokenService
{
    string GenerateToken(User user);
}