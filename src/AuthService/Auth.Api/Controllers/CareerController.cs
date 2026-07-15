using Microsoft.AspNetCore.Mvc;
using Auth.Application.Interfaces;

namespace Auth.Api.Controllers;

[ApiController]
[Route("api/auth/[controller]")]
public class CareerController : ControllerBase
{
    private readonly ICareerService _careerService;

    public CareerController(ICareerService careerService)
    {
        _careerService = careerService;
    }

    /// <summary>Obtiene todas las carreras disponibles.</summary>
    /// <returns>Lista de carreras.</returns>
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_careerService.GetAll());
    }

    /// <summary>Obtiene una carrera por su ID.</summary>
    /// <param name="id">ID de la carrera.</param>
    /// <param name="semester">Semestre para filtrar materias (opcional, por defecto 1).</param>
    /// <returns>Carrera con sus materias del semestre indicado.</returns>
    [HttpGet("{id:int}")]
    public IActionResult GetById(int id, [FromQuery] int semester = 1)
    {
        var career = _careerService.GetById(id, semester);
        return career is null ? NotFound() : Ok(career);
    }
}
