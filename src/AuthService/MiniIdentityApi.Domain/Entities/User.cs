namespace MiniIdentityApi.Domain.Entities;

public class User
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Username { get; private set; }
    public string Email { get; private set; }
    public int Career { get; private set; }
    public int Semester { get; private set; }
    public Credential Credential { get; private set; }
    public Role Role { get; private set; }

    public User(string username, string email, int career, int semester, Credential credential, Role role = Role.User)
    {
        Username = username;
        Email = email;
        Career = career;
        Semester = semester;
        Credential = credential;
        Role = role;
    }

    public void UpdateCareerAndSemester(int career, int semester)
    {
        Career = career;
        Semester = semester;
    }
}
