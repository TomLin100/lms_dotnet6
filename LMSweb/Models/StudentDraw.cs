using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMSweb.Models
{
    public class StudentDraw
    {
        [Key]
        [Display(Name ="流程圖編號")]
        public int Id { get; set; }
        public string DrawingImgPath { get; set; }
        [ForeignKey("GID")]
        public virtual Group Group { get; set; }

        [ForeignKey("MID")]
        public virtual Mission Mission { get; set; }

        [ForeignKey("CID")]
        public virtual Course Course { get; set; }
    }
}