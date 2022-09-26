using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApiMasterTemplate.Domain.DbModels;

namespace WebApiMasterTemplate.Domain.DbSeeds
{
  internal class TaskKeeperSeed : IEntityTypeConfiguration<TaskKeeper>
  {
    public void Configure(EntityTypeBuilder<TaskKeeper> builder)
    {
      builder.HasData(
        GetTaskKeeperSeedData()
      );
    }

    public IEnumerable<TaskKeeper> GetTaskKeeperSeedData()
    {
      int taskKeeperId = 1;
      int taskTrackerId = 1;
      int stepCount = 1;
      var faker = new Faker("en");
      var random = new Randomizer();
      var taskKeeperCount = 150;
      var taskKeeperSeeder = new Faker<TaskKeeper>().RuleFor(taskTracker => taskTracker.Id, faker => taskKeeperId++)
                                                     .RuleFor(taskTracker => taskTracker.Title, faker => faker.Lorem.Sentence(random.Number(1, 2)))
                                                     .RuleFor(taskTracker => taskTracker.Deadline, DateTime.UtcNow.AddDays(random.Number(1, 7)))
                                                     .RuleFor(taskTracker => taskTracker.State, faker => random.Number(1, 4));

      var taskKeeperSeed = taskKeeperSeeder.Generate(taskKeeperCount);
      foreach(var taskKeeper in taskKeeperSeed)
      {
        taskKeeper.TaskTrackerId = taskTrackerId;

        if(stepCount++ % 5 == 0)
          taskTrackerId++;
      }

      return taskKeeperSeed.ToList();
    }
  }
}
