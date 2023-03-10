using Microsoft.EntityFrameworkCore;

namespace InventoryPreparedness.Models
{
  public class InventoryPreparednessContext : DbContext
  {
    public DbSet<Category> Categories { get; set; }
    public DbSet<Inventory> Inventories { get; set; }

    public InventoryPreparednessContext(DbContextOptions options) : base(options) { }
  }
}