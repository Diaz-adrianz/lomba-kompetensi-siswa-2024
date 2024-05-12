using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FoodXYZ.Database
{
    public partial class FoodXYZDB : DbContext
    {
        public FoodXYZDB()
            : base("name=FoodXYZDB")
        {
        }

        public virtual DbSet<Barang> Barangs { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Transaksi> Transaksis { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Barang>()
                .Property(e => e.KodeBarang)
                .IsUnicode(false);

            modelBuilder.Entity<Barang>()
                .Property(e => e.NamaBarang)
                .IsUnicode(false);

            modelBuilder.Entity<Barang>()
                .Property(e => e.Satuan)
                .IsUnicode(false);

            modelBuilder.Entity<Log>()
                .Property(e => e.aktivitas)
                .IsUnicode(false);

            modelBuilder.Entity<Transaksi>()
                .Property(e => e.NoTransaksi)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.TipeUser)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Nama)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Alamat)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Telpon)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
