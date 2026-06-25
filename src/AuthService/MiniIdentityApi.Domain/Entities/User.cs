namespace MiniIdentityApi.Domain.Entities;

public class User
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Username { get; private set; } = null!;
    public string Email { get; private set; } = null!;
    public Credential Credential { get; private set; } = null!;
    public Role Role { get; private set; }

    private User() { }

    public User(string username, string email, Credential credential, Role role = Role.User)
    {
        Username = username;
        Email = email;
        Credential = credential;
        Role = role;
    }
}