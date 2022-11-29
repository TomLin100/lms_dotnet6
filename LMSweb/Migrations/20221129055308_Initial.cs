using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMSweb.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    GID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.GID);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    TID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.TID);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAddPeerAssessmemt = table.Column<bool>(type: "bit", nullable: false),
                    IsAddMetacognition = table.Column<bool>(type: "bit", nullable: false),
                    TID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CID);
                    table.ForeignKey(
                        name: "FK_Courses_Teachers_TID",
                        column: x => x.TID,
                        principalTable: "Teachers",
                        principalColumn: "TID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KnowledgePoints",
                columns: table => new
                {
                    KPID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KPContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KnowledgePoints", x => x.KPID);
                    table.ForeignKey(
                        name: "FK_KnowledgePoints_Courses_CID",
                        column: x => x.CID,
                        principalTable: "Courses",
                        principalColumn: "CID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Missions",
                columns: table => new
                {
                    MID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MDetail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MStart = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MEnd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RelateKP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDrawing = table.Column<bool>(type: "bit", nullable: false),
                    IsCoding = table.Column<bool>(type: "bit", nullable: false),
                    IsDiscuss = table.Column<bool>(type: "bit", nullable: false),
                    IsAssess = table.Column<bool>(type: "bit", nullable: false),
                    IsGoalSetting = table.Column<bool>(type: "bit", nullable: false),
                    IsReflect = table.Column<bool>(type: "bit", nullable: false),
                    IsGReflect = table.Column<bool>(type: "bit", nullable: false),
                    IsJourney = table.Column<bool>(type: "bit", nullable: false),
                    CID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Missions", x => x.MID);
                    table.ForeignKey(
                        name: "FK_Missions_Courses_CID",
                        column: x => x.CID,
                        principalTable: "Courses",
                        principalColumn: "CID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    SID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.SID);
                    table.ForeignKey(
                        name: "FK_Students_Courses_CID",
                        column: x => x.CID,
                        principalTable: "Courses",
                        principalColumn: "CID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Groups_GID",
                        column: x => x.GID,
                        principalTable: "Groups",
                        principalColumn: "GID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TID",
                table: "Courses",
                column: "TID");

            migrationBuilder.CreateIndex(
                name: "IX_KnowledgePoints_CID",
                table: "KnowledgePoints",
                column: "CID");

            migrationBuilder.CreateIndex(
                name: "IX_Missions_CID",
                table: "Missions",
                column: "CID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_CID",
                table: "Students",
                column: "CID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_GID",
                table: "Students",
                column: "GID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KnowledgePoints");

            migrationBuilder.DropTable(
                name: "Missions");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
