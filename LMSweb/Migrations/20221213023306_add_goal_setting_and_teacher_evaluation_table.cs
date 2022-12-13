using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMSweb.Migrations
{
    public partial class add_goal_setting_and_teacher_evaluation_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DefaultOptions",
                columns: table => new
                {
                    DOID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DQID = table.Column<int>(type: "int", nullable: false),
                    ChoiceItem = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefaultOptions", x => x.DOID);
                    table.ForeignKey(
                        name: "FK_DefaultOptions_DefaultQuestions_DQID",
                        column: x => x.DQID,
                        principalTable: "DefaultQuestions",
                        principalColumn: "DQID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GoalSettingResponses",
                columns: table => new
                {
                    GSRID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DQID = table.Column<int>(type: "int", nullable: false),
                    SID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoalSettingResponses", x => x.GSRID);
                    table.ForeignKey(
                        name: "FK_GoalSettingResponses_DefaultQuestions_DQID",
                        column: x => x.DQID,
                        principalTable: "DefaultQuestions",
                        principalColumn: "DQID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GoalSettingResponses_Missions_MID",
                        column: x => x.MID,
                        principalTable: "Missions",
                        principalColumn: "MID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GoalSettingResponses_Student_SID",
                        column: x => x.SID,
                        principalTable: "Student",
                        principalColumn: "SID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherEvaluationResponses",
                columns: table => new
                {
                    TERID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DQID = table.Column<int>(type: "int", nullable: false),
                    MID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherEvaluationResponses", x => x.TERID);
                    table.ForeignKey(
                        name: "FK_TeacherEvaluationResponses_DefaultQuestions_DQID",
                        column: x => x.DQID,
                        principalTable: "DefaultQuestions",
                        principalColumn: "DQID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherEvaluationResponses_Groups_GID",
                        column: x => x.GID,
                        principalTable: "Groups",
                        principalColumn: "GID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherEvaluationResponses_Missions_MID",
                        column: x => x.MID,
                        principalTable: "Missions",
                        principalColumn: "MID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DefaultOptions_DQID",
                table: "DefaultOptions",
                column: "DQID");

            migrationBuilder.CreateIndex(
                name: "IX_GoalSettingResponses_DQID",
                table: "GoalSettingResponses",
                column: "DQID");

            migrationBuilder.CreateIndex(
                name: "IX_GoalSettingResponses_MID",
                table: "GoalSettingResponses",
                column: "MID");

            migrationBuilder.CreateIndex(
                name: "IX_GoalSettingResponses_SID",
                table: "GoalSettingResponses",
                column: "SID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherEvaluationResponses_DQID",
                table: "TeacherEvaluationResponses",
                column: "DQID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherEvaluationResponses_GID",
                table: "TeacherEvaluationResponses",
                column: "GID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherEvaluationResponses_MID",
                table: "TeacherEvaluationResponses",
                column: "MID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DefaultOptions");

            migrationBuilder.DropTable(
                name: "GoalSettingResponses");

            migrationBuilder.DropTable(
                name: "TeacherEvaluationResponses");
        }
    }
}
