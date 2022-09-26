using Microsoft.EntityFrameworkCore;

namespace WebApiMasterTemplate.Domain.DbSeeds
{
  public static class ModelBuilderExtensions
  {
    public static void Seed(this ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfiguration(new UserSeed());
      modelBuilder.ApplyConfiguration(new TaskTrackerSeed());
      modelBuilder.ApplyConfiguration(new TaskKeeperSeed());
    }
  }
}
