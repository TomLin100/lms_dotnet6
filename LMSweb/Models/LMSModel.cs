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
    public virtual DbSet<LearningBehavior> LearningBehaviors { get; set; }
    public virtual DbSet<Mission> Missions { get; set; }
    public virtual DbSet<PeerAssessment> PeerAssessments { get; set; }
    public virtual DbSet<EvalutionResponse> EvalutionResponse { get; set; }
    public virtual DbSet<Student> Students { get; set; }
    public virtual DbSet<StudentMission> StudentMissions { get; set; }
    public virtual DbSet<TeacherAssessment> TeacherAssessments { get; set; }
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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Mission
            modelBuilder.Entity<Mission>()
                        .HasMany(m => m.LearningBehaviors)
                        .WithOne(o=>o.Mission)
                        .HasForeignKey("MID")
                        .HasPrincipalKey(k=>k.MID)
                        .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Mission>()
                        .HasMany(m => m.EvalutionResponse)
                        .WithOne(o=>o.Mission)
                        .HasForeignKey("MID")
                        .HasPrincipalKey(k=>k.MID)
                        .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Mission>()
                        .HasMany(m => m.Responses)
                        .WithOne(o=>o.Mission)
                        .HasForeignKey("MID")
                        .HasPrincipalKey(k=>k.MID)
                        .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Mission>()
                        .HasMany(m => m.StudentMissions)
                        .WithOne(o=>o.Mission)
                        .HasForeignKey("MID")
                        .HasPrincipalKey(k=>k.MID)
                        .OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region Student
            modelBuilder.Entity<Student>()
                        .HasMany(m=>m.LearningBehaviors)
                        .WithOne(o=>o.Student)
                        .HasForeignKey("SID")
                        .HasPrincipalKey(k=>k.SID)
                        .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Student>()
                        .HasMany(m=>m.EvalutionResponses)
                        .WithOne(o=>o.Student)
                        .HasForeignKey("SID")
                        .HasPrincipalKey(k=>k.SID)
                        .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Student>()
                        .HasMany(m=>m.Responses)
                        .WithOne(o=>o.Student)
                        .HasForeignKey("SID")
                        .HasPrincipalKey(k=>k.SID)
                        .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Student>()
                        .HasMany<StudentMission>(m=>m.StudentMissions)
                        .WithOne(o=>o.Student)
                        .HasForeignKey("SID")
                        .HasPrincipalKey(k=>k.SID)
                        .OnDelete(DeleteBehavior.NoAction);
        #endregion
    }
}