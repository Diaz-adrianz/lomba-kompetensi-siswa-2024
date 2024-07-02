namespace apotek_xyz_wf.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_User()
        {
            Tbl_Log = new HashSet<Tbl_Log>();
            Tbl_Transaksi = new HashSet<Tbl_Transaksi>();
        }

        [Key]
        public int Id_User { get; set; }

        [StringLength(50)]
        public string Tipe_User { get; set; }

        [StringLength(50)]
        public string Nama_User { get; set; }

        [StringLength(150)]
        public string Alamat { get; set; }

        [StringLength(50)]
        public string Telpon { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Log> Tbl_Log { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Transaksi> Tbl_Transaksi { get; set; }
    }
}
