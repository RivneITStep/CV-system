using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using API_Real_Base_Test_Own_Context.Helpers;

namespace API_Real_Base_Test_Own_Context.Models
{
    public partial class CVContext : DbContext
    {
        public CVContext()
        {
        }

        public CVContext(DbContextOptions<CVContext> options)
            : base(options)
        {
        }
        #region DB SETS
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AdminData> AdminData { get; set; }
        public virtual DbSet<Communication> Communication { get; set; }
        public virtual DbSet<Education> Education { get; set; }
        public virtual DbSet<Experience> Experience { get; set; }
        public virtual DbSet<Hobbies> Hobbies { get; set; }
        public virtual DbSet<HrData> HrData { get; set; }
        public virtual DbSet<Languages> Languages { get; set; }
        public virtual DbSet<LoginAdminBinder> LoginAdminBinder { get; set; }
        public virtual DbSet<LoginCvBinder> LoginCvBinder { get; set; }
        public virtual DbSet<LoginHrBinder> LoginHrBinder { get; set; }
        public virtual DbSet<PersonHobbies> PersonHobbies { get; set; }
        public virtual DbSet<PersonLanguages> PersonLanguages { get; set; }
        public virtual DbSet<PersonPersonalities> PersonPersonalities { get; set; }
        public virtual DbSet<PersonSoftwareSkill> PersonSoftwareSkill { get; set; }
        public virtual DbSet<PersonTrainings> PersonTrainings { get; set; }
        public virtual DbSet<PersonalData> PersonalData { get; set; }
        public virtual DbSet<Personality> Personality { get; set; }
        public virtual DbSet<Signin> Signin { get; set; }
        public virtual DbSet<Skills> Skills { get; set; }
        public virtual DbSet<SocialNetworks> SocialNetworks { get; set; }
        public virtual DbSet<Trainings> Trainings { get; set; }
        #endregion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionStringHelper.ExternalString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region ADDRESS
            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.AddressId).HasColumnName("Address_ID");

                entity.Property(e => e.BuildingNumber)
                    .IsRequired()
                    .HasColumnName("Building_Number")
                    .HasMaxLength(100);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('Ukraine')");

