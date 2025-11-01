using LMS.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DAL.Database
{
    public class ApplicationContext : DbContext
    {
        // Configure Connection String
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=.;Database=LMSDB;Trusted_Connection=True;TrustServerCertificate=True;");
            optionsBuilder.UseSqlServer("Server=LAPTOP-S5ELB0AS\\SQLEXPRESS;Database=LMSDB;integrated security=True;TrustServerCertificate=True;");
        }

        // Add All Entities DbSet Properties 

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<BorrowTransaction> BorrowTransactions { get; set; }
        public DbSet<ReservationTransaction> ReservationTransactions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserInRole> UsersInRole { get; set; }

    }
}
