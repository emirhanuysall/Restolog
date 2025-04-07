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
            modelBuilder.Entity<PaymentDetail>()
                .HasOne(pd => pd.Payment)
                .WithMany() 
                .HasForeignKey(pd => pd.PaymentId)
                .OnDelete(DeleteBehavior.Restrict);
        }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\sqlserver,1433;Database=RestologDB;User Id=sa;Password=Password1;Encrypt=False");
        }
    }
}
