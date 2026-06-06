namespace WineSpirits.Domain.Entities;

public sealed class Special
{
    public Guid Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public Guid? ProductId { get; set; }

    public Product? Product { get; set; }

    public string DiscountText { get; set; } = string.Empty;

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public bool IsActive { get; set; } = true;
}
