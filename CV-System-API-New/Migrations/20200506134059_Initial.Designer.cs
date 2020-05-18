﻿// <auto-generated />
using System;
using CV_System_API_New.DataDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CV_System_API_New.Migrations
{
    [DbContext(typeof(CVSystemContext))]
    [Migration("20200506134059_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CV_System_API_New.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<int?>("HouseNumber")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ZipCodeId")
                        .HasColumnType("int");

                    b.HasKey("AddressId");

                    b.HasIndex("CityId");

                    b.HasIndex("ZipCodeId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("CV_System_API_New.Models.CVData", b =>
                {
                    b.Property<int>("CVDataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CVSystemUserId")
                        .HasColumnType("int");

                    b.HasKey("CVDataId");

                    b.HasIndex("CVSystemUserId");

                    b.ToTable("CVDatas");
                });

            modelBuilder.Entity("CV_System_API_New.Models.CVSystemUser", b =>
                {
                    b.Property<int>("CVSystemUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("UserRoleId")
                        .HasColumnType("int");

                    b.HasKey("CVSystemUserId");

                    b.HasIndex("UserRoleId");

                    b.ToTable("CVSystemUsers");
                });

            modelBuilder.Entity("CV_System_API_New.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CityId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("CV_System_API_New.Models.CommunicationInfo.Communication", b =>
                {
                    b.Property<int>("CommunicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CVDataId")
                        .HasColumnType("int");

                    b.HasKey("CommunicationId");

                    b.HasIndex("CVDataId")
                        .IsUnique();

                    b.ToTable("Communications");
                });

            modelBuilder.Entity("CV_System_API_New.Models.CommunicationInfo.CommunicationData", b =>
                {
                    b.Property<int>("CommunicationDataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommunicationDataContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommunicationDataName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CommunicationId")
                        .HasColumnType("int");

                    b.HasKey("CommunicationDataId");

                    b.HasIndex("CommunicationId");

                    b.ToTable("CommunicationDatas");
                });

            modelBuilder.Entity("CV_System_API_New.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("CV_System_API_New.Models.EducationInfo.Education", b =>
                {
                    b.Property<int>("EducationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CVDataId")
                        .HasColumnType("int");

                    b.HasKey("EducationId");

                    b.HasIndex("CVDataId")
                        .IsUnique();

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("CV_System_API_New.Models.EducationInfo.EducationData", b =>
                {
                    b.Property<int>("EducationDataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EducationId")
                        .HasColumnType("int");

                    b.Property<string>("EducationalInstitution")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearRangeId")
                        .HasColumnType("int");

                    b.HasKey("EducationDataId");

                    b.HasIndex("EducationId");

                    b.HasIndex("YearRangeId")
                        .IsUnique();

                    b.ToTable("GetEducationDatas");
                });

            modelBuilder.Entity("CV_System_API_New.Models.ExperienceInfo.Experience", b =>
                {
                    b.Property<int>("ExperienceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CVDataId")
                        .HasColumnType("int");

                    b.HasKey("ExperienceId");

                    b.HasIndex("CVDataId")
                        .IsUnique();

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("CV_System_API_New.Models.ExperienceInfo.ExperienceData", b =>
                {
                    b.Property<int>("ExperienceDataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ExperienceId")
                        .HasColumnType("int");

                    b.Property<string>("PlaceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearRangeId")
                        .HasColumnType("int");

                    b.HasKey("ExperienceDataId");

                    b.HasIndex("ExperienceId");

                    b.HasIndex("YearRangeId")
                        .IsUnique();

                    b.ToTable("ExperienceDatas");
                });

            modelBuilder.Entity("CV_System_API_New.Models.Gender", b =>
                {
                    b.Property<int>("GenderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GenderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenderId");

                    b.ToTable("Gender");
                });

            modelBuilder.Entity("CV_System_API_New.Models.HobbyInfo.Hobby", b =>
                {
                    b.Property<int>("HobbyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CVDataId")
                        .HasColumnType("int");

                    b.HasKey("HobbyId");

                    b.HasIndex("CVDataId")
                        .IsUnique();

                    b.ToTable("Hobbies");
                });

            modelBuilder.Entity("CV_System_API_New.Models.HobbyInfo.HobbyData", b =>
                {
                    b.Property<int>("HobbyDataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("HobbyId")
                        .HasColumnType("int");

                    b.Property<string>("HobbyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HobbyDataId");

                    b.HasIndex("HobbyId");

                    b.ToTable("HobbyDatas");
                });

            modelBuilder.Entity("CV_System_API_New.Models.LoginData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int>("CVSystemUserId")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("CVSystemUserId")
                        .IsUnique();

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("CV_System_API_New.Models.ManyToManyBinders.AddressPersonalData", b =>
                {
                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<int>("PersonalDataId")
                        .HasColumnType("int");

                    b.HasKey("AddressId", "PersonalDataId");

                    b.HasIndex("PersonalDataId");

                    b.ToTable("AddressPersonalData");
                });

            modelBuilder.Entity("CV_System_API_New.Models.ManyToManyBinders.CityCountry", b =>
                {
                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.HasKey("CityId", "CountryId");

                    b.HasIndex("CountryId");

                    b.ToTable("CityCountry");
                });

            modelBuilder.Entity("CV_System_API_New.Models.ManyToManyBinders.CityZipCode", b =>
                {
                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("ZipCodeId")
                        .HasColumnType("int");

                    b.HasKey("CityId", "ZipCodeId");

                    b.HasIndex("ZipCodeId");

                    b.ToTable("CityZipCode");
                });

            modelBuilder.Entity("CV_System_API_New.Models.PersonalData", b =>
                {
                    b.Property<int>("PersonalDataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CVSystemUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GenderId")
                        .HasColumnType("int");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonalDataId");

                    b.HasIndex("CVSystemUserId")
                        .IsUnique();

                    b.HasIndex("GenderId");

                    b.ToTable("PersonalDatas");
                });

            modelBuilder.Entity("CV_System_API_New.Models.SkillInfo.Skill", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CVDataId")
                        .HasColumnType("int");

                    b.HasKey("SkillId");

                    b.HasIndex("CVDataId")
                        .IsUnique();

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("CV_System_API_New.Models.SkillInfo.SkillData", b =>
                {
                    b.Property<int>("SkillDataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SkillDataName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SkillId")
                        .HasColumnType("int");

                    b.Property<string>("SkillLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SkillDataId");

                    b.HasIndex("SkillId");

                    b.ToTable("SkillDatas");
                });

            modelBuilder.Entity("CV_System_API_New.Models.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "82e1a2ed-1ecb-4fd9-bec5-58625c81ecb3",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "ec1b7e30-f32d-4cdd-a926-7fb97fa9aef7",
                            Name = "HumanResourceManager",
                            NormalizedName = "HUMANRESOURCEMANAGER"
                        },
                        new
                        {
                            Id = 3,
                            ConcurrencyStamp = "b52af1c6-eb16-4ad0-a60d-0a934a5ba68a",
                            Name = "NormalUser",
                            NormalizedName = "NORMALUSER"
                        },
                        new
                        {
                            Id = 4,
                            ConcurrencyStamp = "f484d927-92a5-4e60-af2b-8d3d14347f7a",
                            Name = "UnregisteredUser",
                            NormalizedName = "UNREGISTEREDUSER"
                        });
                });

            modelBuilder.Entity("CV_System_API_New.Models.YearRange", b =>
                {
                    b.Property<int>("YearRangeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EndYear")
                        .HasColumnType("int");

                    b.Property<int?>("StartYear")
                        .HasColumnType("int");

                    b.HasKey("YearRangeId");

                    b.ToTable("YearRanges");
                });

            modelBuilder.Entity("CV_System_API_New.Models.ZipCode", b =>
                {
                    b.Property<int>("ZipCodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.HasKey("ZipCodeId");

                    b.HasIndex("CountryId")
                        .IsUnique();

                    b.ToTable("ZipCodes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CV_System_API_New.Models.Address", b =>
                {
                    b.HasOne("CV_System_API_New.Models.City", "City")
                        .WithMany("Addresses")
                        .HasForeignKey("CityId");

                    b.HasOne("CV_System_API_New.Models.ZipCode", "ZipCode")
                        .WithMany("Addresses")
                        .HasForeignKey("ZipCodeId");
                });

            modelBuilder.Entity("CV_System_API_New.Models.CVData", b =>
                {
                    b.HasOne("CV_System_API_New.Models.CVSystemUser", "CVSystemUser")
                        .WithMany("CVDatas")
                        .HasForeignKey("CVSystemUserId");
                });

            modelBuilder.Entity("CV_System_API_New.Models.CVSystemUser", b =>
                {
                    b.HasOne("CV_System_API_New.Models.UserRole", "UserRole")
                        .WithMany("Users")
                        .HasForeignKey("UserRoleId");
                });

            modelBuilder.Entity("CV_System_API_New.Models.CommunicationInfo.Communication", b =>
                {
                    b.HasOne("CV_System_API_New.Models.CVData", "CVData")
                        .WithOne("Communication")
                        .HasForeignKey("CV_System_API_New.Models.CommunicationInfo.Communication", "CVDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CV_System_API_New.Models.CommunicationInfo.CommunicationData", b =>
                {
                    b.HasOne("CV_System_API_New.Models.CommunicationInfo.Communication", "Communication")
                        .WithMany("CommunicationDatas")
                        .HasForeignKey("CommunicationId");
                });

            modelBuilder.Entity("CV_System_API_New.Models.EducationInfo.Education", b =>
                {
                    b.HasOne("CV_System_API_New.Models.CVData", "CVData")
                        .WithOne("Education")
                        .HasForeignKey("CV_System_API_New.Models.EducationInfo.Education", "CVDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CV_System_API_New.Models.EducationInfo.EducationData", b =>
                {
                    b.HasOne("CV_System_API_New.Models.EducationInfo.Education", "Education")
                        .WithMany("EducationDatas")
                        .HasForeignKey("EducationId");

                    b.HasOne("CV_System_API_New.Models.YearRange", "YearRange")
                        .WithOne("EducationData")
                        .HasForeignKey("CV_System_API_New.Models.EducationInfo.EducationData", "YearRangeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CV_System_API_New.Models.ExperienceInfo.Experience", b =>
                {
                    b.HasOne("CV_System_API_New.Models.CVData", "CVData")
                        .WithOne("Experience")
                        .HasForeignKey("CV_System_API_New.Models.ExperienceInfo.Experience", "CVDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CV_System_API_New.Models.ExperienceInfo.ExperienceData", b =>
                {
                    b.HasOne("CV_System_API_New.Models.ExperienceInfo.Experience", "Experience")
                        .WithMany("ExperienceDatas")
                        .HasForeignKey("ExperienceId");

                    b.HasOne("CV_System_API_New.Models.YearRange", "YearRange")
                        .WithOne("ExperienceData")
                        .HasForeignKey("CV_System_API_New.Models.ExperienceInfo.ExperienceData", "YearRangeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CV_System_API_New.Models.HobbyInfo.Hobby", b =>
                {
                    b.HasOne("CV_System_API_New.Models.CVData", "CVData")
                        .WithOne("Hobby")
                        .HasForeignKey("CV_System_API_New.Models.HobbyInfo.Hobby", "CVDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CV_System_API_New.Models.HobbyInfo.HobbyData", b =>
                {
                    b.HasOne("CV_System_API_New.Models.HobbyInfo.Hobby", "Hobby")
                        .WithMany("HobbyDatas")
                        .HasForeignKey("HobbyId");
                });

            modelBuilder.Entity("CV_System_API_New.Models.LoginData", b =>
                {
                    b.HasOne("CV_System_API_New.Models.CVSystemUser", "CVSystemUser")
                        .WithOne("LoginData")
                        .HasForeignKey("CV_System_API_New.Models.LoginData", "CVSystemUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CV_System_API_New.Models.ManyToManyBinders.AddressPersonalData", b =>
                {
                    b.HasOne("CV_System_API_New.Models.Address", "Address")
                        .WithMany("AddressPersonalData")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CV_System_API_New.Models.PersonalData", "PersonalData")
                        .WithMany("AddressPersonalData")
                        .HasForeignKey("PersonalDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CV_System_API_New.Models.ManyToManyBinders.CityCountry", b =>
                {
                    b.HasOne("CV_System_API_New.Models.City", "City")
                        .WithMany("CityCountries")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CV_System_API_New.Models.Country", "Country")
                        .WithMany("CityCountries")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CV_System_API_New.Models.ManyToManyBinders.CityZipCode", b =>
                {
                    b.HasOne("CV_System_API_New.Models.City", "City")
                        .WithMany("CityZipCodes")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CV_System_API_New.Models.ZipCode", "ZipCode")
                        .WithMany("CityZipCodes")
                        .HasForeignKey("ZipCodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CV_System_API_New.Models.PersonalData", b =>
                {
                    b.HasOne("CV_System_API_New.Models.CVSystemUser", "CVSystemUser")
                        .WithOne("PersonalData")
                        .HasForeignKey("CV_System_API_New.Models.PersonalData", "CVSystemUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CV_System_API_New.Models.Gender", "Gender")
                        .WithMany("PersonalDatas")
                        .HasForeignKey("GenderId");
                });

            modelBuilder.Entity("CV_System_API_New.Models.SkillInfo.Skill", b =>
                {
                    b.HasOne("CV_System_API_New.Models.CVData", "CVData")
                        .WithOne("Skill")
                        .HasForeignKey("CV_System_API_New.Models.SkillInfo.Skill", "CVDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CV_System_API_New.Models.SkillInfo.SkillData", b =>
                {
                    b.HasOne("CV_System_API_New.Models.SkillInfo.Skill", "Skill")
                        .WithMany("SkillDatas")
                        .HasForeignKey("SkillId");
                });

            modelBuilder.Entity("CV_System_API_New.Models.ZipCode", b =>
                {
                    b.HasOne("CV_System_API_New.Models.Country", "Country")
                        .WithOne("ZipCode")
                        .HasForeignKey("CV_System_API_New.Models.ZipCode", "CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("CV_System_API_New.Models.UserRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("CV_System_API_New.Models.LoginData", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("CV_System_API_New.Models.LoginData", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("CV_System_API_New.Models.UserRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CV_System_API_New.Models.LoginData", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("CV_System_API_New.Models.LoginData", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
