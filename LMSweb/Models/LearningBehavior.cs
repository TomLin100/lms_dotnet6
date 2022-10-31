using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMSweb.Models
{
    public class LearningBehavior
    {
        [Key]
        [Display(Name = "編號")]
        public int ID { get; set; }

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

        public virtual Student Student { get; set; }

        public virtual Mission Mission { get; set; }

        [ForeignKey("CID")]
        public virtual Course Course { get; set; }
    }
}