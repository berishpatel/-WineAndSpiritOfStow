using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WineSpirits.Domain.Entities;

namespace WineSpirits.Infrastructure.Persistence.Configurations;

internal sealed class NewsletterSubscriberConfiguration : IEntityTypeConfiguration<NewsletterSubscriber>
{
    public void Configure(EntityTypeBuilder<NewsletterSubscriber> builder)
    {
        builder.HasKey(subscriber => subscriber.Id);

        builder.Property(subscriber => subscriber.Email)
            .HasMaxLength(320)
            .IsRequired();

        builder.HasIndex(subscriber => subscriber.Email)
            .IsUnique();
    }
}
