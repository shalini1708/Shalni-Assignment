using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CapstoneProject.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=shalinidbentities")
        {
        }

        public virtual DbSet<BlogInfo> BlogInfoes { get; set; }
        public virtual DbSet<EmpInfo> EmpInfoes { get; set; }
        public virtual DbSet<AdminInfo> AdminInfoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlogInfo>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<BlogInfo>()
                .Property(e => e.Subject)
                .IsUnicode(false);

            modelBuilder.Entity<BlogInfo>()
                .Property(e => e.BlogUrl)
                .IsUnicode(false);

            modelBuilder.Entity<BlogInfo>()
                .Property(e => e.EmpEmailId)
                .IsUnicode(false);

            modelBuilder.Entity<EmpInfo>()
                .Property(e => e.EmailId)
                .IsUnicode(false);

            modelBuilder.Entity<EmpInfo>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<AdminInfo>()
                .Property(e => e.EmailId)
                .IsUnicode(false);

            modelBuilder.Entity<AdminInfo>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
