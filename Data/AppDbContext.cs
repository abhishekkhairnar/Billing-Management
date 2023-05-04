using Billing_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Billing_Management_System.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>().HasKey(am => new
            {
                am.Email
            });
            modelBuilder.Entity<VendorModel>().HasKey(am => new
            {
                am.Email
            });
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<UserModel > Users { get; set; }
        public DbSet<VendorModel> Vendors { get; set; }
    }
}
