using LMSweb.Configurations;
using Microsoft.EntityFrameworkCore;

namespace LMSweb.Models;
public class LMSmodel : DbContext
{
    public virtual DbSet<Student> Students { get; set; }
    public virtual DbSet<Teacher> Teachers { get; set; }
    public virtual DbSet<Course> Courses { get; set; }
    public virtual DbSet<Group> Groups { get; set; }
    public virtual DbSet<Mission> Missions { get; set; }
    public virtual DbSet<KnowledgePoint> KnowledgePoints { get; set; }
    public virtual DbSet<DefaultQuestion> DefaultQuestions { get; set; }
    public virtual DbSet<DefaultOption> DefaultOptions { get; set; }
    public virtual DbSet<GoalSettingResponse> GoalSettingResponses { get; set; }
    public virtual DbSet<TeacherEvaluationResponse> TeacherEvaluationResponses { get; set; }
    
    public LMSmodel(DbContextOptions<LMSmodel> option): base(option)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new StudentConfiguration());
        modelBuilder.ApplyConfiguration(new TeacherConfiguration());
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=localhost;database=LMSmodel;User ID=sa;Password=Tom@che100100");
    }
}
