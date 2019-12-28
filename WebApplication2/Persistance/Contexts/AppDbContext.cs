using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Persistance.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            //Database.EnsureDeleted();   // удаляем бд со старой схемой
            Database.EnsureCreated();   // создаем бд с новой схемой
            //Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Book>().HasData
            (
                new Book { Id = 1, Author = "Unknown", BookName = "Fruits and Vegetables" } // Id set manually due to in-memory provider            
            );
            builder.Entity<User>().HasData
            (
                new User { Id = 1, Password = "1111", Email = "yromanc@gmail.com", UserRole = ERole.Administrator }
            );
        }
    }
}
