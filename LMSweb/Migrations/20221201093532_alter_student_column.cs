using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMSweb.Migrations
{
    public partial class alter_student_column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Courses_CID",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Groups_GID",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Student");

            migrationBuilder.RenameIndex(
                name: "IX_Students_GID",
                table: "Student",
                newName: "IX_Student_GID");

            migrationBuilder.RenameIndex(
                name: "IX_Students_CID",
                table: "Student",
                newName: "IX_Student_CID");

            migrationBuilder.AlterColumn<string>(
                name: "GID",
                table: "Student",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "CID",
                table: "Student",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "SID");

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "SID", "CID", "GID", "Password", "SName", "Sex" },
                values: new object[,]
                {
                    { "S001", null, null, "S001", "測試學生1", "男" },
                    { "S002", null, null, "S002", "測試學生2", "男" },
                    { "S003", null, null, "S003", "測試學生3", "女" },
                    { "S004", null, null, "S004", "測試學生4", "女" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Courses_CID",
                table: "Student",
                column: "CID",
                principalTable: "Courses",
                principalColumn: "CID");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Groups_GID",
                table: "Student",
                column: "GID",
                principalTable: "Groups",
                principalColumn: "GID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Courses_CID",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Groups_GID",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "SID",
                keyValue: "S001");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "SID",
                keyValue: "S002");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "SID",
                keyValue: "S003");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "SID",
                keyValue: "S004");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Students");

            migrationBuilder.RenameIndex(
                name: "IX_Student_GID",
                table: "Students",
                newName: "IX_Students_GID");

            migrationBuilder.RenameIndex(
                name: "IX_Student_CID",
                table: "Students",
                newName: "IX_Students_CID");

            migrationBuilder.AlterColumn<string>(
                name: "GID",
                table: "Students",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CID",
                table: "Students",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "SID");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_CID",
                table: "Students",
                column: "CID",
                principalTable: "Courses",
                principalColumn: "CID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Groups_GID",
                table: "Students",
                column: "GID",
                principalTable: "Groups",
                principalColumn: "GID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
