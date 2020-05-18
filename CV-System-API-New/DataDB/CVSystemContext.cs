using CV_System_API_New.DataDB.Configuration;
using CV_System_API_New.Helpers;
using CV_System_API_New.Models;
using CV_System_API_New.Models.CommunicationInfo;
using CV_System_API_New.Models.EducationInfo;
using CV_System_API_New.Models.ExperienceInfo;
using CV_System_API_New.Models.HobbyInfo;
using CV_System_API_New.Models.ManyToManyBinders;
using CV_System_API_New.Models.SkillInfo;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CV_System_API_New.DataDB
{
    public class CVSystemContext : IdentityDbContext<LoginData, UserRole, int>
    {
        public CVSystemContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionStringHelper.ExternalString);
            }
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new UserRoleConfiguration());

            #region AddressPersonalData Configuration
            builder.Entity<AddressPersonalData>()
                .HasKey(x => new { x.AddressId, x.PersonalDataId });

            builder.Entity<AddressPersonalData>()
                .HasOne(apd => apd.Address)
                .WithMany(pd => pd.AddressPersonalData)
                .HasForeignKey(apd => apd.AddressId);

            builder.Entity<AddressPersonalData>()
                .HasOne(apd => apd.PersonalData)
                .WithMany(a => a.AddressPersonalData)
                .HasForeignKey(apd => apd.PersonalDataId);
            #endregion

            #region CityCountry Configuration
            builder.Entity<CityCountry>()
                .HasKey(x => new { x.CityId, x.CountryId });

            builder.Entity<CityCountry>()
                .HasOne(cc => cc.City)
                .WithMany(ct => ct.CityCountries)
                .HasForeignKey(cc => cc.CityId);

            builder.Entity<CityCountry>()
                .HasOne(cc => cc.Country)
                .WithMany(cn => cn.CityCountries)
                .HasForeignKey(cc => cc.CountryId);
            #endregion

            #region CityZipCode Configuration
            builder.Entity<CityZipCode>()
                .HasKey(x => new { x.CityId, x.ZipCodeId });

            builder.Entity<CityZipCode>()
                .HasOne(czc => czc.City)
                .WithMany(ct => ct.CityZipCodes)
                .HasForeignKey(czc => czc.CityId);

            builder.Entity<CityZipCode>()
                .HasOne(czc => czc.ZipCode)
                .WithMany(zc => zc.CityZipCodes)
                .HasForeignKey(czc => czc.ZipCodeId);
            #endregion

            #region CVData Configuration
            builder.Entity<CVData>()
                .HasOne(cvd => cvd.Communication)
                .WithOne(c => c.CVData)
                .HasForeignKey<Communication>(x => x.CVDataId);

            builder.Entity<CVData>()
                .HasOne(cvd => cvd.Education)
                .WithOne(c => c.CVData)
                .HasForeignKey<Education>(x => x.CVDataId);

            builder.Entity<CVData>()
                .HasOne(cvd => cvd.Experience)
                .WithOne(c => c.CVData)
                .HasForeignKey<Experience>(x => x.CVDataId);

            builder.Entity<CVData>()
                .HasOne(cvd => cvd.Hobby)
                .WithOne(c => c.CVData)
                .HasForeignKey<Hobby>(x => x.CVDataId);

            builder.Entity<CVData>()
                .HasOne(cvd => cvd.Skill)
                .WithOne(c => c.CVData)
                .HasForeignKey<Skill>(x => x.CVDataId);
            #endregion

            #region CVSystemUser Configuration
            builder.Entity<CVSystemUser>()
                .HasOne(cvsu => cvsu.LoginData)
                .WithOne(ld => ld.CVSystemUser)
                .HasForeignKey<LoginData>(ld => ld.CVSystemUserId);

            builder.Entity<CVSystemUser>()
                .HasOne(cvsu => cvsu.PersonalData)
                .WithOne(pd => pd.CVSystemUser)
                .HasForeignKey<PersonalData>(pd => pd.CVSystemUserId);
            #endregion

            #region Country Configuration
            builder.Entity<Country>()
                .HasOne(cn => cn.ZipCode)
                .WithOne(zc => zc.Country)
                .HasForeignKey<ZipCode>(zc => zc.CountryId);
            #endregion

            #region YearRange Configuration
            builder.Entity<YearRange>()
                .HasOne(yr => yr.EducationData)
                .WithOne(ed => ed.YearRange)
                .HasForeignKey<EducationData>(ed => ed.YearRangeId);

            builder.Entity<YearRange>()
                .HasOne(yr => yr.ExperienceData)
                .WithOne(ed => ed.YearRange)
                .HasForeignKey<ExperienceData>(ed => ed.YearRangeId);
            #endregion
        }
        #region DB Sets
        public virtual DbSet<Communication> Communications { get; set; }
        public virtual DbSet<CommunicationData> CommunicationDatas { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<EducationData> EducationDatas { get; set; }
        public virtual DbSet<Experience> Experiences { get; set; }
        public virtual DbSet<ExperienceData> ExperienceDatas { get; set; }
        public virtual DbSet<Hobby> Hobbies { get; set; }
        public virtual DbSet<HobbyData> HobbyDatas { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<SkillData> SkillDatas { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<CVData> CVDatas { get; set; }
        public virtual DbSet<CVSystemUser> CVSystemUsers { get; set; }
        public virtual DbSet<PersonalData> PersonalDatas { get; set; }
        public virtual DbSet<YearRange> YearRanges { get; set; }
        public virtual DbSet<ZipCode> ZipCodes { get; set; }
        #endregion
    }
}
