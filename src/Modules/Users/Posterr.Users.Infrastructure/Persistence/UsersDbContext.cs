using Microsoft.EntityFrameworkCore;
using Posterr.Users.Core.Entities;

public class UsersDbContext : DbContext
{
    public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options)
    {
    }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>()
            .Property(u => u.Username)
            .IsRequired()
            .HasMaxLength(14);

        // Seed data
        modelBuilder.Entity<User>().HasData(
            new User { Username = "user1" },
            new User { Username = "user2" },
            new User { Username = "user3" },
            new User { Username = "user4" }
        );
    }
}