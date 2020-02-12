using API_Real_Base_Test_Own_Context.Helpers;
using API_Real_Base_Test_Own_Context.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Real_Base_Test_Own_Context.Contexts
{
    public partial class HobbiesContext : DbContext
    {
        public HobbiesContext(DbContextOptions<HobbiesContext> options) : base(options) { }
        public virtual DbSet<Hobbies> Hobbies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionStringHelper.ExternalString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hobbies>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PK__Hobbies__620FC5F87F09E906");
                entity.Property(e => e.ID).HasColumnName("Hobby_ID");
                entity.Property(e => e.HobbyName).IsRequired().HasColumnName("Hobby_Name").HasMaxLength(100);
            });
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
