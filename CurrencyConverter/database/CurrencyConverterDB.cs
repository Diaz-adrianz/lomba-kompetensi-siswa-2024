using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CurrencyConverter.database
{
    public partial class CurrencyConverterDB : DbContext
    {
        public CurrencyConverterDB()
            : base("name=CurrencyConverterDB")
        {
        }

        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<Period> Periods { get; set; }
        public virtual DbSet<USDExchangeRate> USDExchangeRates { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Currency>()
                .Property(e => e.country)
                .IsUnicode(false);

            modelBuilder.Entity<Currency>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Currency>()
                .Property(e => e.abbreviation)
                .IsUnicode(false);

            modelBuilder.Entity<Currency>()
                .HasMany(e => e.USDExchangeRates)
                .WithRequired(e => e.Currency)
                .HasForeignKey(e => e.currency_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Period>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Period>()
                .HasMany(e => e.USDExchangeRates)
                .WithRequired(e => e.Period)
                .HasForeignKey(e => e.period_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USDExchangeRate>()
                .Property(e => e.rate)
                .HasPrecision(13, 4);
        }
    }
}
