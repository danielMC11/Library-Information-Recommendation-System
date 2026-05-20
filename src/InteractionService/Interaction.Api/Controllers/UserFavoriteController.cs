using Interaction.Application.DTOs;
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
    private readonly SaveUserFavorite _saveService;
    private readonly GetUserFavoriteBook _getService;
    private readonly CheckFavoriteBooksAsync _checkService;

    public UserFavoriteController(
        SaveUserFavorite saveService,
        GetUserFavoriteBook getService,
        CheckFavoriteBooksAsync checkService)
    {
        _saveService = saveService;
        _getService = getService;
        _checkService = checkService;
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
    public async Task<ActionResult<IEnumerable<UserFavoriteDto>>> GetFavorites()
    {

        var userIdClaim = User.FindFirst(JwtRegisteredClaimNames.Sub)?.Value
        ?? User.FindFirst("sub")?.Value
        ?? User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

        if (!Guid.TryParse(userIdClaim, out var userId))
            return Unauthorized("Token inválido.");

        try
        {
            var result = await _getService.ExecuteAsync(userId);
            return Ok(result);
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
