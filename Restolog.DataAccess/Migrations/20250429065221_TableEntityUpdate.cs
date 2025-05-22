using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restolog.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class TableEntityUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastOrderTime",
                table: "Tables",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "OrderDuration",
                table: "Tables",
                type: "time",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Tables",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TableNumber",
                table: "Tables",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "LastOrderTime", "OrderDuration", "Status", "TableNumber" },
                values: new object[] { null, null, "Boş", 0 });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "LastOrderTime", "OrderDuration", "Status", "TableNumber" },
                values: new object[] { null, null, "Boş", 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastOrderTime",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "OrderDuration",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "TableNumber",
                table: "Tables");
        }
    }
}
