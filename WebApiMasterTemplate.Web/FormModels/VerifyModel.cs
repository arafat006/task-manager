using System.ComponentModel.DataAnnotations;

namespace WebApiMasterTemplate.Web.FormModels
{
  public class VerifyModel
  {
    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid email type")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Verification code is required")]
    public int VerificationCode { get; set; }
  }
}
