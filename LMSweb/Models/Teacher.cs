using System.ComponentModel.DataAnnotations;

namespace LMSweb.Models;
public class Teacher
{
    [Key]
    public string TID { get; set; }
    public string Password { get; set; }
    public string TName { get; set; }
    public ICollection<Course> Courses { get; set; }
}