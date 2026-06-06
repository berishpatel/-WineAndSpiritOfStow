using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WineSpirits.Domain.Entities;

namespace WineSpirits.Infrastructure.Persistence.Configurations;

internal sealed class ContactMessageConfiguration : IEntityTypeConfiguration<ContactMessage>
{
    public void Configure(EntityTypeBuilder<ContactMessage> builder)
    {
        builder.HasKey(message => message.Id);

        builder.Property(message => message.Name)
            .HasMaxLength(160)
            .IsRequired();

        builder.Property(message => message.Email)
            .HasMaxLength(320)
            .IsRequired();

        builder.Property(message => message.Phone)
            .HasMaxLength(40);

        builder.Property(message => message.Message)
            .HasMaxLength(2000)
            .IsRequired();
    }
}
