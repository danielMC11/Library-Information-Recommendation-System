namespace Auth.Domain.Entities;

public class CareerSubject
{
    public int Id { get; private set; }
    public int SemesterNumber { get; private set; }

    public Career Career { get; private set; } = null!;
    public Subject Subject { get; private set; } = null!;

    private CareerSubject() { }

    public CareerSubject(Career career, Subject subject, int semesterNumber)
    {
        Career = career;
        Subject = subject;
        SemesterNumber = semesterNumber;
    }

    public void UpdateSemesterNumber(int semesterNumber)
    {
        SemesterNumber = semesterNumber;
    }
}
