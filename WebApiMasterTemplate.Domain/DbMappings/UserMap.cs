using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApiMasterTemplate.Domain.DbModels;

namespace WebApiMasterTemplate.Domain.DbMappings
{
  public class UserMap : IEntityTypeConfiguration<User>
  {
    public void Configure(EntityTypeBuilder<User> builder)
    {
      builder.ToTable("User");
      builder.HasKey(user => user.Id);
      builder.Property(user => user.Id).UseIdentityColumn();
      builder.Property(user => user.Name).IsRequired().HasColumnType("nvarchar(100)");
      builder.HasIndex(user => user.Email).IsUnique();
      builder.Property(user => user.Password).IsRequired().HasColumnType("nvarchar(128)");
      builder.Property(user => user.IsVerified).IsRequired().HasDefaultValue(false);
      builder.Property(user => user.IsDisabled).IsRequired().HasDefaultValue(false);
      builder.Property(user => user.CreatedDate).IsRequired();
    }
  }
}
