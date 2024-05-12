namespace FoodXYZ.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Transaksi")]
    public partial class Transaksi
    {
        [Key]
        public int IdTransaksi { get; set; }

        [StringLength(50)]
        public string NoTransaksi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TglTransaksi { get; set; }

        public long? TotalBayar { get; set; }

        public int? IdUser { get; set; }

        public int? IdBarang { get; set; }

        public virtual Barang Barang { get; set; }

        public virtual User User { get; set; }
    }
}
