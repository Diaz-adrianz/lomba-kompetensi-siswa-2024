using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EsemkaVote.database
{
    public partial class EsemkaVoteDB : DbContext
    {
        public EsemkaVoteDB()
            : base("name=EsemkaVoteDB")
        {
        }

        public virtual DbSet<Division> Divisions { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<VotingCandidate> VotingCandidates { get; set; }
        public virtual DbSet<VotingDetail> VotingDetails { get; set; }
        public virtual DbSet<VotingHeader> VotingHeaders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Division>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Division>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.Division)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Photo)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.VotingCandidates)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.VotingDetails)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VotingCandidate>()
                .HasMany(e => e.VotingDetails)
                .WithRequired(e => e.VotingCandidate)
                .HasForeignKey(e => e.VotedCandidateId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VotingDetail>()
                .Property(e => e.Reason)
                .IsUnicode(false);

            modelBuilder.Entity<VotingHeader>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<VotingHeader>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<VotingHeader>()
                .HasMany(e => e.VotingCandidates)
                .WithRequired(e => e.VotingHeader)
                .WillCascadeOnDelete(false);
        }
    }
}
