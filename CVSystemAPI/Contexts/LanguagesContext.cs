using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Real_Base_Test_Own_Context.Helpers;
using API_Real_Base_Test_Own_Context.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Real_Base_Test_Own_Context.Contexts
{
    public partial class LanguagesContext : DbContext
    {
        public LanguagesContext(DbContextOptions<LanguagesContext> options) : base(options) { }
        public virtual DbSet<Languages> Languages { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionStringHelper.ExternalString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Languages>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PK__Language__B7596F13007110DE");
                entity.Property(e => e.ID).HasColumnName("Language_ID");
                entity.Property(e => e.LanguageName).HasColumnName("Language_Name").HasMaxLength(50);
            });
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
