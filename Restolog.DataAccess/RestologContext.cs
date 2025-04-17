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
            // Role verileri
            modelBuilder.Entity<UserRole>().HasData(
                new UserRole { Id = 1, Name = "Yönetici" },
                new UserRole { Id = 2, Name = "Garson" },
                new UserRole { Id = 3, Name = "Kasiyer" }
            );

            // Kullanıcı verisi
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                    Name = "admin",
                    Password = "1234",
                    UserRoleId = 1,
                    IsActive = true
                }
            );

            // Kategori verileri
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "İçecekler" },
                new Category { Id = 2, Name = "Yemekler" }
            );

            // Ürün verileri
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Kola",
                    Description = "Soğuk gazlı içecek",
                    Price = 25,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Name = "Hamburger",
                    Description = "Etli burger",
                    Price = 70,
                    CategoryId = 2
                }
            );

            // Masa verileri
            modelBuilder.Entity<TableEntity>().HasData(
                new TableEntity
                {
                    Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                    Name = "Masa 1",
                    IsFull = false
                },
                new TableEntity
                {
                    Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                    Name = "Masa 2",
                    IsFull = false
                }
            );

            // Sipariş Durumu verileri
            modelBuilder.Entity<OrderStatus>().HasData(
                new OrderStatus { Id = 1, StatusName = "Hazırlanıyor" },
                new OrderStatus { Id = 2, StatusName = "Hazır" },
                new OrderStatus { Id = 3, StatusName = "Teslim Edildi" }
            );

            // Örnek Sipariş
            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    Id = Guid.Parse("44444444-4444-4444-4444-444444444444"),
                    TableId = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                    UserId = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                    CreatedAt = new DateTime(2025,01,01,12,0,0,0),
                    TotalPrice = 140,
                    IsPaid = false,
                    OrderStatusId = 1
                }
            );

            // Örnek Sipariş Detayı
            modelBuilder.Entity<OrderDetail>().HasData(
                new OrderDetail
                {
                    Id = 1,
                    OrderId = Guid.Parse("44444444-4444-4444-4444-444444444444"),
                    ProductId = 1,
                    Quantity = 2,
                    UnitPrice = 25,
                    Subtotal = 50
                },
                new OrderDetail
                {
                    Id = 2,
                    OrderId = Guid.Parse("44444444-4444-4444-4444-444444444444"),
                    ProductId = 2,
                    Quantity = 1,
                    UnitPrice = 70,
                    Subtotal = 70
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
