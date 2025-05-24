using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restolog.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 3, "Tatlılar" },
                    { 4, "Çorbalar" },
                    { 5, "Salatalar" },
                    { 6, "Sandviçler" },
                    { 7, "Makarnalar" },
                    { 8, "Kahvaltılıklar" },
                    { 9, "Pizza" },
                    { 10, "Sıcak İçecekler" }
                });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ItemNo", "OrderId" },
                values: new object[] { 1, new Guid("88888888-8888-8888-8888-888888888888") });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ItemNo", "OrderId", "ProductId", "Subtotal", "UnitPrice" },
                values: new object[] { 2, new Guid("88888888-8888-8888-8888-888888888888"), 4, 30m, 30m });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "StatusName",
                value: "Yeni");

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "StatusName",
                value: "Hazırlanıyor");

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "StatusName",
                value: "Serviste");

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "Id", "StatusName" },
                values: new object[,]
                {
                    { 1001, "Ödendi" },
                    { 1002, "İptal" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Description", "Name", "Price" },
                values: new object[] { 1, "Serinletici içecek", "Ayran", 15m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 3, 2, "Etli burger", "Hamburger", 70m },
                    { 4, 2, "Kızarmış patates", "Patates Kızartması", 30m }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "ClosedAt", "CreatedAt", "IsFull", "IsReserved", "LastOrderTime", "Name", "OrderDuration", "Status", "TableNumber" },
                values: new object[,]
                {
                    { new Guid("44444444-4444-4444-4444-444444444444"), null, new DateTime(2025, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), false, false, null, "Masa 1", null, "Boş", 1 },
                    { new Guid("55555555-5555-5555-5555-555555555555"), null, new DateTime(2025, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), true, false, null, "Masa 2", null, "Dolu", 2 },
                    { new Guid("66666666-6666-6666-6666-666666666666"), null, new DateTime(2025, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), false, true, null, "Masa 3", null, "Rezerve", 3 },
                    { new Guid("77777777-7777-7777-7777-777777777777"), null, new DateTime(2025, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), false, false, null, "Masa 4", null, "Boş", 4 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "IsActive", "Name", "Password", "UserRoleId" },
                values: new object[,]
                {
                    { new Guid("22222222-2222-2222-2222-222222222222"), true, "garson", "1234", 2 },
                    { new Guid("33333333-3333-3333-3333-333333333333"), true, "kasiyer", "1234", 3 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "ClosedAt", "CreatedAt", "IsPaid", "OrderStatusId", "TableId", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("88888888-8888-8888-8888-888888888888"), null, new DateTime(2025, 5, 24, 10, 0, 0, 0, DateTimeKind.Unspecified), false, 2, new Guid("55555555-5555-5555-5555-555555555555"), 100m, new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("99999999-9999-9999-9999-999999999999"), null, new DateTime(2025, 5, 22, 13, 0, 0, 0, DateTimeKind.Unspecified), true, 1001, new Guid("66666666-6666-6666-6666-666666666666"), 40m, new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), null, new DateTime(2025, 5, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), false, 3, new Guid("44444444-4444-4444-4444-444444444444"), 120m, new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), null, new DateTime(2025, 2, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), true, 1001, new Guid("77777777-7777-7777-7777-777777777777"), 180m, new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), null, new DateTime(2024, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), true, 1001, new Guid("44444444-4444-4444-4444-444444444444"), 210m, new Guid("22222222-2222-2222-2222-222222222222") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 5, 3, "Tatlı", "Baklava", 40m },
                    { 6, 3, "Fırın sütlaç", "Sütlaç", 35m },
                    { 7, 4, "Sıcak çorba", "Mercimek Çorbası", 28m },
                    { 8, 4, "Baharatlı çorba", "Ezogelin Çorbası", 30m },
                    { 9, 5, "Taze salata", "Çoban Salata", 32m },
                    { 10, 5, "Mevsim yeşillikleri", "Mevsim Salata", 34m },
                    { 11, 6, "Izgara tavuklu sandviç", "Tavuklu Sandviç", 45m },
                    { 12, 6, "Ton balıklı sandviç", "Ton Balıklı Sandviç", 48m },
                    { 13, 7, "Kıymalı makarna", "Spagetti Bolonez", 55m },
                    { 14, 7, "Kremalı makarna", "Fettucine Alfredo", 60m },
                    { 15, 8, "Zengin kahvaltı tabağı", "Serpme Kahvaltı", 120m },
                    { 16, 8, "Yumurtalı menemen", "Menemen", 38m },
                    { 17, 9, "Klasik pizza", "Margherita Pizza", 80m },
                    { 18, 9, "Sucuklu pizza", "Sucuklu Pizza", 90m },
                    { 19, 10, "Sıcak çay", "Çay", 10m },
                    { 20, 10, "Filtre kahve", "Kahve", 22m }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Id", "ItemNo", "OrderId", "ProductId", "ProductName", "Quantity", "Subtotal", "UnitPrice" },
                values: new object[,]
                {
                    { 3, 3, new Guid("88888888-8888-8888-8888-888888888888"), 2, null, 1m, 15m, 15m },
                    { 4, 1, new Guid("99999999-9999-9999-9999-999999999999"), 5, null, 1m, 40m, 40m },
                    { 5, 1, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), 13, null, 2m, 110m, 55m },
                    { 6, 2, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), 9, null, 1m, 32m, 32m },
                    { 7, 1, new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), 15, null, 1m, 120m, 120m },
                    { 8, 2, new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), 6, null, 2m, 70m, 35m },
                    { 9, 1, new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), 17, null, 2m, 160m, 80m },
                    { 10, 2, new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), 19, null, 5m, 50m, 10m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"));

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ItemNo", "OrderId" },
                values: new object[] { 0, new Guid("44444444-4444-4444-4444-444444444444") });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ItemNo", "OrderId", "ProductId", "Subtotal", "UnitPrice" },
                values: new object[] { 0, new Guid("44444444-4444-4444-4444-444444444444"), 2, 70m, 70m });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "StatusName",
                value: "Hazırlanıyor");

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "StatusName",
                value: "Hazır");

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "StatusName",
                value: "Teslim Edildi");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Description", "Name", "Price" },
                values: new object[] { 2, "Etli burger", "Hamburger", 70m });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "ClosedAt", "CreatedAt", "IsFull", "IsReserved", "LastOrderTime", "Name", "OrderDuration", "Status", "TableNumber" },
                values: new object[,]
                {
                    { new Guid("22222222-2222-2222-2222-222222222222"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, null, "Masa 1", null, "Boş", 0 },
                    { new Guid("33333333-3333-3333-3333-333333333333"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, null, "Masa 2", null, "Boş", 0 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "ClosedAt", "CreatedAt", "IsPaid", "OrderStatusId", "TableId", "TotalPrice", "UserId" },
                values: new object[] { new Guid("44444444-4444-4444-4444-444444444444"), null, new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), false, 1, new Guid("22222222-2222-2222-2222-222222222222"), 140m, new Guid("11111111-1111-1111-1111-111111111111") });
        }
    }
}
