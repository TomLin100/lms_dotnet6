using System.ComponentModel.DataAnnotations;

namespace LMSweb.Models
{
    public class KnowledgePoint
    {
        [Key]
        [Display(Name = "編號")]
        public int KID { get; set; }

        [Required]
        public string CID { get; set; }

        [Required]
        [Display(Name = "知識點")]
        public string KContent { get; set; }

        public virtual Course Courses { get; set; }

    }
}