using System.ComponentModel.DataAnnotations;

namespace WebApiMasterTemplate.Web.FormModels
{
  public class UserLoginModel
  {
    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid email type")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Password is required")]
    [MinLength(5, ErrorMessage = "Password is too short")]
    public string Password { get; set; }
  }
}
