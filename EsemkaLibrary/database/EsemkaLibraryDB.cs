using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EsemkaLibrary.database
{
    public partial class EsemkaLibraryDB : DbContext
    {
        public EsemkaLibraryDB()
            : base("name=EsemkaLibraryDB")
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookGenre> BookGenres { get; set; }
        public virtual DbSet<Borrowing> Borrowings { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.author)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.BookGenres)
                .WithRequired(e => e.Book)
                .HasForeignKey(e => e.book_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.Borrowings)
                .WithRequired(e => e.Book)
                .HasForeignKey(e => e.book_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Borrowing>()
                .Property(e => e.fine)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Genre>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Genre>()
                .HasMany(e => e.BookGenres)
                .WithRequired(e => e.Genre)
                .HasForeignKey(e => e.genre_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .HasMany(e => e.Borrowings)
                .WithRequired(e => e.Member)
                .HasForeignKey(e => e.member_id)
                .WillCascadeOnDelete(false);
        }
    }
}
