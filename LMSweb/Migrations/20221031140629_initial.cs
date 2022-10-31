using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMSweb.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DefaultQuestions",
                columns: table => new
                {
                    DQID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefaultQuestions", x => x.DQID);
                });

            migrationBuilder.CreateTable(
                name: "GroupQuestions",
                columns: table => new
                {
                    GQID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupQuestions", x => x.GQID);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    GID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CID = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    TName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.TID);
                });

            migrationBuilder.CreateTable(
                name: "DefaultOptions",
                columns: table => new
                {
                    DOID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DQID = table.Column<int>(type: "int", nullable: false),
                    DOptions = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                name: "GroupOptions",
                columns: table => new
                {
                    GOID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OptionNum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GQID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupOptions", x => x.GOID);
                    table.ForeignKey(
                        name: "FK_GroupOptions_GroupQuestions_GQID",
                        column: x => x.GQID,
                        principalTable: "GroupQuestions",
                        principalColumn: "GQID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAddMetacognition = table.Column<bool>(type: "bit", nullable: false),
                    IsAddPeerAssessmemt = table.Column<bool>(type: "bit", nullable: false),
                    CreateTime = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    KID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KnowledgePoints", x => x.KID);
                    table.ForeignKey(
                        name: "FK_KnowledgePoints_Courses_CID",
                        column: x => x.CID,
                        principalTable: "Courses",
                        principalColumn: "CID");
                });

            migrationBuilder.CreateTable(
                name: "Missions",
                columns: table => new
                {
                    MID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MDetail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Start = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    End = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsGoalSetting = table.Column<bool>(type: "bit", nullable: false),
                    IsDrawing = table.Column<bool>(type: "bit", nullable: false),
                    IsCoding = table.Column<bool>(type: "bit", nullable: false),
                    IsDiscuss = table.Column<bool>(type: "bit", nullable: false),
                    IsAssess = table.Column<bool>(type: "bit", nullable: false),
                    IsGReflect = table.Column<bool>(type: "bit", nullable: false),
                    IsReflect = table.Column<bool>(type: "bit", nullable: false),
                    Is_Journey = table.Column<bool>(type: "bit", nullable: false),
                    relatedKP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Missions", x => x.MID);
                    table.ForeignKey(
                        name: "FK_Missions_Courses_CID",
                        column: x => x.CID,
                        principalTable: "Courses",
                        principalColumn: "CID");
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    SID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GID = table.Column<int>(type: "int", nullable: false),
                    CID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.SID);
                    table.ForeignKey(
                        name: "FK_Students_Courses_CID",
                        column: x => x.CID,
                        principalTable: "Courses",
                        principalColumn: "CID");
                    table.ForeignKey(
                        name: "FK_Students_Groups_GID",
                        column: x => x.GID,
                        principalTable: "Groups",
                        principalColumn: "GID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupERs",
                columns: table => new
                {
                    RID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EvaluatorSID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MissionMID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    GQID = table.Column<int>(type: "int", nullable: false),
                    GID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupERs", x => x.RID);
                    table.ForeignKey(
                        name: "FK_GroupERs_Courses_CID",
                        column: x => x.CID,
                        principalTable: "Courses",
                        principalColumn: "CID");
                    table.ForeignKey(
                        name: "FK_GroupERs_GroupQuestions_GQID",
                        column: x => x.GQID,
                        principalTable: "GroupQuestions",
                        principalColumn: "GQID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupERs_Groups_GID",
                        column: x => x.GID,
                        principalTable: "Groups",
                        principalColumn: "GID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupERs_Missions_MissionMID",
                        column: x => x.MissionMID,
                        principalTable: "Missions",
                        principalColumn: "MID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QID);
                    table.ForeignKey(
                        name: "FK_Questions_Courses_CID",
                        column: x => x.CID,
                        principalTable: "Courses",
                        principalColumn: "CID");
                    table.ForeignKey(
                        name: "FK_Questions_Missions_MID",
                        column: x => x.MID,
                        principalTable: "Missions",
                        principalColumn: "MID");
                });

            migrationBuilder.CreateTable(
                name: "StudentCodes",
                columns: table => new
                {
                    SCID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    GID = table.Column<int>(type: "int", nullable: false),
                    CodePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsEdit = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCodes", x => x.SCID);
                    table.ForeignKey(
                        name: "FK_StudentCodes_Courses_CID",
                        column: x => x.CID,
                        principalTable: "Courses",
                        principalColumn: "CID");
                    table.ForeignKey(
                        name: "FK_StudentCodes_Groups_GID",
                        column: x => x.GID,
                        principalTable: "Groups",
                        principalColumn: "GID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentCodes_Missions_MID",
                        column: x => x.MID,
                        principalTable: "Missions",
                        principalColumn: "MID");
                });

            migrationBuilder.CreateTable(
                name: "StudentDraws",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DrawingImgPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GID = table.Column<int>(type: "int", nullable: false),
                    MID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentDraws", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentDraws_Courses_CID",
                        column: x => x.CID,
                        principalTable: "Courses",
                        principalColumn: "CID");
                    table.ForeignKey(
                        name: "FK_StudentDraws_Groups_GID",
                        column: x => x.GID,
                        principalTable: "Groups",
                        principalColumn: "GID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentDraws_Missions_MID",
                        column: x => x.MID,
                        principalTable: "Missions",
                        principalColumn: "MID");
                });

            migrationBuilder.CreateTable(
                name: "TeacherAssessments",
                columns: table => new
                {
                    TEID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroupAchievementScore = table.Column<int>(type: "int", nullable: false),
                    GID = table.Column<int>(type: "int", nullable: false),
                    MID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherAssessments", x => x.TEID);
                    table.ForeignKey(
                        name: "FK_TeacherAssessments_Courses_CID",
                        column: x => x.CID,
                        principalTable: "Courses",
                        principalColumn: "CID");
                    table.ForeignKey(
                        name: "FK_TeacherAssessments_Groups_GID",
                        column: x => x.GID,
                        principalTable: "Groups",
                        principalColumn: "GID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherAssessments_Missions_MID",
                        column: x => x.MID,
                        principalTable: "Missions",
                        principalColumn: "MID");
                });

            migrationBuilder.CreateTable(
                name: "EvalutionResponse",
                columns: table => new
                {
                    RID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EvaluatorSID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DQID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvalutionResponse", x => x.RID);
                    table.ForeignKey(
                        name: "FK_EvalutionResponse_Courses_CID",
                        column: x => x.CID,
                        principalTable: "Courses",
                        principalColumn: "CID");
                    table.ForeignKey(
                        name: "FK_EvalutionResponse_DefaultQuestions_DQID",
                        column: x => x.DQID,
                        principalTable: "DefaultQuestions",
                        principalColumn: "DQID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EvalutionResponse_Missions_MID",
                        column: x => x.MID,
                        principalTable: "Missions",
                        principalColumn: "MID");
                    table.ForeignKey(
                        name: "FK_EvalutionResponse_Students_SID",
                        column: x => x.SID,
                        principalTable: "Students",
                        principalColumn: "SID");
                });

            migrationBuilder.CreateTable(
                name: "LearningBehaviors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubAction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GID = table.Column<int>(type: "int", nullable: false),
                    SID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LearningBehaviors", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LearningBehaviors_Courses_CID",
                        column: x => x.CID,
                        principalTable: "Courses",
                        principalColumn: "CID");
                    table.ForeignKey(
                        name: "FK_LearningBehaviors_Groups_GID",
                        column: x => x.GID,
                        principalTable: "Groups",
                        principalColumn: "GID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LearningBehaviors_Missions_MID",
                        column: x => x.MID,
                        principalTable: "Missions",
                        principalColumn: "MID");
                    table.ForeignKey(
                        name: "FK_LearningBehaviors_Students_SID",
                        column: x => x.SID,
                        principalTable: "Students",
                        principalColumn: "SID");
                });

            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    RID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DQID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.RID);
                    table.ForeignKey(
                        name: "FK_Responses_Courses_CID",
                        column: x => x.CID,
                        principalTable: "Courses",
                        principalColumn: "CID");
                    table.ForeignKey(
                        name: "FK_Responses_DefaultQuestions_DQID",
                        column: x => x.DQID,
                        principalTable: "DefaultQuestions",
                        principalColumn: "DQID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Responses_Missions_MID",
                        column: x => x.MID,
                        principalTable: "Missions",
                        principalColumn: "MID");
                    table.ForeignKey(
                        name: "FK_Responses_Students_SID",
                        column: x => x.SID,
                        principalTable: "Students",
                        principalColumn: "SID");
                });

            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    OID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QID = table.Column<int>(type: "int", nullable: false),
                    OptionName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.OID);
                    table.ForeignKey(
                        name: "FK_Options_Questions_QID",
                        column: x => x.QID,
                        principalTable: "Questions",
                        principalColumn: "QID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentMissions",
                columns: table => new
                {
                    SMID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    total_score = table.Column<int>(type: "int", nullable: false),
                    PersonalScore = table.Column<int>(type: "int", nullable: false),
                    SelfA = table.Column<int>(type: "int", nullable: false),
                    SID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TEID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentMissions", x => x.SMID);
                    table.ForeignKey(
                        name: "FK_StudentMissions_Missions_MID",
                        column: x => x.MID,
                        principalTable: "Missions",
                        principalColumn: "MID");
                    table.ForeignKey(
                        name: "FK_StudentMissions_Students_SID",
                        column: x => x.SID,
                        principalTable: "Students",
                        principalColumn: "SID");
                    table.ForeignKey(
                        name: "FK_StudentMissions_TeacherAssessments_TEID",
                        column: x => x.TEID,
                        principalTable: "TeacherAssessments",
                        principalColumn: "TEID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PeerAssessments",
                columns: table => new
                {
                    PEID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PeerA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CooperationScore = table.Column<int>(type: "int", nullable: false),
                    AssessedSID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SMID = table.Column<int>(type: "int", nullable: false),
                    GroupGID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeerAssessments", x => x.PEID);
                    table.ForeignKey(
                        name: "FK_PeerAssessments_Courses_CID",
                        column: x => x.CID,
                        principalTable: "Courses",
                        principalColumn: "CID");
                    table.ForeignKey(
                        name: "FK_PeerAssessments_Groups_GroupGID",
                        column: x => x.GroupGID,
                        principalTable: "Groups",
                        principalColumn: "GID");
                    table.ForeignKey(
                        name: "FK_PeerAssessments_Missions_MID",
                        column: x => x.MID,
                        principalTable: "Missions",
                        principalColumn: "MID");
                    table.ForeignKey(
                        name: "FK_PeerAssessments_StudentMissions_SMID",
                        column: x => x.SMID,
                        principalTable: "StudentMissions",
                        principalColumn: "SMID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TID",
                table: "Courses",
                column: "TID");

            migrationBuilder.CreateIndex(
                name: "IX_DefaultOptions_DQID",
                table: "DefaultOptions",
                column: "DQID");

            migrationBuilder.CreateIndex(
                name: "IX_EvalutionResponse_CID",
                table: "EvalutionResponse",
                column: "CID");

            migrationBuilder.CreateIndex(
                name: "IX_EvalutionResponse_DQID",
                table: "EvalutionResponse",
                column: "DQID");

            migrationBuilder.CreateIndex(
                name: "IX_EvalutionResponse_MID",
                table: "EvalutionResponse",
                column: "MID");

            migrationBuilder.CreateIndex(
                name: "IX_EvalutionResponse_SID",
                table: "EvalutionResponse",
                column: "SID");

            migrationBuilder.CreateIndex(
                name: "IX_GroupERs_CID",
                table: "GroupERs",
                column: "CID");

            migrationBuilder.CreateIndex(
                name: "IX_GroupERs_GID",
                table: "GroupERs",
                column: "GID");

            migrationBuilder.CreateIndex(
                name: "IX_GroupERs_GQID",
                table: "GroupERs",
                column: "GQID");

            migrationBuilder.CreateIndex(
                name: "IX_GroupERs_MissionMID",
                table: "GroupERs",
                column: "MissionMID");

            migrationBuilder.CreateIndex(
                name: "IX_GroupOptions_GQID",
                table: "GroupOptions",
                column: "GQID");

            migrationBuilder.CreateIndex(
                name: "IX_KnowledgePoints_CID",
                table: "KnowledgePoints",
                column: "CID");

            migrationBuilder.CreateIndex(
                name: "IX_LearningBehaviors_CID",
                table: "LearningBehaviors",
                column: "CID");

            migrationBuilder.CreateIndex(
                name: "IX_LearningBehaviors_GID",
                table: "LearningBehaviors",
                column: "GID");

            migrationBuilder.CreateIndex(
                name: "IX_LearningBehaviors_MID",
                table: "LearningBehaviors",
                column: "MID");

            migrationBuilder.CreateIndex(
                name: "IX_LearningBehaviors_SID",
                table: "LearningBehaviors",
                column: "SID");

            migrationBuilder.CreateIndex(
                name: "IX_Missions_CID",
                table: "Missions",
                column: "CID");

            migrationBuilder.CreateIndex(
                name: "IX_Options_QID",
                table: "Options",
                column: "QID");

            migrationBuilder.CreateIndex(
                name: "IX_PeerAssessments_CID",
                table: "PeerAssessments",
                column: "CID");

            migrationBuilder.CreateIndex(
                name: "IX_PeerAssessments_GroupGID",
                table: "PeerAssessments",
                column: "GroupGID");

            migrationBuilder.CreateIndex(
                name: "IX_PeerAssessments_MID",
                table: "PeerAssessments",
                column: "MID");

            migrationBuilder.CreateIndex(
                name: "IX_PeerAssessments_SMID",
                table: "PeerAssessments",
                column: "SMID");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_CID",
                table: "Questions",
                column: "CID");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_MID",
                table: "Questions",
                column: "MID");

            migrationBuilder.CreateIndex(
                name: "IX_Responses_CID",
                table: "Responses",
                column: "CID");

            migrationBuilder.CreateIndex(
                name: "IX_Responses_DQID",
                table: "Responses",
                column: "DQID");

            migrationBuilder.CreateIndex(
                name: "IX_Responses_MID",
                table: "Responses",
                column: "MID");

            migrationBuilder.CreateIndex(
                name: "IX_Responses_SID",
                table: "Responses",
                column: "SID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCodes_CID",
                table: "StudentCodes",
                column: "CID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCodes_GID",
                table: "StudentCodes",
                column: "GID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCodes_MID",
                table: "StudentCodes",
                column: "MID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentDraws_CID",
                table: "StudentDraws",
                column: "CID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentDraws_GID",
                table: "StudentDraws",
                column: "GID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentDraws_MID",
                table: "StudentDraws",
                column: "MID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentMissions_MID",
                table: "StudentMissions",
                column: "MID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentMissions_SID",
                table: "StudentMissions",
                column: "SID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentMissions_TEID",
                table: "StudentMissions",
                column: "TEID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_CID",
                table: "Students",
                column: "CID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_GID",
                table: "Students",
                column: "GID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherAssessments_CID",
                table: "TeacherAssessments",
                column: "CID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherAssessments_GID",
                table: "TeacherAssessments",
                column: "GID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherAssessments_MID",
                table: "TeacherAssessments",
                column: "MID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DefaultOptions");

            migrationBuilder.DropTable(
                name: "EvalutionResponse");

            migrationBuilder.DropTable(
                name: "GroupERs");

            migrationBuilder.DropTable(
                name: "GroupOptions");

            migrationBuilder.DropTable(
                name: "KnowledgePoints");

            migrationBuilder.DropTable(
                name: "LearningBehaviors");

            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "PeerAssessments");

            migrationBuilder.DropTable(
                name: "Responses");

            migrationBuilder.DropTable(
                name: "StudentCodes");

            migrationBuilder.DropTable(
                name: "StudentDraws");

            migrationBuilder.DropTable(
                name: "GroupQuestions");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "StudentMissions");

            migrationBuilder.DropTable(
                name: "DefaultQuestions");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "TeacherAssessments");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Missions");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