                entity.Property(e => e.Flat)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PersonalId).HasColumnName("PersonalID");

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ZipCode)
                    .IsRequired()
                    .HasColumnName("Zip_Code")
                    .HasMaxLength(100);

                entity.HasOne(d => d.Personal)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.PersonalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Address__Persona__4BAC3F29");
            });
            #endregion

            #region ADMIN DATA
            modelBuilder.Entity<AdminData>(entity =>
            {
                entity.HasKey(e => e.AdminId)
                    .HasName("PK__Admin_Da__4A300117E4767A63");

                entity.ToTable("Admin_Data");

                entity.Property(e => e.AdminId).HasColumnName("Admin_ID");
            });
            #endregion

            #region COMMUNICATION
            modelBuilder.Entity<Communication>(entity =>
            {
                entity.Property(e => e.CommunicationId).HasColumnName("Communication_ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PersonalId).HasColumnName("PersonalID");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Skype).HasMaxLength(100);

                entity.Property(e => e.Viber).HasMaxLength(100);

                entity.Property(e => e.WhatsApp).HasMaxLength(100);

                entity.HasOne(d => d.Personal)
                    .WithMany(p => p.Communication)
                    .HasForeignKey(d => d.PersonalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Communica__Perso__4E88ABD4");
            });
            #endregion

            #region EDUCATION
            modelBuilder.Entity<Education>(entity =>
            {
                entity.Property(e => e.EducationId).HasColumnName("Education_ID");

                entity.Property(e => e.CourseName)
                    .IsRequired()
                    .HasColumnName("Course_Name")
                    .HasMaxLength(150);

                entity.Property(e => e.EducationalInstitutionName)
                    .IsRequired()
                    .HasColumnName("Educational_Institution_Name")
                    .HasMaxLength(150);

                entity.Property(e => e.EndDate)
                    .HasColumnName("End_Date")
                    .HasColumnType("date");

                entity.Property(e => e.PersonalId).HasColumnName("PersonalID");

                entity.Property(e => e.StartDate)
                    .HasColumnName("Start_Date")
                    .HasColumnType("date");

                entity.HasOne(d => d.Personal)
                    .WithMany(p => p.Education)
                    .HasForeignKey(d => d.PersonalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Education__Perso__5441852A");
            });
            #endregion

            #region EXPERIENCE
            modelBuilder.Entity<Experience>(entity =>
            {
                entity.Property(e => e.ExperienceId).HasColumnName("Experience_ID");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasColumnName("Company_Name")
                    .HasMaxLength(150);

                entity.Property(e => e.EndDate)
                    .HasColumnName("End_Date")
                    .HasColumnType("date");

                entity.Property(e => e.PersonalId).HasColumnName("PersonalID");

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.StartDate)
                    .HasColumnName("Start_Date")
                    .HasColumnType("date");

                entity.HasOne(d => d.Personal)
                    .WithMany(p => p.Experience)
                    .HasForeignKey(d => d.PersonalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Experienc__Perso__571DF1D5");
            });
            #endregion

            #region HOBBIES
            modelBuilder.Entity<Hobbies>(entity =>
            {
                entity.HasKey(e => e.HobbyId)
                    .HasName("PK__Hobbies__620FC5F87F09E906");

                entity.Property(e => e.HobbyId).HasColumnName("Hobby_ID");

                entity.Property(e => e.HobbyName)
                    .IsRequired()
                    .HasColumnName("Hobby_Name")
                    .HasMaxLength(100);
            });
            #endregion

            #region HR DATA
            modelBuilder.Entity<HrData>(entity =>
            {
                entity.HasKey(e => e.HrId)
                    .HasName("PK__HR_Data__272A3F7E88A57F08");

                entity.ToTable("HR_Data");

                entity.Property(e => e.HrId).HasColumnName("HR_ID");

                entity.HasOne(d => d.FavoritesNavigation)
                    .WithMany(p => p.HrData)
                    .HasForeignKey(d => d.Favorites)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HR_Data__Favorit__3A81B327");
            });
            #endregion

            #region LANGUAGES
            modelBuilder.Entity<Languages>(entity =>
            {
                entity.HasKey(e => e.LanguageId)
                    .HasName("PK__Language__B7596F13007110DE");

                entity.Property(e => e.LanguageId).HasColumnName("Language_ID");

                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasColumnName("Language_Name")
                    .HasMaxLength(50);
            });
            #endregion

            #region LOGIN ADMIN BINDER
            modelBuilder.Entity<LoginAdminBinder>(entity =>
            {
                entity.ToTable("Login_Admin_Binder");

                entity.Property(e => e.LoginAdminBinderId).HasColumnName("Login_Admin_Binder_ID");

                entity.Property(e => e.AdminId).HasColumnName("Admin_ID");

                entity.Property(e => e.LoginId).HasColumnName("LoginID");

                entity.HasOne(d => d.Admin)
                    .WithMany(p => p.LoginAdminBinder)
                    .HasForeignKey(d => d.AdminId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Login_Adm__Admin__46E78A0C");

                entity.HasOne(d => d.Login)
                    .WithMany(p => p.LoginAdminBinder)
                    .HasForeignKey(d => d.LoginId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Login_Adm__Login__47DBAE45");
            });
            #endregion

            #region LOGIN CV BINDER
            modelBuilder.Entity<LoginCvBinder>(entity =>
            {
                entity.ToTable("Login_CV_Binder");

                entity.Property(e => e.LoginCvBinderId).HasColumnName("Login_CV_Binder_ID");

                entity.Property(e => e.LoginId).HasColumnName("LoginID");

                entity.Property(e => e.PersonalId).HasColumnName("PersonalID");

                entity.HasOne(d => d.Login)
                    .WithMany(p => p.LoginCvBinder)
                    .HasForeignKey(d => d.LoginId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Login_CV___Login__403A8C7D");

                entity.HasOne(d => d.Personal)
                    .WithMany(p => p.LoginCvBinder)
                    .HasForeignKey(d => d.PersonalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Login_CV___Perso__3F466844");
            });
            #endregion

            #region LOGIN HR BINDER
            modelBuilder.Entity<LoginHrBinder>(entity =>
            {
                entity.ToTable("Login_HR_Binder");

                entity.Property(e => e.LoginHrBinderId).HasColumnName("Login_HR_Binder_ID");

                entity.Property(e => e.HrId).HasColumnName("HR_ID");

                entity.Property(e => e.LoginId).HasColumnName("LoginID");

                entity.HasOne(d => d.Hr)
                    .WithMany(p => p.LoginHrBinder)
                    .HasForeignKey(d => d.HrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Login_HR___HR_ID__4316F928");

                entity.HasOne(d => d.Login)
                    .WithMany(p => p.LoginHrBinder)
                    .HasForeignKey(d => d.LoginId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Login_HR___Login__440B1D61");
            });
            #endregion

            #region PERSON HOBBIES
            modelBuilder.Entity<PersonHobbies>(entity =>
            {
                entity.Property(e => e.PersonHobbiesId).HasColumnName("PersonHobbies_ID");

                entity.Property(e => e.HobbyId).HasColumnName("HobbyID");

                entity.Property(e => e.PersonalDataId).HasColumnName("PersonalDataID");

                entity.HasOne(d => d.Hobby)
                    .WithMany(p => p.PersonHobbies)
                    .HasForeignKey(d => d.HobbyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PersonHob__Hobby__0D7A0286");

                entity.HasOne(d => d.PersonalData)
                    .WithMany(p => p.PersonHobbies)
                    .HasForeignKey(d => d.PersonalDataId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PersonHob__Perso__0E6E26BF");
            });
            #endregion

            #region PERSON LANGUAGES
            modelBuilder.Entity<PersonLanguages>(entity =>
            {
                entity.Property(e => e.PersonLanguagesId).HasColumnName("PersonLanguages_ID");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LanguageLevel).HasColumnName("Language_Level");

                entity.Property(e => e.PersonalDataId).HasColumnName("PersonalDataID");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.PersonLanguages)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PersonLan__Langu__18EBB532");

                entity.HasOne(d => d.PersonalData)
                    .WithMany(p => p.PersonLanguages)
                    .HasForeignKey(d => d.PersonalDataId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PersonLan__Perso__19DFD96B");
            });
            #endregion

            #region PERSON PERSONALITIES
            modelBuilder.Entity<PersonPersonalities>(entity =>
            {
                entity.Property(e => e.PersonPersonalitiesId).HasColumnName("PersonPersonalities_ID");

                entity.Property(e => e.PersonalDataId).HasColumnName("PersonalDataID");

                entity.Property(e => e.PersonalityId).HasColumnName("PersonalityID");

                entity.HasOne(d => d.PersonalData)
                    .WithMany(p => p.PersonPersonalities)
                    .HasForeignKey(d => d.PersonalDataId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PersonPer__Perso__2180FB33");

                entity.HasOne(d => d.Personality)
                    .WithMany(p => p.PersonPersonalities)
                    .HasForeignKey(d => d.PersonalityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PersonPer__Perso__208CD6FA");
            });
            #endregion

            #region PERSON SOFTWARE SKILL
            modelBuilder.Entity<PersonSoftwareSkill>(entity =>
            {
                entity.ToTable("PersonSoftware_Skill");

                entity.Property(e => e.PersonSoftwareSkillId).HasColumnName("PersonSoftware_Skill_ID");

                entity.Property(e => e.PersonalDataId).HasColumnName("PersonalDataID");

                entity.Property(e => e.SkillId).HasColumnName("SkillID");

                entity.Property(e => e.SoftwareSkillLevel).HasColumnName("Software_Skill_Level");

                entity.HasOne(d => d.PersonalData)
                    .WithMany(p => p.PersonSoftwareSkill)
                    .HasForeignKey(d => d.PersonalDataId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PersonSof__Perso__25518C17");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.PersonSoftwareSkill)
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PersonSof__Skill__245D67DE");
            });
            #endregion

            #region PERSON TRAININGS
            modelBuilder.Entity<PersonTrainings>(entity =>
            {
                entity.Property(e => e.PersonTrainingsId).HasColumnName("PersonTrainings_ID");

                entity.Property(e => e.PersonalDataId).HasColumnName("PersonalDataID");

                entity.Property(e => e.TrainingsId).HasColumnName("TrainingsID");

                entity.HasOne(d => d.PersonalData)
                    .WithMany(p => p.PersonTrainings)
                    .HasForeignKey(d => d.PersonalDataId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PersonTra__Perso__29221CFB");

                entity.HasOne(d => d.Trainings)
                    .WithMany(p => p.PersonTrainings)
                    .HasForeignKey(d => d.TrainingsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PersonTra__Train__282DF8C2");
            });
            #endregion

            #region PERSONAL DATA
            modelBuilder.Entity<PersonalData>(entity =>
            {
                entity.HasKey(e => e.PersonalId)
                    .HasName("PK__Personal__732F9CEA2A0956E0");

                entity.ToTable("Personal_Data");

                entity.Property(e => e.PersonalId).HasColumnName("Personal_ID");

                entity.Property(e => e.BirthDate)
                    .HasColumnName("Birth_Date")
                    .HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("First_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last_Name")
                    .HasMaxLength(100);
            });
            #endregion

            #region PERSONALITY
            modelBuilder.Entity<Personality>(entity =>
            {
                entity.Property(e => e.PersonalityId).HasColumnName("Personality_ID");

                entity.Property(e => e.PersonalityName)
                    .IsRequired()
                    .HasColumnName("Personality_Name")
                    .HasMaxLength(100);
            });
            #endregion

            #region SIGNIN
            modelBuilder.Entity<Signin>(entity =>
            {
                entity.HasKey(e => e.LoginId)
                    .HasName("PK__Signin__D788686750A429CD");

                entity.Property(e => e.LoginId).HasColumnName("Login_ID");

                entity.Property(e => e.LoginName)
                    .IsRequired()
                    .HasColumnName("Login_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100);
            });
            #endregion

            #region SKILLS
            modelBuilder.Entity<Skills>(entity =>
            {
                entity.Property(e => e.SkillsId).HasColumnName("Skills_ID");

                entity.Property(e => e.SkillName)
                    .IsRequired()
                    .HasColumnName("Skill_Name")
                    .HasMaxLength(200);
            });
            #endregion

            #region SOCIAL NETWORKS
            modelBuilder.Entity<SocialNetworks>(entity =>
            {
                entity.ToTable("Social_Networks");

                entity.Property(e => e.SocialNetworksId).HasColumnName("Social_Networks_ID");

                entity.Property(e => e.Facebook).HasMaxLength(100);

                entity.Property(e => e.Hangouts).HasMaxLength(100);

                entity.Property(e => e.Imo).HasMaxLength(100);

                entity.Property(e => e.Instagram).HasMaxLength(100);

                entity.Property(e => e.Linkedin).HasMaxLength(100);

                entity.Property(e => e.PersonalId).HasColumnName("PersonalID");

                entity.Property(e => e.Telegram).HasMaxLength(100);

                entity.Property(e => e.Twitter).HasMaxLength(100);

                entity.Property(e => e.Veon).HasMaxLength(100);

                entity.HasOne(d => d.Personal)
                    .WithMany(p => p.SocialNetworks)
                    .HasForeignKey(d => d.PersonalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Social_Ne__Perso__5165187F");
            });
            #endregion

            #region TRAININGS
            modelBuilder.Entity<Trainings>(entity =>
            {
                entity.HasKey(e => e.TrainingId)
                    .HasName("PK__Training__EF9C3816CDB6B3EA");

                entity.Property(e => e.TrainingId).HasColumnName("Training_ID");

                entity.Property(e => e.TrainingName)
                    .IsRequired()
                    .HasColumnName("Training_Name")
                    .HasMaxLength(200);
            });
            #endregion

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
