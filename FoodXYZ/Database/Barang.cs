namespace FoodXYZ.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Barang")]
    public partial class Barang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Barang()
        {
            Transaksis = new HashSet<Transaksi>();
        }

        [Key]
        public int IdBarang { get; set; }

        [StringLength(50)]
        public string KodeBarang { get; set; }

        [StringLength(50)]
        public string NamaBarang { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExpiredDate { get; set; }

        public long? JumlahBarang { get; set; }

        [StringLength(50)]
        public string Satuan { get; set; }

        public long? HargaSatuan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaksi> Transaksis { get; set; }
    }
}
