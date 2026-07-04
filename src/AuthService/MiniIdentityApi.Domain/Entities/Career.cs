using System.ComponentModel.DataAnnotations;

namespace MiniIdentityApi.Domain.Entities;

public class Career
{
    public int Id { get; private set; }

    [Required]
    public string CareerName { get; private set; } = null!;
    public int DurationSemesters { get; private set; }

    private Career() { }

    public Career(string careerName, int durationSemesters)
    {
        CareerName = careerName;
        DurationSemesters = durationSemesters;
    }

    public void UpdateCareerName(string careerName)
    {
        CareerName = careerName;
    }

    public void UpdateDurationSemesters(int durationSemesters)
    {
        DurationSemesters = durationSemesters;
    }
}