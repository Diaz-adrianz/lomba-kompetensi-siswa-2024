namespace EsemkaLibrary.database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BookGenre")]
    public partial class BookGenre
    {
        public int id { get; set; }

        public int book_id { get; set; }

        public int genre_id { get; set; }

        public DateTime created_at { get; set; }

        public DateTime? deleted_at { get; set; }

        public virtual Book Book { get; set; }

        public virtual Genre Genre { get; set; }
    }
}
