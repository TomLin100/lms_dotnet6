using System.ComponentModel.DataAnnotations;

namespace LMSweb.Models
{
    [MetadataType(typeof(TeacherAssessment))]
    public class TeacherAssessment
    {
        [Key]
        [Display(Name = "編號")]
        public int TEID { get; set; }

        [Required]
        [Display(Name = "教師評語")]
        public string TeacherA { get; set; }

        [Required]
        [Display(Name = "小組成果分數")]
        public int GroupAchievementScore { get; set; }

        public int GID { get; set; }
        public virtual Group Group { get; set; }
            
        public string MID { get; set; }
        public virtual Mission Mission { get; set; }

        public string CID { get; set; }
        public virtual Course Course { get; set; }
        public virtual ICollection<StudentMission> StudentMissions { get; set; }        
    }
}