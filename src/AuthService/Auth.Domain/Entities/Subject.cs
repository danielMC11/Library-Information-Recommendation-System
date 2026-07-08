namespace Auth.Domain.Entities;

public class Subject
{
    public int Id { get; private set; }
    public string SubjectName { get; private set; } = null!;

    private Subject() { }

    public Subject(string subjectName)
    {
        SubjectName = subjectName;
    }

    public void UpdateSubjectName(string subjectName)
    {
        SubjectName = subjectName;
    }
}