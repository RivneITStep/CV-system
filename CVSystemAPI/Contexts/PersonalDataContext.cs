using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Real_Base_Test_Own_Context.Helpers;
using API_Real_Base_Test_Own_Context.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Real_Base_Test_Own_Context.Contexts
{
    public partial class PersonalDataContext : DbContext
    {
        public PersonalDataContext(DbContextOptions<PersonalDataContext> options) : base(options) { }
        public virtual DbSet<PersonalData> Personal_Data { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionStringHelper.ExternalString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonalData>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PK__Personal__732F9CEA2A0956E0");
                entity.Property(e => e.ID).HasColumnName("Personal_ID");
                entity.Property(e => e.FirstName).HasColumnName("First_Name").HasMaxLength(100);
                entity.Property(e => e.LastName).HasColumnName("Last_Name").HasMaxLength(100);
                entity.Property(e => e.BirthDate).HasColumnName("Birth_Date").HasColumnType("date");
            });
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
