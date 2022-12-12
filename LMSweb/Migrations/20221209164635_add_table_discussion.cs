using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMSweb.Migrations
{
    public partial class add_table_discussion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Discussion",
                columns: table => new
                {
                    DisID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscussionTime = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discussion", x => x.DisID);
                    table.ForeignKey(
                        name: "FK_Discussion_Groups_GID",
                        column: x => x.GID,
                        principalTable: "Groups",
                        principalColumn: "GID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Discussion_Missions_MID",
                        column: x => x.MID,
                        principalTable: "Missions",
                        principalColumn: "MID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Discussion_Student_SID",
                        column: x => x.SID,
                        principalTable: "Student",
                        principalColumn: "SID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Discussion_GID",
                table: "Discussion",
                column: "GID");

            migrationBuilder.CreateIndex(
                name: "IX_Discussion_MID",
                table: "Discussion",
                column: "MID");

            migrationBuilder.CreateIndex(
                name: "IX_Discussion_SID",
                table: "Discussion",
                column: "SID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Discussion");
        }
    }
}
