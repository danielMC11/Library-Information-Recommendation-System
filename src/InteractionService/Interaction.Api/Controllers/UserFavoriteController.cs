using Shared.DTOs;
using Interaction.Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;

namespace Interaction.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserFavoriteController : ControllerBase
{
    private readonly UserFavoriteService _favoriteService;

    public UserFavoriteController(UserFavoriteService favoriteService)
    {
        _favoriteService = favoriteService;
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
            var result = await _favoriteService.SaveFavoriteAsync(userId, bookId);
            return Ok(result);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [Authorize]
    [HttpGet("list")]
    public async Task<ActionResult<IEnumerable<BookDto>>> GetFavorites()
    {

        var userIdClaim = User.FindFirst(JwtRegisteredClaimNames.Sub)?.Value
        ?? User.FindFirst("sub")?.Value
        ?? User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

        if (!Guid.TryParse(userIdClaim, out var userId))
            return Unauthorized("Token inválido.");

        try
        {
            var books = await _favoriteService.GetUserFavoritesAsync(userId);
            return Ok(books);
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
            var result = await _favoriteService.CheckFavoriteAsync(userId, bookId);
            return Ok(result);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
