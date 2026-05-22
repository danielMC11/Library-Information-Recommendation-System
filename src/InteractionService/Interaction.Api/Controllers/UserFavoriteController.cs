using Interaction.Application.DTOs;
using Interaction.Application.Services;
using Interaction.Api.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;


namespace Interaction.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserFavoriteController : ControllerBase
{
    private readonly SaveUserFavorite _saveService;
    private readonly GetUserFavoriteBook _getService;
    private readonly CheckFavoriteBooksAsync _checkService;
    private readonly IHttpClientFactory _httpClientFactory;

    public UserFavoriteController(
        SaveUserFavorite saveService,
        GetUserFavoriteBook getService,
        CheckFavoriteBooksAsync checkService,
        IHttpClientFactory httpClientFactory)
    {
        _saveService = saveService;
        _getService = getService;
        _checkService = checkService;
        _httpClientFactory = httpClientFactory;
    }


    [Authorize]
    [HttpPost("save/{bookId:guid}")]
    public async Task<ActionResult<UserFavoriteDto>> SaveFavorite([FromRoute] Guid bookId)
    {

        var userIdClaim = User.FindFirst(JwtRegisteredClaimNames.Sub)?.Value
        ?? User.FindFirst("sub")?.Value
        ?? User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

        if (!Guid.TryParse(userIdClaim, out var userId))
            return Unauthorized("Token inválido.");

        try
        {
            var result = await _saveService.ExecuteAsync(userId, bookId);
            return Ok(result);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [Authorize]
    [HttpGet("list")]
    public async Task<ActionResult<IEnumerable<CatalogBookDto>>> GetFavorites()
    {

        var userIdClaim = User.FindFirst(JwtRegisteredClaimNames.Sub)?.Value
        ?? User.FindFirst("sub")?.Value
        ?? User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

        if (!Guid.TryParse(userIdClaim, out var userId))
            return Unauthorized("Token inválido.");

        try
        {
            var favorites = await _getService.ExecuteAsync(userId);

            var bookIds = favorites?.Select(f => f.BookId).Where(id => id != Guid.Empty).ToList() ?? new List<Guid>();

            if (bookIds.Count == 0)
                return Ok(new List<CatalogBookDto>());

            var client = _httpClientFactory.CreateClient("catalog");

            var response = await client.PostAsJsonAsync("api/books/details", bookIds);

            if (!response.IsSuccessStatusCode)
            {
                return StatusCode((int)response.StatusCode, "Error al recuperar detalles desde Catalog.");
            }

            var books = await response.Content.ReadFromJsonAsync<IEnumerable<CatalogBookDto>>();

            return Ok(books ?? new List<CatalogBookDto>());
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [Authorize]
    [HttpGet("check/{bookId:guid}")]
    public async Task<ActionResult<bool>> CheckFavorite([FromRoute] Guid bookId)
    {

        var userIdClaim = User.FindFirst(JwtRegisteredClaimNames.Sub)?.Value
        ?? User.FindFirst("sub")?.Value
        ?? User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

        if (!Guid.TryParse(userIdClaim, out var userId))
            return Unauthorized("Token inválido.");

        try
        {
            var result = await _checkService.ExecuteAsync(userId, bookId);
            return Ok(result);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
