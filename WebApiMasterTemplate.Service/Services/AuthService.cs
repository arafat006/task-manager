using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebApiMasterTemplate.Domain.DbModels;
using static WebApiMasterTemplate.Domain.Enums.UserRole;

namespace WebApiMasterTemplate.Service.Services
{
  public interface IAuthService
  {
    string GenerateJwtToken(User user);
  }

  public class AuthService : IAuthService
  {
    private readonly IConfiguration _config;

    public AuthService(IConfiguration config)
    {
      _config = config;
    }

    public string GenerateJwtToken(User user)
    {
      var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
      var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

      var claims = new[]
      {
        new Claim(ClaimTypes.PrimarySid, user.Id.ToString()),
        new Claim(ClaimTypes.GivenName, user.Name),
        new Claim(ClaimTypes.Email, user.Email),
        new Claim(ClaimTypes.Role, ((Role)user.UserRole.Role).ToString())
      };

      var token = new JwtSecurityToken(_config["Jwt:Issuer"],
        _config["Jwt:Audience"],
        claims,
        expires: DateTime.UtcNow.AddMinutes(15),
        signingCredentials: credentials);

      return new JwtSecurityTokenHandler().WriteToken(token);
    }
  }
}
