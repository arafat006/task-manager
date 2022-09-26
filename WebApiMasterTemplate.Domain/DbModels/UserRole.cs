using WebApiMasterTemplate.Domain.DbModels.Base;

namespace WebApiMasterTemplate.Domain.DbModels
{
  public class UserRole : BaseEntity
  {
    public long UserId { get; set; }
    public int Role { get; set; }
    public User User { get; set; }
  }
}
