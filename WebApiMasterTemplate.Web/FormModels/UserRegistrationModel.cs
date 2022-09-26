using System.ComponentModel.DataAnnotations;

namespace WebApiMasterTemplate.Web.FormModels
{
  public class UserRegistrationModel
  {
    [Required(ErrorMessage = "Name is required")]
    [MinLength(4, ErrorMessage = "Name is too short")]
    [MaxLength(100, ErrorMessage = "Name is too long")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid email type")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Password is required")]
    [MinLength(5, ErrorMessage = "Password is too short")]
    public string Password { get; set; }
  }
}
