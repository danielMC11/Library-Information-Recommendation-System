using Microsoft.AspNetCore.Mvc;
using Auth.Application.Interfaces;

namespace Auth.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CareerController : ControllerBase
{
    private readonly ICareerService _careerService;

    public CareerController(ICareerService careerService)
    {
        _careerService = careerService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_careerService.GetAll());
    }

    [HttpGet("{id:int}")]
    public IActionResult GetById(int id, [FromQuery] int semester = 1)
    {
        var career = _careerService.GetById(id, semester);
        return career is null ? NotFound() : Ok(career);
    }
}
