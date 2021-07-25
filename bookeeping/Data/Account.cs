using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using bookeeping.Models;

namespace bookeeping.Data
{
    public class AccountContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
    {
        public AccountContext(DbContextOptions options) :base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Journal>()
                .Property(x => x.Date)
                .HasDefaultValueSql("date('now')");
            
            modelBuilder.Entity<Journal>()
                .HasOne<ApplicationUser>(j => j.Users)
                .WithMany(u => u.Journals)
                .HasForeignKey(j => j.UserID);

            modelBuilder.Entity<Budget>()
                .HasOne<ApplicationUser>(b => b.Users)
                .WithMany(u => u.Budgets)
                .HasForeignKey(b => b.UserID);

            modelBuilder.Entity<Budget>()
                .Property(b => b.Period)
                .HasColumnType("date");
        }

        public DbSet<Budget> Budgets{ get; set; }
        public DbSet<Journal> Journals{ get; set; }
    }
}