using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
