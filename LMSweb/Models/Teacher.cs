using System.ComponentModel.DataAnnotations;

namespace LMSweb.Models
{
    public class Teacher
    {
        public Teacher()
        {
            Courses = new HashSet<Course>();
        }

        [Key]
        [Required]
        [Display(Name = "教師編號")]
        public string TID { get; set; }

        [Required]
        [Display(Name = "教師姓名")]
        public string TName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "密碼")]
        public string TPassword { get; set; }

        [EmailAddress]
        [Required]
        [Display(Name = "EMail")]
        public string Email { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}