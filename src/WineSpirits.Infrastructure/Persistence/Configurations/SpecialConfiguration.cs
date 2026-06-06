using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WineSpirits.Domain.Entities;

namespace WineSpirits.Infrastructure.Persistence.Configurations;

internal sealed class SpecialConfiguration : IEntityTypeConfiguration<Special>
{
    public void Configure(EntityTypeBuilder<Special> builder)
    {
        builder.HasKey(special => special.Id);

        builder.Property(special => special.Title)
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(special => special.Description)
            .HasMaxLength(1000);

        builder.Property(special => special.DiscountText)
            .HasMaxLength(120)
            .IsRequired();

        builder.HasOne(special => special.Product)
            .WithMany()
            .HasForeignKey(special => special.ProductId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
