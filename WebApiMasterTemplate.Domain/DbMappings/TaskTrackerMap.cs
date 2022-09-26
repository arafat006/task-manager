using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApiMasterTemplate.Domain.DbModels;

namespace WebApiMasterTemplate.Domain.DbMappings
{
  public class TaskTrackerMap : IEntityTypeConfiguration<TaskTracker>
  {
    public void Configure(EntityTypeBuilder<TaskTracker> builder)
    {
      builder.ToTable("TaskTracker");
      builder.HasKey(taskTracke => taskTracke.Id);
      builder.Property(taskTracke => taskTracke.Title).IsRequired().HasColumnType("nvarchar(50)");
      builder.Property(taskTracke => taskTracke.Description).IsRequired();
      builder.Property(taskTracke => taskTracke.CreationDate).IsRequired();
      builder.Property(taskTracke => taskTracke.Deadline).IsRequired();
      builder.Property(taskTracke => taskTracke.LastUpdatedDate).IsRequired();
      builder.HasOne(taskTracke => taskTracke.User).WithMany(user => user.TaskTrackers)
                                                   .HasForeignKey(taskTracker => taskTracker.CreatedBy)
                                                   .IsRequired();
    }
  }
}
