using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Posterr.Shared.Infra.Migrations
{
    /// <inheritdoc />
    public partial class RemoveContentAsRequired : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Posts",
                type: "nvarchar(777)",
                maxLength: 777,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(777)",
                oldMaxLength: 777);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("29d5f8eb-f438-4c83-b98a-b49900cfb625"),
                columns: new[] { "Content", "CreatedAt" },
                values: new object[] { null, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("d935e070-dc0e-491b-ad52-a1415385bac5"),
                column: "CreatedAt",
                value: new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Posts",
                type: "nvarchar(777)",
                maxLength: 777,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(777)",
                oldMaxLength: 777,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("29d5f8eb-f438-4c83-b98a-b49900cfb625"),
                columns: new[] { "Content", "CreatedAt" },
                values: new object[] { "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.", new DateTime(2024, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("d935e070-dc0e-491b-ad52-a1415385bac5"),
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
