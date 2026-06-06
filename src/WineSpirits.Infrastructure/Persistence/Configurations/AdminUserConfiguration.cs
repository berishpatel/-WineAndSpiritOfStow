using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WineSpirits.Domain.Entities;

namespace WineSpirits.Infrastructure.Persistence.Configurations;

internal sealed class AdminUserConfiguration : IEntityTypeConfiguration<AdminUser>
{
    public void Configure(EntityTypeBuilder<AdminUser> builder)
    {
        builder.HasKey(admin => admin.Id);

        builder.Property(admin => admin.Email)
            .HasMaxLength(320)
            .IsRequired();

        builder.Property(admin => admin.PasswordHash)
            .HasMaxLength(500)
            .IsRequired();

        builder.HasIndex(admin => admin.Email)
            .IsUnique();
    }
}
