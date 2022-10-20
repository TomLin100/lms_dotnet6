using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMSweb.Models
{
    public class StudentMission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SMID {get; set;}
        public string SID { get; set; }
        public string MID { get; set; }
        public int TEID { get; set; }

        public int total_score { get; set; }

        [Display(Name = "個人貢獻度分數")]
        public int PersonalScore { get; set; }

        [Display(Name = "自我評價")]
        public int SelfA { get; set; }

        [ForeignKey("SID")]
        public virtual Student Student { get; set; }

        [ForeignKey("MID")]
        public virtual Mission Mission { get; set; }

        [ForeignKey("TEID")]
        public virtual TeacherAssessment TeacherAssessment { get; set; }
        public virtual ICollection<PeerAssessment> PeerAssessments { get; set; }
    }
}