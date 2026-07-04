using System.Collections.Generic;
using System.Linq;

namespace MiniIdentityApi.Domain.Entities;

public class Student
{
    public long Id { get; private set; }
    public int SemesterNumber { get; private set; }

    public User User { get; private set; } = null!;
    public Career Career { get; private set; } = null!;
    public ICollection<Subject> Subjects { get; private set; } = new List<Subject>();   

    private Student() { }

    public Student(User user, Career career, int semesterNumber)
    {
        User = user;
        Career = career;
        SemesterNumber = semesterNumber;
    }

    public void UpdateSemesterNumber(int semesterNumber)
    {
        SemesterNumber = semesterNumber;
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

        if(SemesterNumber != 0)
        {
           textParts.Add($"SEMESTRE: {SemesterNumber}");
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