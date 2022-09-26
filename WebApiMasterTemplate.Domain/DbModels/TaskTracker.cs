using WebApiMasterTemplate.Domain.DbModels.Base;

namespace WebApiMasterTemplate.Domain.DbModels
{
  public class TaskTracker : BaseEntity
  {
    public long CreatedBy { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime Deadline { get; set; }
    public DateTime LastUpdatedDate { get; set; }
    public User User { get; set; }
    public ICollection<TaskKeeper> TaskKeepers { get; set; }
  }
}
