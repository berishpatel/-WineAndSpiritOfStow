namespace WineSpirits.Domain.Entities;

public sealed class StoreSetting
{
    public Guid Id { get; set; }

    public string StoreName { get; set; } = "Wine & Spirits Of Stow";

    public string Phone { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string AddressLine1 { get; set; } = string.Empty;

    public string? AddressLine2 { get; set; }

    public string City { get; set; } = string.Empty;

    public string State { get; set; } = string.Empty;

    public string PostalCode { get; set; } = string.Empty;

    public string GoogleMapsUrl { get; set; } = string.Empty;

    public string HoursJson { get; set; } = "{}";

    public string? AnnouncementText { get; set; }
}
