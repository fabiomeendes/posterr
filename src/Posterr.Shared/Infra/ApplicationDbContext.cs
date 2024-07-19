using Microsoft.EntityFrameworkCore;
using Posterr.Shared.Core.Entities;
using Posterr.Shared.Core.Enums;
using Posterr.Shared.Infra.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Posterr.Shared.Infra
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfiguration());

            modelBuilder.Entity<User>().HasData(
                new
                {
                    Id = new Guid("032dd698-7a14-4a84-adf5-ba3b21a28a2a"),
                    CreatedAt = new DateTime(2023, 10, 13),
                    Username = "user1"
                },
                new
                {
                    Id = new Guid("d5805053-ee9c-47db-8900-18aae2d08f35"),
                    CreatedAt = new DateTime(2024, 3, 04),
                    Username = "user2"
                },
                new
                {
                    Id = new Guid("5080b484-cd22-4a90-8894-1d5639c930fa"),
                    CreatedAt = new DateTime(2024, 7, 18),
                    Username = "user3"
                },
                new
                {
                    Id = new Guid("aef145ca-aa9b-4d6f-b8ab-56709b51bb21"),
                    CreatedAt = new DateTime(2024, 7, 01),
                    Username = "user4"
                });

            modelBuilder.Entity<Post>().HasData(
                new
                {
                    Id = new Guid("d935e070-dc0e-491b-ad52-a1415385bac5"),
                    Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    PostType = PostType.OriginalPost,
                    UserId = new Guid("d5805053-ee9c-47db-8900-18aae2d08f35"),
                    CreatedAt = new DateTime(2024, 7, 18),
                },
                new
                {
                    Id = new Guid("29d5f8eb-f438-4c83-b98a-b49900cfb625"),
                    Content = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.",
                    PostType = PostType.Repost,
                    UserId = new Guid("aef145ca-aa9b-4d6f-b8ab-56709b51bb21"),
                    CreatedAt = new DateTime(2024, 7, 18),
                    PostReferenceId = new Guid("d935e070-dc0e-491b-ad52-a1415385bac5"),
                });
        }
    }
}
