using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Posterr.Users.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Username" },
                values: new object[,]
                {
                    { new Guid("87ccd11f-0095-44c8-9ef8-12fbf301079e"), new DateTime(2024, 7, 16, 1, 17, 29, 694, DateTimeKind.Local).AddTicks(3958), "user4" },
                    { new Guid("9f938613-1e62-454f-a009-bcbfc9d92c6e"), new DateTime(2024, 7, 16, 1, 17, 29, 694, DateTimeKind.Local).AddTicks(3935), "user1" },
                    { new Guid("c2d73830-b9d1-4711-8bcd-6a5bdee402ce"), new DateTime(2024, 7, 16, 1, 17, 29, 694, DateTimeKind.Local).AddTicks(3954), "user2" },
                    { new Guid("f8ebdc37-1eb9-4976-a2ef-6836acf1b7ee"), new DateTime(2024, 7, 16, 1, 17, 29, 694, DateTimeKind.Local).AddTicks(3957), "user3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
