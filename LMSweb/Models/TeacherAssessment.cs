using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [ForeignKey("GID")]
        public virtual Group Group { get; set; }
            
        public string MID { get; set; }
        [ForeignKey("MID")]
        public virtual Mission Mission { get; set; }

        public string CID { get; set; }
        [ForeignKey("CID")]
        public virtual Course Course { get; set; }
        public virtual ICollection<StudentMission> StudentMissions { get; set; }        
    }
}