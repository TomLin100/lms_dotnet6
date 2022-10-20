using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMSweb.Models
{
    public class LearningBehavior
    {
        [Key]
        [Display(Name = "編號")]
        public int ID { get; set; }
        public string CID { get; set; }        
        public string MID { get; set; }
        public int GID { get; set; }
        public string SID { get; set; }

        [Required]
        [Display(Name = "動作類型")]
        public string ActionType { get; set; }

        [Required]
        [Display(Name = "動作子項")]
        public string SubAction { get; set; }

        [Required]
        [Display(Name = "動作內容")]
        public string Detail { get; set; }

        public string Time { get; set; }

        [ForeignKey("GID")]
        public virtual Group Group { get; set; }

        [ForeignKey("SID")]
        public virtual Student Student { get; set; }

        
        [ForeignKey("MID")]
        public virtual Mission Mission { get; set; }

        [ForeignKey("CID")]
        public virtual Course Course { get; set; }
    }
}