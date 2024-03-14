using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancePlanner.Entities.User
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey("ID");

            builder.Property(x => x.Id).HasColumnName("Id").HasColumnType("uniqueidentifier").IsRequired(true).ValueGeneratedNever();
            builder.Property(x => x.EmailAddress).HasColumnName("EmailAddress").HasColumnType("varchar").IsUnicode(true).IsRequired(true).HasMaxLength(100);
            builder.Property(x => x.CreatedDate).HasColumnName("CreatedDate").HasColumnType("datetime").IsRequired(true).ValueGeneratedNever();
            builder.Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").HasColumnType("datetime").IsRequired(false);
        }
    }
}
