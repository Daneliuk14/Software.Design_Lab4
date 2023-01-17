using Microsoft.EntityFrameworkCore;
using Software.Design.Models;

namespace Software.Design.DataModels;

public class KeyboardContext : DbContext
{
    public KeyboardContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Keyboard> KeyboardDB => Set<Keyboard>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Keyboard>()
            .HasKey(b => b.id);

        modelBuilder.Entity<Keyboard>().ToTable("products", schema: "keyboard");
    }
}