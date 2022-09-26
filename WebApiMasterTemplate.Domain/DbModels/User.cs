using WebApiMasterTemplate.Domain.DbModels.Base;

namespace WebApiMasterTemplate.Domain.DbModels
{
  public class User : BaseEntity
  {
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public DateTime CreatedDate { get; set; }
    public bool IsVerified { get; set; }
    public bool IsDisabled { get; set; }
    public ICollection<TaskTracker> TaskTrackers { get; set; }
    public UserRole UserRole { get; set; }
    public Verification Verification { get; set; }
  }
}
