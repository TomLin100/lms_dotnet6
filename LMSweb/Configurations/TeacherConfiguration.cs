using LMSweb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LMSweb.Configurations;

public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
{
    public void Configure(EntityTypeBuilder<Teacher> builder)
    {
        builder.ToTable("Teacher");
        builder.HasData(
            new Teacher {
                TID = "T001",
                Password = "T001",
                TName = "測試教師1"
            },
            new Teacher {
                TID = "T002",
                Password = "T002",
                TName = "測試教師2"
            }
        );
    }
}
