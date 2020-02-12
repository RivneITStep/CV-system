using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Real_Base_Test_Own_Context.Helpers;
using API_Real_Base_Test_Own_Context.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Real_Base_Test_Own_Context.Contexts
{
    public partial class SkillsContext : DbContext
    {
        public SkillsContext(DbContextOptions<SkillsContext> options) : base(options) { }
        public virtual DbSet<Skills> Skills { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionStringHelper.ExternalString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Skills>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PK__Skills__7569047CD5682E8E");
                entity.Property(e => e.ID).HasColumnName("Skills_ID");
                entity.Property(e => e.SkillName).HasColumnName("Skill_Name").HasMaxLength(200);
            });
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
