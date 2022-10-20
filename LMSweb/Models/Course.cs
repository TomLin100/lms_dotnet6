using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMSweb.Models
{
    public class Course
    {

        [Key]
        [Display(Name = "課程編號")]
        public string CID { get; set; }

        [Required]
        public string TID { get; set; } //外部鍵

        [Required]
        [Display(Name = "課程名稱")]
        public string CName { get; set; }

        [Display(Name = "是否加入後設認知")]
        public bool IsAddMetacognition { get; set; }

        [Display(Name = "是否加入同儕互評")]
        public bool IsAddPeerAssessmemt { get; set; }

        public string CreateTime { get; set; }

        
        [ForeignKey("TID")]
        public virtual Teacher teacher { get; set; } //外部鍵

        public virtual ICollection<Mission> Missions { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<LearningBehavior> LearningBehaviors { get; set; }
        public virtual ICollection<KnowledgePoint> KnowledgePoints { get; set; }
        public virtual ICollection<StudentCode> StudentCode { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}