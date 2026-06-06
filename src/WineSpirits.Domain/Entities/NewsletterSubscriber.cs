namespace WineSpirits.Domain.Entities;

public sealed class NewsletterSubscriber
{
    public Guid Id { get; set; }

    public string Email { get; set; } = string.Empty;

    public bool IsActive { get; set; } = true;

    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
}
