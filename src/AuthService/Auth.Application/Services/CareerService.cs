using Auth.Application.DTOs;
using Auth.Application.Interfaces;

namespace Auth.Application.Services;

public class CareerService : ICareerService
{
    private readonly ICareerRepository _careerRepository;

    public CareerService(ICareerRepository careerRepository)
    {
        _careerRepository = careerRepository;
    }

    public List<CareerDto> GetAll()
    {
        return _careerRepository.GetAll()
            .Select(c => new CareerDto
            {
                Id = c.Id,
                CareerName = c.CareerName,
                DurationSemesters = c.DurationSemesters
            })
            .ToList();
    }

    public CareerDetailDto? GetById(int id, int semester)
    {
        var career = _careerRepository.GetById(id);
        if (career is null) return null;

        var subjects = _careerRepository.GetSubjectsByCareerAndSemester(id, semester)
            .Select(s => new SubjectDto
            {
                Id = s.Id,
                SubjectName = s.SubjectName
            })
            .ToList();

        return new CareerDetailDto
        {
            Id = career.Id,
            CareerName = career.CareerName,
            DurationSemesters = career.DurationSemesters,
            Semester = semester,
            Subjects = subjects
        };
    }
}
