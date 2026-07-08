using Auth.Application.DTOs;

namespace Auth.Application.Interfaces;

public interface ICareerService
{
    List<CareerDto> GetAll();
    CareerDetailDto? GetById(int id, int semester = 1);
}
