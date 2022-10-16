using System.ComponentModel.DataAnnotations;

namespace LMSweb.Models
{
    public class Group
    {
        [Key]
        [Display(Name = "組別編號")]
        public int GID { get; set; }
 
        [Required]
        [Display(Name = "組別名稱")]
        public string GName { get; set; }

        public string CID { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<TeacherAssessment> TeacherA { get; set; }
        public virtual ICollection<PeerAssessment> PeerAssessments{ get; set; }
        public virtual ICollection<StudentCode> StudentCode { get; set; }
    }
}