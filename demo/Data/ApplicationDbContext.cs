using demo.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace demo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedUserRole(builder);
            SeedProduct(builder);
        }

        private void SeedUserRole(ModelBuilder builder)
        {
            //A) Setup IdentityUser
            //1. Create accounts
            var adminAccount = new IdentityUser
            {
                Id = "user1",
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                EmailConfirmed = true
            };

            var userAccount = new IdentityUser
            {
                Id = "user2",
                UserName = "user@gmail.com",
                Email = "user@gmail.com",
                NormalizedUserName = "USER@GMAIL.COM",
                NormalizedEmail = "USER@GMAIL.COM",
                EmailConfirmed = true
            };

            //2. Declare hasher for password encryption
            var hasher = new PasswordHasher<IdentityUser>();

            //3. Setup password for accounts
            adminAccount.PasswordHash = hasher.HashPassword(adminAccount, "123456");
            userAccount.PasswordHash = hasher.HashPassword(userAccount, "123456");

            //4. Add accounts to database
            builder.Entity<IdentityUser>().HasData(adminAccount, userAccount);

            //B) Setup IdentityRole
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "role1",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                },
                 new IdentityRole
                 {
                     Id = "role2",
                     Name = "User",
                     NormalizedName = "USER"
                 });

            //C) Setup IdentityUserRole
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = "user1",
                    RoleId = "role1"
                },
                new IdentityUserRole<string>
                {
                    UserId = "user2",
                    RoleId = "role2"
                }
             );
        }

        private void SeedProduct(ModelBuilder builder)
        {
            builder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Macbook Pro M2",
                    Price = 2345,
                    Image = "/images/macbook.png"
                },
                new Product
                {
                    Id = 2,
                    Name = "XPS 15",
                    Price = 1999,
                    Image = "/images/xps.png"
                },
                new Product
                {
                    Id = 3,
                    Name = "Gram 17",
                    Price = 2024,
                    Image = "/images/gram.jpg"
                }
             );
        }
    }
}
