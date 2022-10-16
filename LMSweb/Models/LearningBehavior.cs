using System.ComponentModel.DataAnnotations;

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
        public string subAction { get; set; }

        [Required]
        [Display(Name = "動作內容")]
        public string Detail { get; set; }

        public string Time { get; set; }
        public virtual Group group { get; set; }
        public virtual Student student { get; set; }
        public virtual Mission mission { get; set; }
        public virtual Course course { get; set; }
    }
}