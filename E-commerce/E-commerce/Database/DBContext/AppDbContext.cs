using ecommerce.Models.Option.Models;
using ecommerce.Models.Order.Models;
using ecommerce.Models.Product.Models;
using ecommerce.Models.User.Models;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Database.DBContext;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<User> Users => Set<User>();
    public DbSet<Option> Options => Set<Option>();
    public DbSet<Order> Orders => Set<Order>();
    public DbSet<Product> Products => Set<Product>();
    public DbSet<ThumbImage> Thumbs => Set<ThumbImage>();
    public DbSet<OrderDetail> OrderDetails => Set<OrderDetail>();
    public DbSet<OptionGroup> OptionsGroups => Set<OptionGroup>();
    public DbSet<ProductOption> ProductOptions => Set<ProductOption>();
}
