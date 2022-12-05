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
    
    public LMSmodel(DbContextOptions<LMSmodel> option): base(option)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new StudentConfiguration());
        modelBuilder.ApplyConfiguration(new TeacherConfiguration());
    }
}
