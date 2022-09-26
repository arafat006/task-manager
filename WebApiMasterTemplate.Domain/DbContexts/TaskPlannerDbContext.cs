using Microsoft.EntityFrameworkCore;
using WebApiMasterTemplate.Domain.DbMappings;
using WebApiMasterTemplate.Domain.DbModels;
using WebApiMasterTemplate.Domain.DbSeeds;

namespace WebApiMasterTemplate.Domain.DbContexts
{
  public class TaskPlannerDbContext : DbContext
  {
    public TaskPlannerDbContext(DbContextOptions<TaskPlannerDbContext> options) : base(options)
    {

    }

    public DbSet<User> User { get; set; }
    public DbSet<TaskTracker> TaskTracker { get; set; }
    public DbSet<TaskKeeper> Task { get; set; }
    public DbSet<UserRole> UserRole { get; set; }
    public DbSet<Verification> VerificationCode { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfiguration(new UserMap());
      modelBuilder.ApplyConfiguration(new TaskTrackerMap());
      modelBuilder.ApplyConfiguration(new TaskKeeperMap());
      modelBuilder.ApplyConfiguration(new UserRoleMap());
      modelBuilder.ApplyConfiguration(new VerificationMap());
      //modelBuilder.Seed();
    }
  }
}
