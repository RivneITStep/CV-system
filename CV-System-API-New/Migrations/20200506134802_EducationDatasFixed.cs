using Microsoft.EntityFrameworkCore.Migrations;

namespace CV_System_API_New.Migrations
{
    public partial class EducationDatasFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GetEducationDatas_Educations_EducationId",
                table: "GetEducationDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_GetEducationDatas_YearRanges_YearRangeId",
                table: "GetEducationDatas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GetEducationDatas",
                table: "GetEducationDatas");

            migrationBuilder.RenameTable(
                name: "GetEducationDatas",
                newName: "EducationDatas");

            migrationBuilder.RenameIndex(
                name: "IX_GetEducationDatas_YearRangeId",
                table: "EducationDatas",
                newName: "IX_EducationDatas_YearRangeId");

            migrationBuilder.RenameIndex(
                name: "IX_GetEducationDatas_EducationId",
                table: "EducationDatas",
                newName: "IX_EducationDatas_EducationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EducationDatas",
                table: "EducationDatas",
                column: "EducationDataId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "879e38ac-7a3b-4edb-9192-826a73cedbd4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "488cecd1-06fd-4e5b-bffd-62d9a417cb8e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "f7e59178-3bde-4da5-b183-9f74f5ff0fbd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "37f4eaa4-d6e4-4969-a3b0-7521ca83c1e9");

            migrationBuilder.AddForeignKey(
                name: "FK_EducationDatas_Educations_EducationId",
                table: "EducationDatas",
                column: "EducationId",
                principalTable: "Educations",
                principalColumn: "EducationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EducationDatas_YearRanges_YearRangeId",
                table: "EducationDatas",
                column: "YearRangeId",
                principalTable: "YearRanges",
                principalColumn: "YearRangeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EducationDatas_Educations_EducationId",
                table: "EducationDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_EducationDatas_YearRanges_YearRangeId",
                table: "EducationDatas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EducationDatas",
                table: "EducationDatas");

            migrationBuilder.RenameTable(
                name: "EducationDatas",
                newName: "GetEducationDatas");

            migrationBuilder.RenameIndex(
                name: "IX_EducationDatas_YearRangeId",
                table: "GetEducationDatas",
                newName: "IX_GetEducationDatas_YearRangeId");

            migrationBuilder.RenameIndex(
                name: "IX_EducationDatas_EducationId",
                table: "GetEducationDatas",
                newName: "IX_GetEducationDatas_EducationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GetEducationDatas",
                table: "GetEducationDatas",
                column: "EducationDataId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "82e1a2ed-1ecb-4fd9-bec5-58625c81ecb3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "ec1b7e30-f32d-4cdd-a926-7fb97fa9aef7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "b52af1c6-eb16-4ad0-a60d-0a934a5ba68a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "f484d927-92a5-4e60-af2b-8d3d14347f7a");

            migrationBuilder.AddForeignKey(
                name: "FK_GetEducationDatas_Educations_EducationId",
                table: "GetEducationDatas",
                column: "EducationId",
                principalTable: "Educations",
                principalColumn: "EducationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GetEducationDatas_YearRanges_YearRangeId",
                table: "GetEducationDatas",
                column: "YearRangeId",
                principalTable: "YearRanges",
                principalColumn: "YearRangeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
