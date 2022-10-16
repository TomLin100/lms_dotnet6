using Microsoft.EntityFrameworkCore;

namespace LMSweb.Models;
public class LMSmodel : DbContext
{
    public LMSmodel(DbContextOptions<LMSmodel> option): base(option)
    {
    }

    public virtual DbSet<Teacher> Teachers { get; set; }
    public virtual DbSet<Course> Courses { get; set; }
    public virtual DbSet<Group> Groups { get; set; }
    public virtual DbSet<KnowledgePoint> KnowledgePoints { get; set; }
    public virtual DbSet<LearningBehavior> LearnB { get; set; }
    public virtual DbSet<Mission> Missions { get; set; }
    public virtual DbSet<PeerAssessment> PeerA { get; set; }
    public virtual DbSet<EvalutionResponse> EvalutionResponse { get; set; }
    public virtual DbSet<Student> Students { get; set; }
    public virtual DbSet<StudentMission> StudentMissions { get; set; }
    public virtual DbSet<TeacherAssessment> TeacherA { get; set; }
    public virtual DbSet<StudentCode> StudentCodes { get; set; }
    public virtual DbSet<StudentDraw> StudentDraws { get; set; }
    public virtual DbSet<Question> Questions { get; set; }
    public virtual DbSet<Option> Options { get; set;}
    public virtual DbSet<DefaultQuestion> DefaultQuestions { get; set; }
    public virtual DbSet<DefaultOption> DefaultOptions { get; set; }
    public virtual DbSet<Response> Responses { get; set; }
    public virtual DbSet<GroupQuestion> GroupQuestions { get; set; }
    public virtual DbSet<GroupOption> GroupOptions { get; set; }
    public virtual DbSet<GroupER> GroupERs { get; set; }
}