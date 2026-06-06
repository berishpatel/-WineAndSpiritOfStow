using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WineSpirits.Domain.Entities;

namespace WineSpirits.Infrastructure.Persistence.Configurations;

internal sealed class StoreSettingConfiguration : IEntityTypeConfiguration<StoreSetting>
{
    public void Configure(EntityTypeBuilder<StoreSetting> builder)
    {
        builder.HasKey(settings => settings.Id);

        builder.Property(settings => settings.StoreName)
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(settings => settings.Phone)
            .HasMaxLength(40);

        builder.Property(settings => settings.Email)
            .HasMaxLength(320);

        builder.Property(settings => settings.AddressLine1)
            .HasMaxLength(200);

        builder.Property(settings => settings.AddressLine2)
            .HasMaxLength(200);

        builder.Property(settings => settings.City)
            .HasMaxLength(120);

        builder.Property(settings => settings.State)
            .HasMaxLength(80);

        builder.Property(settings => settings.PostalCode)
            .HasMaxLength(20);

        builder.Property(settings => settings.GoogleMapsUrl)
            .HasMaxLength(1000);

        builder.Property(settings => settings.HoursJson)
            .HasColumnType("jsonb")
            .IsRequired();

        builder.Property(settings => settings.AnnouncementText)
            .HasMaxLength(500);
    }
}
