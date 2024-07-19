using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Posterr.Shared.Infra.Migrations
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

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(777)", maxLength: 777, nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PostType = table.Column<int>(type: "int", nullable: false),
                    PostReferenceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Posts_PostReferenceId",
                        column: x => x.PostReferenceId,
                        principalTable: "Posts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Posts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Username" },
                values: new object[,]
                {
                    { new Guid("032dd698-7a14-4a84-adf5-ba3b21a28a2a"), new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { new Guid("5080b484-cd22-4a90-8894-1d5639c930fa"), new DateTime(2024, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { new Guid("aef145ca-aa9b-4d6f-b8ab-56709b51bb21"), new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { new Guid("d5805053-ee9c-47db-8900-18aae2d08f35"), new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "user2" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "CreatedAt", "PostReferenceId", "PostType", "UserId" },
                values: new object[,]
                {
                    { new Guid("d935e070-dc0e-491b-ad52-a1415385bac5"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", new DateTime(2024, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, new Guid("d5805053-ee9c-47db-8900-18aae2d08f35") },
                    { new Guid("29d5f8eb-f438-4c83-b98a-b49900cfb625"), "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.", new DateTime(2024, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d935e070-dc0e-491b-ad52-a1415385bac5"), 1, new Guid("aef145ca-aa9b-4d6f-b8ab-56709b51bb21") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PostReferenceId",
                table: "Posts",
                column: "PostReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
