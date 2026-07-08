using System.Collections.Generic;
using System.Linq;

namespace Auth.Domain.Entities;

public class Student
{
    public long Id { get; private set; }

    public User User { get; private set; } = null!;
    public Career Career { get; private set; } = null!;
    public ICollection<Subject> Subjects { get; private set; } = new List<Subject>();   

    private Student() { }

    public Student(User user, Career career)
    {
        User = user;
        Career = career;
    }

    public void UpdateCareer(Career career)
    {
        Career = career;
    }

    public override string ToString()
    {
        var textParts = new List<string>();

        if (Career != null)
        {
            textParts.Add($"CARRERA: {Career.CareerName}");
        }

        if (Subjects != null && Subjects.Any())
        {
            var subjectNames = Subjects.Select(s => s.SubjectName).Where(name => !string.IsNullOrWhiteSpace(name));
            if (subjectNames.Any())
            {
                textParts.Add($"ASIGNATURAS: {string.Join(", ", subjectNames)}");
            }
        }

        return string.Join(". ", textParts) + ".";
    }
}