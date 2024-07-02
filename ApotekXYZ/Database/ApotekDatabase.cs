using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace apotek_xyz_wf.Database
{
    public partial class ApotekDatabase : DbContext
    {
        public ApotekDatabase()
            : base("name=ApotekDatabase")
        {
        }

        public virtual DbSet<Tbl_Log> Tbl_Log { get; set; }
        public virtual DbSet<Tbl_Obat> Tbl_Obat { get; set; }
        public virtual DbSet<Tbl_Resep> Tbl_Resep { get; set; }
        public virtual DbSet<Tbl_Transaksi> Tbl_Transaksi { get; set; }
        public virtual DbSet<Tbl_User> Tbl_User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tbl_Log>()
                .Property(e => e.Aktivitas)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Obat>()
                .Property(e => e.Kode_Obat)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Obat>()
                .Property(e => e.Nama_Obat)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Resep>()
                .Property(e => e.No_Resep)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Resep>()
                .Property(e => e.Nama_Dokter)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Resep>()
                .Property(e => e.Nama_Pasien)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Resep>()
                .Property(e => e.Nama_ObatDibeli)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Transaksi>()
                .Property(e => e.No_Transaksi)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_User>()
                .Property(e => e.Tipe_User)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_User>()
                .Property(e => e.Nama_User)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_User>()
                .Property(e => e.Alamat)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_User>()
                .Property(e => e.Telpon)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_User>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_User>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
