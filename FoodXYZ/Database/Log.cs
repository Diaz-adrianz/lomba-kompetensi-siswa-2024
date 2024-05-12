namespace FoodXYZ.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Log")]
    public partial class Log
    {
        [Key]
        public int IdLog { get; set; }

        public DateTime? Waktu { get; set; }

        [StringLength(50)]
        public string aktivitas { get; set; }

        public int? IdUser { get; set; }

        public virtual User User { get; set; }
    }
}
