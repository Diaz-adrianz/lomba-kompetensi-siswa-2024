namespace apotek_xyz_wf.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Transaksi
    {
        [Key]
        public int Id_Transaksi { get; set; }

        [StringLength(50)]
        public string No_Transaksi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Tgl_Transaksi { get; set; }

        public long? Total_Bayar { get; set; }

        public int? Id_User { get; set; }

        public int? Id_Obat { get; set; }

        public int? Id_Resep { get; set; }

        public virtual Tbl_Obat Tbl_Obat { get; set; }

        public virtual Tbl_Resep Tbl_Resep { get; set; }

        public virtual Tbl_User Tbl_User { get; set; }
    }
}
