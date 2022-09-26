using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using WebApiMasterTemplate.Service.Models;

namespace WebApiMasterTemplate.Service.Services
{
  public interface IEmailService
  {
    Task<bool> SendEmailAsync(EmailDto emailDto);
  }

  public class EmailService : IEmailService
  {
    private readonly IConfiguration _config;

    public EmailService(IConfiguration config)
    {
      _config = config;
    }

    public async Task<bool> SendEmailAsync(EmailDto emailDto)
    {
      var client = new SendGridClient(_config["SendGrid:ApiKey"]);

      var mail = new SendGridMessage()
      {
        From = new EmailAddress(_config["SendGrid:SenderEmail"]),
        Subject = emailDto.Subject,
        HtmlContent = emailDto.Body
      };

      mail.AddTos(emailDto.Receivers.Split(',').Select(email => MailHelper.StringToEmailAddress(email)).ToList());
      
      var response = await client.SendEmailAsync(mail);
      
      if(response.IsSuccessStatusCode)
        return true;

      return false;
    }
  }
}
