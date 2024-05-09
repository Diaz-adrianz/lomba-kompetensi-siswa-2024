namespace CurrencyConverter.database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USDExchangeRate")]
    public partial class USDExchangeRate
    {
        public int id { get; set; }

        public int period_id { get; set; }

        public int currency_id { get; set; }

        public decimal rate { get; set; }

        public virtual Currency Currency { get; set; }

        public virtual Period Period { get; set; }
    }
}
