using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Real_Base_Test_Own_Context.Helpers;
using API_Real_Base_Test_Own_Context.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Real_Base_Test_Own_Context.Contexts
{
    public partial class PersonalityContext : DbContext
    {
        public PersonalityContext(DbContextOptions<PersonalityContext> options) : base(options) { }
        public virtual DbSet<Personality> Personality { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionStringHelper.ExternalString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personality>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PK__Personal__C73441C8255BEB3D");
                entity.Property(e => e.ID).HasColumnName("Personality_ID");
                entity.Property(e => e.PersonalityName).HasColumnName("Personality_Name").HasMaxLength(100);
            });
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
