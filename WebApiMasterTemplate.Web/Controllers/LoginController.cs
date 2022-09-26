using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApiMasterTemplate.Service.Services;
using WebApiMasterTemplate.Web.FormModels;
using WebApiMasterTemplate.Web.Services;

namespace WebApiMasterTemplate.Web.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class LoginController : ControllerBase
  {
    private readonly IUserService _userService;
    private readonly IAuthService _authService;

    public LoginController(IUserService userService, IAuthService authService)
    {
      _userService = userService;
      _authService = authService;
    }

    [AllowAnonymous]
    [HttpPost]
    public IActionResult Login([FromBody] UserLoginModel userLoginModel)
    {
      var user = _userService.GetUser(userLoginModel.Email, userLoginModel.Password);

      if (user != null)
      {
        if (!user.IsVerified)
          return Unauthorized("Unverified");

        if (user.IsDisabled)
          return Unauthorized("Disabled");

        var token = _authService.GenerateJwtToken(user);
        return Ok(new { Token = token });
      }

      return Unauthorized("Not found");
    }
  }
}
