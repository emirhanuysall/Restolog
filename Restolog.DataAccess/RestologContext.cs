using Microsoft.EntityFrameworkCore;
using Restolog.Entities.Concrete;

namespace Restolog.DataAccess
{
    public class RestologContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<TableEntity> Tables { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentDetail> PaymentDetails { get; set; }

        public DbSet<Log> Logs { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<OrderStatus> OrderStatuses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(p => p.Price).HasPrecision(18, 2);
            modelBuilder.Entity<Product>().Property(p => p.Price).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(o => o.TotalPrice).HasPrecision(18, 2);
            modelBuilder.Entity<OrderDetail>().Property(od => od.UnitPrice).HasPrecision(18, 2);
            modelBuilder.Entity<OrderDetail>().Property(od => od.Subtotal).HasPrecision(18, 2);
            modelBuilder.Entity<OrderDetail>().Property(od => od.Quantity).HasPrecision(18, 2);
            modelBuilder.Entity<Payment>().Property(p => p.AmountPaid).HasPrecision(18, 2);
            modelBuilder.Entity<PaymentDetail>().Property(pd => pd.AmountPaid).HasPrecision(18, 2);

            // Roller
            modelBuilder.Entity<UserRole>().HasData(
                new UserRole { Id = 1, Name = "Yönetici" },
                new UserRole { Id = 2, Name = "Garson" },
                new UserRole { Id = 3, Name = "Kasiyer" }
            );

            // Kullanıcılar
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                    Name = "admin",
                    Password = "1234",
                    UserRoleId = 1,
                    IsActive = true
                },
                new User
                {
                    Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                    Name = "garson",
                    Password = "1234",
                    UserRoleId = 2,
                    IsActive = true
                },
                new User
                {
                    Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                    Name = "kasiyer",
                    Password = "1234",
                    UserRoleId = 3,
                    IsActive = true
                }
            );

