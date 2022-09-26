using Microsoft.EntityFrameworkCore;
using WebApiMasterTemplate.Domain.DbContexts;
using WebApiMasterTemplate.Domain.DbModels;
using WebApiMasterTemplate.Service.Models;
using WebApiMasterTemplate.Service.Services;
using WebApiMasterTemplate.Web.DtoModels;
using static WebApiMasterTemplate.Web.Constants.GlobalConstants;

namespace WebApiMasterTemplate.Web.Services
{
  public interface IUserService
  {
    Task AddNewUser(User user);
    Task UpdateExistingUser(User user);
    Task<User?> GetUserByIdAsync(long id);
    Task<User?> GetUserIfRegisteredButNotVerifiedAsync(string email);
    bool UserRegistered(string email);
    bool UserVerified(string email);
    bool AccountDisabled(string email);
    User? GetUser(string email, string password);
    Task VerificationCodeGenerateAndSaveThenSendAsync(User user);
    Task<ResultDto> VerifyUserAsync(string email, int verificationCode);
  }

  public class UserService : IUserService
  {
    private readonly TaskPlannerDbContext _taskPlannerDbContext;
    private readonly ILogger _logger;
    private readonly IEmailService _emailService;

    public UserService(TaskPlannerDbContext taskPlannerDbContext, IEmailService emailService)
    {
      _taskPlannerDbContext = taskPlannerDbContext;
      _emailService = emailService;
    }

    public async Task AddNewUser(User user)
    {
      try
      {
        await _taskPlannerDbContext.User.AddAsync(user);
        await _taskPlannerDbContext.SaveChangesAsync();
      }
      catch(Exception e)
      {
        _logger.LogError(e, "Error occured while adding new user in function: AddNewUser()");
      }
    }

    public async Task UpdateExistingUser(User user)
    {
      try
      {
        _taskPlannerDbContext.User.Update(user);
        await _taskPlannerDbContext.SaveChangesAsync();
      }
      catch(Exception e)
      {
        _logger.LogError(e, "Error occured while updating existing user in function: UpdateExistingUser()");
      }
    }

    public async Task<User?> GetUserByIdAsync(long id) => await _taskPlannerDbContext.User.FirstOrDefaultAsync(user => user.Id.Equals(id));

    public async Task<User?> GetUserIfRegisteredButNotVerifiedAsync(string email) => 
      await _taskPlannerDbContext.User.Where(user => user.Email.Equals(email) && !user.IsVerified).Include(user => user.Verification).FirstOrDefaultAsync();

    public bool UserRegistered(string email) =>
      _taskPlannerDbContext.User.Any(user => user.Email.Equals(email));

    public bool UserVerified(string email) =>
      _taskPlannerDbContext.User.Any(user => user.Email.Equals(email) && user.IsVerified);

    public bool AccountDisabled(string email) =>
      _taskPlannerDbContext.User.Any(user => user.Email.Equals(email) && user.IsDisabled);

    public User? GetUser(string email, string password)
    {
      var user = _taskPlannerDbContext.User.FirstOrDefault(user => user.Email.Equals(email) && user.Password.Equals(password));
      
      if(user != null) 
        user.UserRole = _taskPlannerDbContext.UserRole.First(userRole => userRole.UserId.Equals(user.Id));
       
      return user;
    }

    public async Task VerificationCodeGenerateAndSaveThenSendAsync(User user)
    {
      var newVerificationCode = new Random().Next(100000, 999999);
      var existingVerificationModel = user.Verification;

      if (existingVerificationModel != null)
      {
        existingVerificationModel.Attemps = 0;
        existingVerificationModel.Code = newVerificationCode;
        existingVerificationModel.ExpiredDate = DateTime.UtcNow.AddMinutes(VerificationCodeLifeTimeInMinutes);

        _taskPlannerDbContext.VerificationCode.Update(existingVerificationModel);
      }
      else
      {
        var newVerificationModel = new Verification()
        {
          UserId = user.Id,
          Code = newVerificationCode,
          ExpiredDate = DateTime.UtcNow.AddMinutes(VerificationCodeLifeTimeInMinutes)
        };

        await _taskPlannerDbContext.VerificationCode.AddAsync(newVerificationModel);
      }

      await _taskPlannerDbContext.SaveChangesAsync();
      await SendVerificationCodeAsync(user.Email, newVerificationCode);
    }

    public async Task<ResultDto> VerifyUserAsync(string email, int verificationCode)
    {
      var user = await _taskPlannerDbContext.User.Where(user => user.Email.Equals(email)).Include(user => user.Verification).FirstOrDefaultAsync();

      if (user == null)
        return new ResultDto(false, "Account doesn't exists");

      if (user.IsDisabled)
        return new ResultDto(false, "Account is disabled");

      if (user.IsVerified)
        return new ResultDto(false, "Already verified");

      if (user.Verification.IsUsedOnce)
        return new ResultDto(false, "Verification code is already used");

      if (user.Verification.Attemps >= MaxAttemps)
        return new ResultDto(false, "Maximum attempt limit exceeded");

      if (user.Verification.ExpiredDate.Subtract(DateTime.UtcNow).TotalSeconds <= 0)
        return new ResultDto(false, "Time expired");

      if(user.Verification.Code != verificationCode)
      {
        user.Verification.Attemps++;
        _taskPlannerDbContext.VerificationCode.Update(user.Verification);
        await _taskPlannerDbContext.SaveChangesAsync();
        return new ResultDto(false, "Verification code doesn't match");
      }

      if(user.Verification.Code == verificationCode)
      {
        user.Verification.IsUsedOnce = true;
        user.IsVerified = true;
        _taskPlannerDbContext.User.Update(user);
        await _taskPlannerDbContext.SaveChangesAsync();
        return new ResultDto(true, "User verification successfull");
      }

      return new ResultDto(false, "Verification failed");
    }

    private async Task SendVerificationCodeAsync(string email, int verificationCode)
    {
      var emailDto = new EmailDto()
      {
        Receivers = email,
        Subject = "Verification code",
        Body = $"Your verification code is <b>{verificationCode}</b>. This code will be expired after 15 minutes from now."
      };

      await _emailService.SendEmailAsync(emailDto);
    }
  }
}
