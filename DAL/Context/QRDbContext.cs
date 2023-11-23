using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class QRDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<OrderDetails> orderDetails { get; set; }
        public DbSet<OrderHeader> orderHeader { get; set; }
        public DbSet<Products> products { get; set; }
        public DbSet<Profile> profiles { get; set; }
        public DbSet<Role> role { get; set; }
        public DbSet<Table> tables { get; set; }
        public DbSet<Voucher> voucher { get; set; }
        public DbSet<VoucherType> voucherType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=YUN;initial catalog=testQR3;trusted_connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //bảng account x role
            modelBuilder.Entity<Account>()
                .HasOne(a => a.RoleEnity)
                .WithMany(r => r.Accounts)
                .HasForeignKey(p => p.RoleID);
            // bảng account x profile
            modelBuilder.Entity<Account>()
                .HasOne(a => a.Profile)
                .WithOne(r => r.Account)
                .HasForeignKey<Account>(p => p.ProfileID);
            //bảng orderHeader x Table
            modelBuilder.Entity<OrderHeader>()
                .HasOne(a => a.TableEnity)
                .WithMany(r => r.OrderHeaders)
                .HasForeignKey(p => p.TableID);
            //bảng voucher x orderHeader
            modelBuilder.Entity<Voucher>()
                .HasOne(a => a.OrderHeaderEnity)
                .WithMany(r => r.Vouchers)
                .HasForeignKey(p => p.OrderHeaderID);
            //bảng voucher x VoucherType
            modelBuilder.Entity<Voucher>()
                .HasOne(a => a.VoucherTypeEnity)
                .WithMany(r => r.Vouchers)
                .HasForeignKey(p => p.VoucherTypeID);
            // Add configurations for other entities if needed
            base.OnModelCreating(modelBuilder);
        }
    }
}