            // Kategoriler
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "İçecekler" },
                new Category { Id = 2, Name = "Yemekler" },
                new Category { Id = 3, Name = "Tatlılar" },
                new Category { Id = 4, Name = "Çorbalar" },
                new Category { Id = 5, Name = "Salatalar" },
                new Category { Id = 6, Name = "Sandviçler" },
                new Category { Id = 7, Name = "Makarnalar" },
                new Category { Id = 8, Name = "Kahvaltılıklar" },
                new Category { Id = 9, Name = "Pizza" },
                new Category { Id = 10, Name = "Sıcak İçecekler" }
            );

            // Ürünler
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Kola", Description = "Soğuk gazlı içecek", Price = 25, CategoryId = 1 },
                new Product { Id = 2, Name = "Ayran", Description = "Serinletici içecek", Price = 15, CategoryId = 1 },
                new Product { Id = 3, Name = "Hamburger", Description = "Etli burger", Price = 70, CategoryId = 2 },
                new Product { Id = 4, Name = "Patates Kızartması", Description = "Kızarmış patates", Price = 30, CategoryId = 2 },
                new Product { Id = 5, Name = "Baklava", Description = "Tatlı", Price = 40, CategoryId = 3 },
                new Product { Id = 6, Name = "Sütlaç", Description = "Fırın sütlaç", Price = 35, CategoryId = 3 },
                new Product { Id = 7, Name = "Mercimek Çorbası", Description = "Sıcak çorba", Price = 28, CategoryId = 4 },
                new Product { Id = 8, Name = "Ezogelin Çorbası", Description = "Baharatlı çorba", Price = 30, CategoryId = 4 },
                new Product { Id = 9, Name = "Çoban Salata", Description = "Taze salata", Price = 32, CategoryId = 5 },
                new Product { Id = 10, Name = "Mevsim Salata", Description = "Mevsim yeşillikleri", Price = 34, CategoryId = 5 },
                new Product { Id = 11, Name = "Tavuklu Sandviç", Description = "Izgara tavuklu sandviç", Price = 45, CategoryId = 6 },
                new Product { Id = 12, Name = "Ton Balıklı Sandviç", Description = "Ton balıklı sandviç", Price = 48, CategoryId = 6 },
                new Product { Id = 13, Name = "Spagetti Bolonez", Description = "Kıymalı makarna", Price = 55, CategoryId = 7 },
                new Product { Id = 14, Name = "Fettucine Alfredo", Description = "Kremalı makarna", Price = 60, CategoryId = 7 },
                new Product { Id = 15, Name = "Serpme Kahvaltı", Description = "Zengin kahvaltı tabağı", Price = 120, CategoryId = 8 },
                new Product { Id = 16, Name = "Menemen", Description = "Yumurtalı menemen", Price = 38, CategoryId = 8 },
                new Product { Id = 17, Name = "Margherita Pizza", Description = "Klasik pizza", Price = 80, CategoryId = 9 },
                new Product { Id = 18, Name = "Sucuklu Pizza", Description = "Sucuklu pizza", Price = 90, CategoryId = 9 },
                new Product { Id = 19, Name = "Çay", Description = "Sıcak çay", Price = 10, CategoryId = 10 },
                new Product { Id = 20, Name = "Kahve", Description = "Filtre kahve", Price = 22, CategoryId = 10 }
            );

            // Masalar
            modelBuilder.Entity<TableEntity>().HasData(
                new TableEntity
                {
                    Id = Guid.Parse("44444444-4444-4444-4444-444444444444"),
                    Name = "Masa 1",
                    IsFull = false,
                    IsReserved = false,
                    Status = "Boş",
                    TableNumber = 1,
                    CreatedAt = new DateTime(2025, 1, 1, 8, 0, 0)
                },
                new TableEntity
                {
                    Id = Guid.Parse("55555555-5555-5555-5555-555555555555"),
                    Name = "Masa 2",
                    IsFull = true,
                    IsReserved = false,
                    Status = "Dolu",
                    TableNumber = 2,
                    CreatedAt = new DateTime(2025, 1, 1, 8, 0, 0)
                },
                new TableEntity
                {
                    Id = Guid.Parse("66666666-6666-6666-6666-666666666666"),
                    Name = "Masa 3",
                    IsFull = false,
                    IsReserved = true,
                    Status = "Rezerve",
                    TableNumber = 3,
                    CreatedAt = new DateTime(2025, 1, 1, 8, 0, 0)
                },
                new TableEntity
                {
                    Id = Guid.Parse("77777777-7777-7777-7777-777777777777"),
                    Name = "Masa 4",
                    IsFull = false,
                    IsReserved = false,
                    Status = "Boş",
                    TableNumber = 4,
                    CreatedAt = new DateTime(2025, 1, 1, 8, 0, 0)
                }
            );

            // Sipariş Durumları
            modelBuilder.Entity<OrderStatus>().HasData(
                new OrderStatus { Id = 1, StatusName = "Yeni" },
                new OrderStatus { Id = 2, StatusName = "Hazırlanıyor" },
                new OrderStatus { Id = 3, StatusName = "Serviste" },
                new OrderStatus { Id = 1001, StatusName = "Ödendi" },
                new OrderStatus { Id = 1002, StatusName = "İptal" }
            );

            // Siparişler (farklı zamanlarda, farklı masalarda, farklı statülerde)
            modelBuilder.Entity<Order>().HasData(
                // Bugün (2025-05-24)
                new Order
                {
                    Id = Guid.Parse("88888888-8888-8888-8888-888888888888"),
                    TableId = Guid.Parse("55555555-5555-5555-5555-555555555555"),
                    UserId = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                    CreatedAt = new DateTime(2025, 5, 24, 10, 0, 0),
                    TotalPrice = 100,
                    IsPaid = false,
                    OrderStatusId = 2
                },
                // Bu hafta (2025-05-22)
                new Order
                {
                    Id = Guid.Parse("99999999-9999-9999-9999-999999999999"),
                    TableId = Guid.Parse("66666666-6666-6666-6666-666666666666"),
                    UserId = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                    CreatedAt = new DateTime(2025, 5, 22, 13, 0, 0),
                    TotalPrice = 40,
                    IsPaid = true,
                    OrderStatusId = 1001
                },
                // Bu ay (2025-05-09)
                new Order
                {
                    Id = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                    TableId = Guid.Parse("44444444-4444-4444-4444-444444444444"),
                    UserId = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                    CreatedAt = new DateTime(2025, 5, 9, 14, 0, 0),
                    TotalPrice = 120,
                    IsPaid = false,
                    OrderStatusId = 3
                },
                // Bu yıl (2025-02-15)
                new Order
                {
                    Id = Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                    TableId = Guid.Parse("77777777-7777-7777-7777-777777777777"),
                    UserId = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                    CreatedAt = new DateTime(2025, 2, 15, 12, 0, 0),
                    TotalPrice = 180,
                    IsPaid = true,
                    OrderStatusId = 1001
                },
                // Geçen yıl (2024-11-10)
                new Order
                {
                    Id = Guid.Parse("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                    TableId = Guid.Parse("44444444-4444-4444-4444-444444444444"),
                    UserId = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                    CreatedAt = new DateTime(2024, 11, 10, 19, 0, 0),
                    TotalPrice = 210,
                    IsPaid = true,
                    OrderStatusId = 1001
                }
            );

            // Sipariş Detayları
            modelBuilder.Entity<OrderDetail>().HasData(
                // Bugün
                new OrderDetail
                {
                    Id = 1,
                    OrderId = Guid.Parse("88888888-8888-8888-8888-888888888888"),
                    ProductId = 1,
                    Quantity = 2,
                    UnitPrice = 25,
                    Subtotal = 50,
                    ItemNo = 1
                },
                new OrderDetail
                {
                    Id = 2,
                    OrderId = Guid.Parse("88888888-8888-8888-8888-888888888888"),
                    ProductId = 4,
                    Quantity = 1,
                    UnitPrice = 30,
                    Subtotal = 30,
                    ItemNo = 2
                },
                new OrderDetail
                {
                    Id = 3,
                    OrderId = Guid.Parse("88888888-8888-8888-8888-888888888888"),
                    ProductId = 2,
                    Quantity = 1,
                    UnitPrice = 15,
                    Subtotal = 15,
                    ItemNo = 3
                },
                // Bu hafta
                new OrderDetail
                {
                    Id = 4,
                    OrderId = Guid.Parse("99999999-9999-9999-9999-999999999999"),
                    ProductId = 5,
                    Quantity = 1,
                    UnitPrice = 40,
                    Subtotal = 40,
                    ItemNo = 1
                },
                // Bu ay
                new OrderDetail
                {
                    Id = 5,
                    OrderId = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                    ProductId = 13,
                    Quantity = 2,
                    UnitPrice = 55,
                    Subtotal = 110,
                    ItemNo = 1
                },
                new OrderDetail
                {
                    Id = 6,
                    OrderId = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                    ProductId = 9,
                    Quantity = 1,
                    UnitPrice = 32,
                    Subtotal = 32,
                    ItemNo = 2
                },
                // Bu yıl
                new OrderDetail
                {
                    Id = 7,
                    OrderId = Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                    ProductId = 15,
                    Quantity = 1,
                    UnitPrice = 120,
                    Subtotal = 120,
                    ItemNo = 1
                },
                new OrderDetail
                {
                    Id = 8,
                    OrderId = Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                    ProductId = 6,
                    Quantity = 2,
                    UnitPrice = 35,
                    Subtotal = 70,
                    ItemNo = 2
                },
                // Geçen yıl
                new OrderDetail
                {
                    Id = 9,
                    OrderId = Guid.Parse("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                    ProductId = 17,
                    Quantity = 2,
                    UnitPrice = 80,
                    Subtotal = 160,
                    ItemNo = 1
                },
                new OrderDetail
                {
                    Id = 10,
                    OrderId = Guid.Parse("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                    ProductId = 19,
                    Quantity = 5,
                    UnitPrice = 10,
                    Subtotal = 50,
                    ItemNo = 2
                }
            );

            // PaymentDetail FK ayarı
            modelBuilder.Entity<PaymentDetail>()
                .HasOne(pd => pd.Payment)
                .WithMany()
                .HasForeignKey(pd => pd.PaymentId)
                .OnDelete(DeleteBehavior.Restrict);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            //optionsBuilder.UseSqlServer("Server =.; Database =RestologDB; Trusted_Connection = True; Encrypt = False"); //sql local server 
            optionsBuilder.UseSqlServer("Server=localhost\\sqlserver,1433;Database=RestologDB;User Id=sa;Password=Password1;Encrypt=False"); //sql docker container
        }
    }
}