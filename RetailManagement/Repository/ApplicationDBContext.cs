using Microsoft.EntityFrameworkCore;
using RetailManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using RetailManagement.Authentication;

namespace RetailManagement.Repository
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<RegisterModel>()
                        .ToTable("RegisterModel");
            modelBuilder.Entity<RegisterModel>()
                .Property(user => user.UserProfileId)
                .IsRequired(true);
            modelBuilder.Entity<RegisterModel>()
                .Property(user => user.UserName)
                .IsRequired(true);
            modelBuilder.Entity<RegisterModel>()
                .Property(user => user.Email)
                .IsRequired(true);
            modelBuilder.Entity<RegisterModel>()
                .Property(user => user.Password)
                .IsRequired(true);
            modelBuilder.Entity<RegisterModel>()
                .HasData(
                    new RegisterModel
                    { 
                        UserProfileId = Guid.NewGuid(),
                        UserName = "Harish",
                        Email = "harish@g.com",
                        Password = "P@ssw0rd123"
                    },
                    new RegisterModel
                    {
                        UserProfileId = Guid.NewGuid(),
                        UserName = "Rajesh",
                        Email = "rajesh@g.com",
                        Password = "P@ssw0rd123"
                    }
                );
        }

        public DbSet<Product> Products { get; set; }
        //public DbSet<UserProfile> UserList { get; set; }
        public DbSet<RegisterModel> RegisterUserList { get; set; }
    }
}
