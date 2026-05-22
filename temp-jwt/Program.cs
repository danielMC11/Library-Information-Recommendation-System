using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

var key = "THIS_IS_A_DEMO_KEY_CHANGE_IT_123456789";
var tokenHandler = new JwtSecurityTokenHandler();
var tokenDescriptor = new SecurityTokenDescriptor
{
    Subject = new ClaimsIdentity(new[] {
        new Claim(JwtRegisteredClaimNames.Sub, "11111111-1111-1111-1111-111111111111"),
        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
    }),
    Expires = DateTime.UtcNow.AddHours(1),
    Issuer = "MiniIdentityApi",
    Audience = "MiniIdentityApiUsers",
    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key)), SecurityAlgorithms.HmacSha256)
};
var token = tokenHandler.CreateToken(tokenDescriptor);
Console.WriteLine(tokenHandler.WriteToken(token));
