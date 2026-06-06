using WineSpirits.Domain.Entities;

namespace WineSpirits.Infrastructure.Persistence.SeedData;

internal static class CategorySeedData
{
    public static readonly Guid WineId = Guid.Parse("9a7aa40f-a636-47d5-9f29-03f0600a4a73");
    public static readonly Guid WhiskeyId = Guid.Parse("d86d22e1-d6d7-4c82-a6d5-ad970d090e50");
    public static readonly Guid VodkaId = Guid.Parse("6a74fb4e-1445-4725-90d2-8f2ec15a9d49");
    public static readonly Guid TequilaId = Guid.Parse("80a8ca38-20c8-4c46-a5df-0ab2c5de43ef");
    public static readonly Guid RumId = Guid.Parse("68d05ca3-49dc-49b4-994a-a2dd242a7f2d");
    public static readonly Guid GinId = Guid.Parse("6607e336-93bb-4925-9c59-3e0c63684f73");
    public static readonly Guid BeerId = Guid.Parse("4a839ae2-2a76-4a56-9748-f64d2e8cf82d");
    public static readonly Guid ChampagneId = Guid.Parse("24d17ed0-0ce0-49c7-89cc-29e46a5c7e48");
    public static readonly Guid MixersId = Guid.Parse("8119c50d-519c-46f8-b8ee-c95d9f88a40e");
    public static readonly Guid GiftsId = Guid.Parse("ae69d097-8358-4f18-a105-c4ea0eeb64ea");

    public static Category[] Categories =>
    [
        Create(WineId, "Wine", "wine", 10),
        Create(WhiskeyId, "Whiskey", "whiskey", 20),
        Create(VodkaId, "Vodka", "vodka", 30),
        Create(TequilaId, "Tequila", "tequila", 40),
        Create(RumId, "Rum", "rum", 50),
        Create(GinId, "Gin", "gin", 60),
        Create(BeerId, "Beer", "beer", 70),
        Create(ChampagneId, "Champagne", "champagne", 80),
        Create(MixersId, "Mixers", "mixers", 90),
        Create(GiftsId, "Gifts", "gifts", 100)
    ];

    private static Category Create(Guid id, string name, string slug, int displayOrder)
    {
        return new Category
        {
            Id = id,
            Name = name,
            Slug = slug,
            DisplayOrder = displayOrder,
            IsActive = true
        };
    }
}
