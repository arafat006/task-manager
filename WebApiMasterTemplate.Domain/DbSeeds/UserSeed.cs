using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApiMasterTemplate.Domain.DbModels;

namespace WebApiMasterTemplate.Domain.DbSeeds
{
  internal class UserSeed : IEntityTypeConfiguration<User>
  {
    public void Configure(EntityTypeBuilder<User> builder)
    {
      builder.HasData(
        GetUserSeedData()
      );
    }

    public IEnumerable<User> GetUserSeedData()
    {
      int userId = 1;
      var faker = new Faker("en");
      var random = new Randomizer();
      var userSeeder = new Faker<User>().RuleFor(user => user.Id, faker => userId++)
                                      .RuleFor(user => user.Name, faker => faker.Name.FullName())
                                      .RuleFor(user => user.Email, (faker, user) => faker.Internet.Email(user.Name))
                                      .RuleFor(user => user.Password, faker => faker.Internet.Password(128))
                                      .RuleFor(user => user.CreatedDate, faker => DateTime.UtcNow);

      var userSeed = userSeeder.Generate(10);
      return userSeed.ToList();
    }
  }
}



/*new User
{
  Id = 1,
  Name = "Arafat Hossain",
  Email = "arafat@gmail.com",
  Password = "7110EDA4D09E062AA5E4A390B0A572AC0D2C0220",
  CreatedDate = DateTime.UtcNow
},
new User
{
  Id = 2,
  Name = "Abir Hassan",
  Email = "abir@gmail.com",
  Password = "7110EDA4D09E062AA5E4A390B0A572AC0D2C0220",
  CreatedDate = DateTime.UtcNow
}, new User
{
  Id = 3,
  Name = "Sadman Haque",
  Email = "sadman@gmail.com",
  Password = "7110EDA4D09E062AA5E4A390B0A572AC0D2C0220",
  CreatedDate = DateTime.UtcNow
}*/