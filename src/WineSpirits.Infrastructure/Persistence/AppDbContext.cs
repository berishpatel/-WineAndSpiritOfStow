using Microsoft.EntityFrameworkCore;
using WineSpirits.Domain.Entities;

namespace WineSpirits.Infrastructure.Persistence;

public sealed class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<AdminUser> AdminUsers => Set<AdminUser>();

    public DbSet<Category> Categories => Set<Category>();

    public DbSet<ContactMessage> ContactMessages => Set<ContactMessage>();

    public DbSet<NewsletterSubscriber> NewsletterSubscribers => Set<NewsletterSubscriber>();

    public DbSet<Product> Products => Set<Product>();

    public DbSet<Special> Specials => Set<Special>();

    public DbSet<StoreSetting> StoreSettings => Set<StoreSetting>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}
