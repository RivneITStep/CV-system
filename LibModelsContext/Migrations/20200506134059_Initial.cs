using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibModelsContext.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    GenderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.GenderId);
                });

            migrationBuilder.CreateTable(
                name: "YearRanges",
                columns: table => new
                {
                    YearRangeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartYear = table.Column<int>(nullable: true),
                    EndYear = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YearRanges", x => x.YearRangeId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CVSystemUsers",
                columns: table => new
                {
                    CVSystemUserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserRoleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CVSystemUsers", x => x.CVSystemUserId);
                    table.ForeignKey(
                        name: "FK_CVSystemUsers_AspNetRoles_UserRoleId",
                        column: x => x.UserRoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CityCountry",
                columns: table => new
                {
                    CityId = table.Column<int>(nullable: false),
                    CountryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityCountry", x => new { x.CityId, x.CountryId });
                    table.ForeignKey(
                        name: "FK_CityCountry_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CityCountry_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ZipCodes",
                columns: table => new
                {
                    ZipCodeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: false),
                    CountryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZipCodes", x => x.ZipCodeId);
                    table.ForeignKey(
                        name: "FK_ZipCodes_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    CVSystemUserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_CVSystemUsers_CVSystemUserId",
                        column: x => x.CVSystemUserId,
                        principalTable: "CVSystemUsers",
                        principalColumn: "CVSystemUserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CVDatas",
                columns: table => new
                {
                    CVDataId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CVSystemUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CVDatas", x => x.CVDataId);
                    table.ForeignKey(
                        name: "FK_CVDatas_CVSystemUsers_CVSystemUserId",
                        column: x => x.CVSystemUserId,
                        principalTable: "CVSystemUsers",
                        principalColumn: "CVSystemUserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonalDatas",
                columns: table => new
                {
                    PersonalDataId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    SecondName = table.Column<string>(nullable: false),
                    MiddleName = table.Column<string>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    CVSystemUserId = table.Column<int>(nullable: false),
                    GenderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalDatas", x => x.PersonalDataId);
                    table.ForeignKey(
                        name: "FK_PersonalDatas_CVSystemUsers_CVSystemUserId",
                        column: x => x.CVSystemUserId,
                        principalTable: "CVSystemUsers",
                        principalColumn: "CVSystemUserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonalDatas_Gender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "GenderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(nullable: false),
                    HouseNumber = table.Column<int>(nullable: true),
                    CityId = table.Column<int>(nullable: true),
                    ZipCodeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_Addresses_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Addresses_ZipCodes_ZipCodeId",
                        column: x => x.ZipCodeId,
                        principalTable: "ZipCodes",
                        principalColumn: "ZipCodeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CityZipCode",
                columns: table => new
                {
                    CityId = table.Column<int>(nullable: false),
                    ZipCodeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityZipCode", x => new { x.CityId, x.ZipCodeId });
                    table.ForeignKey(
                        name: "FK_CityZipCode_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CityZipCode_ZipCodes_ZipCodeId",
                        column: x => x.ZipCodeId,
                        principalTable: "ZipCodes",
                        principalColumn: "ZipCodeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Communications",
                columns: table => new
                {
                    CommunicationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CVDataId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Communications", x => x.CommunicationId);
                    table.ForeignKey(
                        name: "FK_Communications_CVDatas_CVDataId",
                        column: x => x.CVDataId,
                        principalTable: "CVDatas",
                        principalColumn: "CVDataId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    EducationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CVDataId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.EducationId);
                    table.ForeignKey(
                        name: "FK_Educations_CVDatas_CVDataId",
                        column: x => x.CVDataId,
                        principalTable: "CVDatas",
                        principalColumn: "CVDataId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    ExperienceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CVDataId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.ExperienceId);
                    table.ForeignKey(
                        name: "FK_Experiences_CVDatas_CVDataId",
                        column: x => x.CVDataId,
                        principalTable: "CVDatas",
                        principalColumn: "CVDataId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    HobbyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CVDataId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.HobbyId);
                    table.ForeignKey(
                        name: "FK_Hobbies_CVDatas_CVDataId",
                        column: x => x.CVDataId,
                        principalTable: "CVDatas",
                        principalColumn: "CVDataId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    SkillId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CVDataId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.SkillId);
                    table.ForeignKey(
                        name: "FK_Skills_CVDatas_CVDataId",
                        column: x => x.CVDataId,
                        principalTable: "CVDatas",
                        principalColumn: "CVDataId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AddressPersonalData",
                columns: table => new
                {
                    AddressId = table.Column<int>(nullable: false),
                    PersonalDataId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressPersonalData", x => new { x.AddressId, x.PersonalDataId });
                    table.ForeignKey(
                        name: "FK_AddressPersonalData_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AddressPersonalData_PersonalDatas_PersonalDataId",
                        column: x => x.PersonalDataId,
                        principalTable: "PersonalDatas",
                        principalColumn: "PersonalDataId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommunicationDatas",
                columns: table => new
                {
                    CommunicationDataId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommunicationDataName = table.Column<string>(nullable: false),
                    CommunicationDataContent = table.Column<string>(nullable: false),
                    CommunicationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunicationDatas", x => x.CommunicationDataId);
                    table.ForeignKey(
                        name: "FK_CommunicationDatas_Communications_CommunicationId",
                        column: x => x.CommunicationId,
                        principalTable: "Communications",
                        principalColumn: "CommunicationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GetEducationDatas",
                columns: table => new
                {
                    EducationDataId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationalInstitution = table.Column<string>(nullable: false),
                    Specialization = table.Column<string>(nullable: false),
                    YearRangeId = table.Column<int>(nullable: false),
                    EducationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetEducationDatas", x => x.EducationDataId);
                    table.ForeignKey(
                        name: "FK_GetEducationDatas_Educations_EducationId",
                        column: x => x.EducationId,
                        principalTable: "Educations",
                        principalColumn: "EducationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GetEducationDatas_YearRanges_YearRangeId",
                        column: x => x.YearRangeId,
                        principalTable: "YearRanges",
                        principalColumn: "YearRangeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExperienceDatas",
                columns: table => new
                {
                    ExperienceDataId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaceName = table.Column<string>(nullable: false),
                    YearRangeId = table.Column<int>(nullable: false),
                    ExperienceId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperienceDatas", x => x.ExperienceDataId);
                    table.ForeignKey(
                        name: "FK_ExperienceDatas_Experiences_ExperienceId",
                        column: x => x.ExperienceId,
                        principalTable: "Experiences",
                        principalColumn: "ExperienceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExperienceDatas_YearRanges_YearRangeId",
                        column: x => x.YearRangeId,
                        principalTable: "YearRanges",
                        principalColumn: "YearRangeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HobbyDatas",
                columns: table => new
                {
                    HobbyDataId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HobbyName = table.Column<string>(nullable: false),
                    HobbyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HobbyDatas", x => x.HobbyDataId);
                    table.ForeignKey(
                        name: "FK_HobbyDatas_Hobbies_HobbyId",
                        column: x => x.HobbyId,
                        principalTable: "Hobbies",
                        principalColumn: "HobbyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SkillDatas",
                columns: table => new
                {
                    SkillDataId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillDataName = table.Column<string>(nullable: false),
                    SkillLevel = table.Column<string>(nullable: false),
                    SkillId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillDatas", x => x.SkillDataId);
                    table.ForeignKey(
                        name: "FK_SkillDatas_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "SkillId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "82e1a2ed-1ecb-4fd9-bec5-58625c81ecb3", "Administrator", "ADMINISTRATOR" },
                    { 2, "ec1b7e30-f32d-4cdd-a926-7fb97fa9aef7", "HumanResourceManager", "HUMANRESOURCEMANAGER" },
                    { 3, "b52af1c6-eb16-4ad0-a60d-0a934a5ba68a", "NormalUser", "NORMALUSER" },
                    { 4, "f484d927-92a5-4e60-af2b-8d3d14347f7a", "UnregisteredUser", "UNREGISTEREDUSER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CityId",
                table: "Addresses",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_ZipCodeId",
                table: "Addresses",
                column: "ZipCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressPersonalData_PersonalDataId",
                table: "AddressPersonalData",
                column: "PersonalDataId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CVSystemUserId",
                table: "AspNetUsers",
                column: "CVSystemUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CityCountry_CountryId",
                table: "CityCountry",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_CityZipCode_ZipCodeId",
                table: "CityZipCode",
                column: "ZipCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_CommunicationDatas_CommunicationId",
                table: "CommunicationDatas",
                column: "CommunicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Communications_CVDataId",
                table: "Communications",
                column: "CVDataId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CVDatas_CVSystemUserId",
                table: "CVDatas",
                column: "CVSystemUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CVSystemUsers_UserRoleId",
                table: "CVSystemUsers",
                column: "UserRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_CVDataId",
                table: "Educations",
                column: "CVDataId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExperienceDatas_ExperienceId",
                table: "ExperienceDatas",
                column: "ExperienceId");

            migrationBuilder.CreateIndex(
                name: "IX_ExperienceDatas_YearRangeId",
                table: "ExperienceDatas",
                column: "YearRangeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_CVDataId",
                table: "Experiences",
                column: "CVDataId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GetEducationDatas_EducationId",
                table: "GetEducationDatas",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_GetEducationDatas_YearRangeId",
                table: "GetEducationDatas",
                column: "YearRangeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hobbies_CVDataId",
                table: "Hobbies",
                column: "CVDataId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HobbyDatas_HobbyId",
                table: "HobbyDatas",
                column: "HobbyId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDatas_CVSystemUserId",
                table: "PersonalDatas",
                column: "CVSystemUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDatas_GenderId",
                table: "PersonalDatas",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillDatas_SkillId",
                table: "SkillDatas",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_CVDataId",
                table: "Skills",
                column: "CVDataId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ZipCodes_CountryId",
                table: "ZipCodes",
                column: "CountryId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddressPersonalData");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CityCountry");

            migrationBuilder.DropTable(
                name: "CityZipCode");

            migrationBuilder.DropTable(
                name: "CommunicationDatas");

            migrationBuilder.DropTable(
                name: "ExperienceDatas");

            migrationBuilder.DropTable(
                name: "GetEducationDatas");

            migrationBuilder.DropTable(
                name: "HobbyDatas");

            migrationBuilder.DropTable(
                name: "SkillDatas");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "PersonalDatas");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Communications");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "YearRanges");

            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "ZipCodes");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "CVDatas");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "CVSystemUsers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");
        }
    }
}
