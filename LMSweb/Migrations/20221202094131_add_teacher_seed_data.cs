using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMSweb.Migrations
{
    public partial class add_teacher_seed_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Teachers_TID",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teachers",
                table: "Teachers");

            migrationBuilder.RenameTable(
                name: "Teachers",
                newName: "Teacher");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teacher",
                table: "Teacher",
                column: "TID");

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "TID", "Password", "TName" },
                values: new object[] { "T001", "T001", "測試教師1" });

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "TID", "Password", "TName" },
                values: new object[] { "T002", "T002", "測試教師2" });

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Teacher_TID",
                table: "Courses",
                column: "TID",
                principalTable: "Teacher",
                principalColumn: "TID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Teacher_TID",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teacher",
                table: "Teacher");

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "TID",
                keyValue: "T001");

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "TID",
                keyValue: "T002");

            migrationBuilder.RenameTable(
                name: "Teacher",
                newName: "Teachers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teachers",
                table: "Teachers",
                column: "TID");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Teachers_TID",
                table: "Courses",
                column: "TID",
                principalTable: "Teachers",
                principalColumn: "TID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
