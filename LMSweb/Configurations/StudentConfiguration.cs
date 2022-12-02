using LMSweb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LMSweb.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Student");
            builder.HasData(
                new Student {
                    SID = "S001",
                    Password = "S001",
                    SName = "測試學生1",
                    Sex = "男"
                },
                new Student {
                    SID = "S002",
                    Password = "S002",
                    SName = "測試學生2",
                    Sex = "男"
                },
                new Student {
                    SID = "S003",
                    Password = "S003",
                    SName = "測試學生3",
                    Sex = "女"
                },
                new Student {
                    SID = "S004",
                    Password = "S004",
                    SName = "測試學生4",
                    Sex = "女"
                }
            );
        }
    }
}
