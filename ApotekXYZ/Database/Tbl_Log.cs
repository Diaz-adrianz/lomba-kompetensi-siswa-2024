namespace apotek_xyz_wf.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Log
    {
        [Key]
        public int Id_Log { get; set; }

        public DateTime? Waktu { get; set; }

        [StringLength(50)]
        public string Aktivitas { get; set; }

        public int? Id_User { get; set; }

        public virtual Tbl_User Tbl_User { get; set; }
    }
}
