using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApiMasterTemplate.Domain.DbModels;

namespace WebApiMasterTemplate.Domain.DbMappings
{
  public class TaskKeeperMap : IEntityTypeConfiguration<TaskKeeper>
  {
    public void Configure(EntityTypeBuilder<TaskKeeper> builder)
    {
      builder.ToTable("Task");
      builder.HasKey(taskKeeper => taskKeeper.Id);
      builder.Property(taskKeeper => taskKeeper.Title).IsRequired().HasColumnType("nvarchar(50)");
      builder.Property(taskKeeper => taskKeeper.Deadline).IsRequired();
      builder.Property(taskKeeper => taskKeeper.State).IsRequired();
      builder.HasOne(taskKeeper => taskKeeper.TaskTracker).WithMany(taskTracker => taskTracker.TaskKeepers)
                                                          .HasForeignKey(taskKeeper => taskKeeper.TaskTrackerId)
                                                          .IsRequired();
    }
  }
}
