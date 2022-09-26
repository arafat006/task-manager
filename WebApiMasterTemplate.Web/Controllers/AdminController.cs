using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Text.Json;
using WebApiMasterTemplate.Web.DtoModels;

namespace WebApiMasterTemplate.Web.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  [Authorize(Roles = "Admin")]
  public class AdminController : ControllerBase
  {
    [HttpGet("Admins")]
    public IActionResult AdminsEndpoint()
    {
      var currentUser = GetCurrentUser();
      return Ok(JsonSerializer.Serialize(currentUser));
    }

    private UserDto? GetCurrentUser()
    {
      var identity = HttpContext.User.Identity as ClaimsIdentity;

      if (identity != null)
      {
        var userClaims = identity.Claims;

        return new UserDto
        {
          Id = userClaims.FirstOrDefault(o => o.Type == ClaimTypes.PrimarySid)?.Value,
          Name = userClaims.FirstOrDefault(o => o.Type == ClaimTypes.GivenName)?.Value,
          Email = userClaims.FirstOrDefault(o => o.Type == ClaimTypes.Email)?.Value,
          Role = userClaims.FirstOrDefault(o => o.Type == ClaimTypes.Role)?.Value
        };
      }

      return null;
    }
  }
}
