using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMSweb.Models
{
    public class KnowledgePoint
    {
        [Key]
        [Display(Name = "編號")]
        public int KID { get; set; }

        [Required]
        [Display(Name = "知識點")]
        public string KContent { get; set; }

        [ForeignKey("CID")]
        public virtual Course Courses { get; set; }

    }
}