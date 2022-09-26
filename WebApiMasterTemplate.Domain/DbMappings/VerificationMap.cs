using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApiMasterTemplate.Domain.DbModels;

namespace WebApiMasterTemplate.Domain.DbMappings
{
  public class VerificationMap : IEntityTypeConfiguration<Verification>
  {
    public void Configure(EntityTypeBuilder<Verification> builder)
    {
      builder.ToTable("Verification");
      builder.HasKey(verification => verification.Id);
      builder.Property(verification => verification.Code).IsRequired();
      builder.Property(verification => verification.Attemps).IsRequired().HasDefaultValue(0);
      builder.Property(verification => verification.IsUsedOnce).IsRequired().HasDefaultValue(false);
      builder.Property(verification => verification.ExpiredDate).IsRequired();
      builder.HasOne(verification => verification.User).WithOne(user => user.Verification)
                                                       .HasForeignKey<Verification>(verification => verification.UserId)
                                                       .IsRequired();
    }
  }
}
