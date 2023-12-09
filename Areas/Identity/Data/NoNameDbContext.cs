using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NoName.Areas.Identity.Data;
using NoName.Models;

namespace NoName.Data;

public class NoNameDbContext : IdentityDbContext<ApplicationUser>
{
    public NoNameDbContext(DbContextOptions<NoNameDbContext> options)
        : base(options)
    {
    }

    public DbSet<Attribution> Attributes { get; set; }
    public DbSet<Menu> Menus { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductAttribute> ProductAttributes{ get; set; }
    public DbSet<ProductImage> ProductImages{ get; set; }
    public DbSet<ProductRelated> ProductRelateds { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Article> Articals { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
