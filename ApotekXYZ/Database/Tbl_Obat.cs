namespace apotek_xyz_wf.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Obat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Obat()
        {
            Tbl_Transaksi = new HashSet<Tbl_Transaksi>();
        }

        [Key]
        public int Id_Obat { get; set; }

        [StringLength(50)]
        public string Kode_Obat { get; set; }

        [StringLength(50)]
        public string Nama_Obat { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Expired_Date { get; set; }

        public long? Jumlah { get; set; }

        public long? Harga { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Transaksi> Tbl_Transaksi { get; set; }
    }
}
