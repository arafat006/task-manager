using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApiMasterTemplate.Domain.DbModels;
using WebApiMasterTemplate.Web.FormModels;
using WebApiMasterTemplate.Web.Services;

namespace WebApiMasterTemplate.Web.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class RegistrationController : ControllerBase
  {
    private readonly IMapper _mapper;
    private readonly IUserService _userService;

    public RegistrationController(IMapper mapper, IUserService userService)
    {
      _mapper = mapper;
      _userService = userService;
    }

    [AllowAnonymous]
    [HttpPost]
    public async Task<IActionResult> Register([FromBody] UserRegistrationModel userRegistrationModel)
    {
      if (_userService.UserVerified(userRegistrationModel.Email))
        return Conflict("This email is already in use");

      if (_userService.AccountDisabled(userRegistrationModel.Email))
        return Conflict("This account is disabled");

      var existingUser = await _userService.GetUserIfRegisteredButNotVerifiedAsync(userRegistrationModel.Email);
     
      if (existingUser != null)
      {
        var timeDifferenceInSeconds = existingUser.Verification.ExpiredDate.Subtract(DateTime.UtcNow).TotalSeconds;
        var timeSpan = TimeSpan.FromSeconds(timeDifferenceInSeconds);

        if (timeDifferenceInSeconds > 0)
          return Conflict($"Use previous verification code or wait {timeSpan.Minutes:00}:{timeSpan.Seconds:00} seconds to request a new code");
        
        existingUser.Name = userRegistrationModel.Name;
        existingUser.Password = userRegistrationModel.Password;
        existingUser.CreatedDate = DateTime.UtcNow;

        await _userService.UpdateExistingUser(existingUser);
        await _userService.VerificationCodeGenerateAndSaveThenSendAsync(existingUser);
      }
      else
      {
        User user = _mapper.Map<User>(userRegistrationModel);
        user.CreatedDate = DateTime.UtcNow;
        user.UserRole = new UserRole() { Role = 2 };

        await _userService.AddNewUser(user);
        await _userService.VerificationCodeGenerateAndSaveThenSendAsync(user);
      }

      return Ok("User is created successfully");
    }

    [AllowAnonymous]
    [HttpPost("verify")]
    public async Task<IActionResult> Verify([FromBody] VerifyModel verifyModel)
    {
      var result = await _userService.VerifyUserAsync(verifyModel.Email, verifyModel.VerificationCode);

      if (result.IsSuccess)
        return Ok(result.Information);

      return ValidationProblem(result.Information);
    }
  }
}
