using System.ComponentModel.DataAnnotations;

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

        public string MID { get; set; }
        public string CID { get; set; }
        public virtual Course Course { get; set; }

        public int SMID {get; set;}
        public virtual StudentMission StudentMissions { get; set; }

    }
}