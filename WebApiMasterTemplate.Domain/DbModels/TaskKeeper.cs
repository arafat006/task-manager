using WebApiMasterTemplate.Domain.DbModels.Base;

namespace WebApiMasterTemplate.Domain.DbModels
{
  public class TaskKeeper : BaseEntity
  {
    public long TaskTrackerId { get; set; }
    public string Title { get; set; }
    public DateTime Deadline { get; set; }
    public int State { get; set; } /*{ Pending = 1, Running = 2, Finished = 3, Paused = 4 }*/
    public TaskTracker TaskTracker { get; set; }
  }
}