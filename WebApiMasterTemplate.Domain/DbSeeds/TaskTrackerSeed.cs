using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApiMasterTemplate.Domain.DbModels;

namespace WebApiMasterTemplate.Domain.DbSeeds
{
  internal class TaskTrackerSeed : IEntityTypeConfiguration<TaskTracker>
  {
    public void Configure(EntityTypeBuilder<TaskTracker> builder)
    {
      builder.HasData(
        GetTaskTrackerSeedData()
      );
    }

    public IEnumerable<TaskTracker> GetTaskTrackerSeedData()
    {
      int taskTrackerId = 1;
      int userId = 1;
      int stepCount = 1;
      var faker = new Faker("en");
      var random = new Randomizer();
      var taskTrackerCount = 30;
      var taskTrackerSeeder = new Faker<TaskTracker>().RuleFor(taskTracker => taskTracker.Id, faker => taskTrackerId++)
                                                      .RuleFor(taskTracker => taskTracker.Title, faker => faker.Lorem.Sentence(random.Number(1, 2)))
                                                      .RuleFor(taskTracker => taskTracker.Description, faker => faker.Lorem.Sentence(random.Number(5, 10)))
                                                      .RuleFor(taskTracker => taskTracker.CreationDate, faker => DateTime.UtcNow)
                                                      .RuleFor(taskTracker => taskTracker.Deadline, faker => DateTime.UtcNow.AddDays(7))
                                                      .RuleFor(taskTracker => taskTracker.LastUpdatedDate, faker => DateTime.UtcNow);

      var taskTrackerSeed = taskTrackerSeeder.Generate(taskTrackerCount);
      foreach(var taskTracker in taskTrackerSeed)
      {
        taskTracker.CreatedBy = userId;

        if(stepCount++ % 3 == 0)
          userId++;
      }

      return taskTrackerSeed.ToList();
    }
  }
}
