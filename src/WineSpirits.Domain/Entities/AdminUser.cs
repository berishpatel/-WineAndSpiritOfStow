using WineSpirits.Domain.Enums;

namespace WineSpirits.Domain.Entities;

public sealed class AdminUser
{
    public Guid Id { get; set; }

    public string Email { get; set; } = string.Empty;

    public string PasswordHash { get; set; } = string.Empty;

    public AdminRole Role { get; set; } = AdminRole.Admin;

    public bool IsActive { get; set; } = true;

    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
}
