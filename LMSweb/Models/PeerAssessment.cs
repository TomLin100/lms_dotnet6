using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMSweb.Models
{
    public class PeerAssessment
    {
        [Key]
        [Display(Name = "編號")]
        public int PEID { get; set; }

        [Required]
        [Display(Name = "評語")]
        public string PeerA { get; set; }

        [Display(Name = "互動合作分數")]
        public int CooperationScore { get; set; }

        [Required]
        [Display(Name = "被評價學生")]
        public string AssessedSID { get; set; }

        [ForeignKey("MID")]
        public virtual Mission Mission { get; set; }
    
        [ForeignKey("CID")]
        public virtual Course Course { get; set; }

        [ForeignKey("SMID")]
        public virtual StudentMission StudentMissions { get; set; }
    }
}