using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApiMasterTemplate.Domain.DbModels;

namespace WebApiMasterTemplate.Domain.DbMappings
{
  public class UserRoleMap : IEntityTypeConfiguration<UserRole>
  {
    public void Configure(EntityTypeBuilder<UserRole> builder)
    {
      builder.ToTable("UserRole");
      builder.HasKey(userRole => userRole.Id);
      builder.Property(userRole => userRole.Role).IsRequired().HasMaxLength(1);
      builder.HasOne(userRole => userRole.User).WithOne(user => user.UserRole)
                                               .HasForeignKey<UserRole>(userRoler => userRoler.UserId)
                                               .IsRequired();
    }
  }
}
