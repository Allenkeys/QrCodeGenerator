using Microsoft.EntityFrameworkCore;
using QrCodeGenerator.DAL.Entities;

namespace QrCodeGenerator.DAL.Database
{
    public class QrCodeDbContext : DbContext
    {
        public QrCodeDbContext(DbContextOptions<QrCodeDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<QrCode> QrCodes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QrCode>(e =>
            {
                e.Property(q => q.Title)
                .IsRequired()
                .HasMaxLength(50);

                e.Property(q => q.Code)
                .IsRequired();
            });

            modelBuilder.Entity<User>(e =>
            {
                e.Property(u => u.FirstName)
                .HasMaxLength(25)
                .IsRequired();

                e.Property(u => u.LastName)
                .HasMaxLength(25)
                .IsRequired();

                e.Property(u => u.Password)
                .IsRequired();

                e.HasIndex(u => u.Email, $"IX_Unique_{nameof(User.Email)}")
                .IsUnique();

                e.Property(u => u.Email)
                .HasMaxLength(50)
                .IsRequired();
            });
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
