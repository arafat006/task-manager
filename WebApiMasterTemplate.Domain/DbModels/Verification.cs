using WebApiMasterTemplate.Domain.DbModels.Base;

namespace WebApiMasterTemplate.Domain.DbModels
{
  public class Verification : BaseEntity
  {
    public long UserId { get; set; }
    public int Code { get; set; }
    public int Attemps { get; set; } //Max attemps = 5
    public bool IsUsedOnce { get; set; } = false;
    public DateTime ExpiredDate { get; set; } //Current Time + 15 minutes
    public User User { get; set; }
  }
}
