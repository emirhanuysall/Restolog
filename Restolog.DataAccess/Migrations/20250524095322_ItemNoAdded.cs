using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restolog.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ItemNoAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItemNo",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "ItemNo",
                value: 0);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "ItemNo",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemNo",
                table: "OrderDetails");
        }
    }
}
