namespace apotek_xyz_wf.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Resep
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Resep()
        {
            Tbl_Transaksi = new HashSet<Tbl_Transaksi>();
        }

        [Key]
        public int Id_Resep { get; set; }

        [StringLength(50)]
        public string No_Resep { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Tgl_Resep { get; set; }

        [StringLength(50)]
        public string Nama_Dokter { get; set; }

        [StringLength(50)]
        public string Nama_Pasien { get; set; }

        [StringLength(50)]
        public string Nama_ObatDibeli { get; set; }

        public long? Jumlah_ObatDibeli { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Transaksi> Tbl_Transaksi { get; set; }
    }
}
