using Shared.Helpers;

namespace Auth.Domain.Entities;

public class Credential
{
    public string PasswordHash { get; private set; } = null!;
    public string Salt { get; private set; } = null!;
    public DateTime LastChangedAt { get; private set; }

    private Credential() { }

    public Credential(string passwordHash, string salt)
    {
        PasswordHash = passwordHash;
        Salt = salt;
        LastChangedAt = ColombiaTimeHelper.Now;
    }

    public void ChangePassword(string newHash, string newSalt)
    {
        PasswordHash = newHash;
        Salt = newSalt;
        LastChangedAt = ColombiaTimeHelper.Now;
    }
}