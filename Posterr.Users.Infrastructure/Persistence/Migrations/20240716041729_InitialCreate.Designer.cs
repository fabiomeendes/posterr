﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Posterr.Users.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(UsersDbContext))]
    [Migration("20240716041729_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Posterr.Users.Core.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9f938613-1e62-454f-a009-bcbfc9d92c6e"),
                            CreatedAt = new DateTime(2024, 7, 16, 1, 17, 29, 694, DateTimeKind.Local).AddTicks(3935),
                            Username = "user1"
                        },
                        new
                        {
                            Id = new Guid("c2d73830-b9d1-4711-8bcd-6a5bdee402ce"),
                            CreatedAt = new DateTime(2024, 7, 16, 1, 17, 29, 694, DateTimeKind.Local).AddTicks(3954),
                            Username = "user2"
                        },
                        new
                        {
                            Id = new Guid("f8ebdc37-1eb9-4976-a2ef-6836acf1b7ee"),
                            CreatedAt = new DateTime(2024, 7, 16, 1, 17, 29, 694, DateTimeKind.Local).AddTicks(3957),
                            Username = "user3"
                        },
                        new
                        {
                            Id = new Guid("87ccd11f-0095-44c8-9ef8-12fbf301079e"),
                            CreatedAt = new DateTime(2024, 7, 16, 1, 17, 29, 694, DateTimeKind.Local).AddTicks(3958),
                            Username = "user4"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
