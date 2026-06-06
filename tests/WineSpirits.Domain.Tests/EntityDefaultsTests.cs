using WineSpirits.Domain.Entities;
using WineSpirits.Domain.Enums;

namespace WineSpirits.Domain.Tests;

public sealed class EntityDefaultsTests
{
    [Fact]
    public void Product_Defaults_To_Available_With_Current_Timestamps()
    {
        var before = DateTimeOffset.UtcNow;

        var product = new Product();

        Assert.True(product.IsAvailable);
        Assert.False(product.IsFeatured);
        Assert.False(product.IsStaffPick);
        Assert.True(product.CreatedAt >= before);
        Assert.True(product.UpdatedAt >= before);
    }

    [Fact]
    public void StoreSetting_Defaults_To_Project_Store_Name()
    {
        var settings = new StoreSetting();

        Assert.Equal("Wine & Spirits Of Stow", settings.StoreName);
        Assert.Equal("{}", settings.HoursJson);
    }

    [Fact]
    public void ContactMessage_Defaults_To_New_Status()
    {
        var message = new ContactMessage();

        Assert.Equal(ContactMessageStatus.New, message.Status);
    }

    [Fact]
    public void AdminUser_Defaults_To_Admin_Role_And_Active()
    {
        var admin = new AdminUser();

        Assert.Equal(AdminRole.Admin, admin.Role);
        Assert.True(admin.IsActive);
    }
}
