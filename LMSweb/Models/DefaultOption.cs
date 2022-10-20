using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMSweb.Models
{
    public class DefaultOption
    {
        [Key]
        public int DOID { get; set; }
        public int DQID { get; set; }
        [ForeignKey("DQID")]
        public virtual DefaultQuestion DefaultQuestion { get; set; }

        [Display(Name = "作答")]
        public string DOptions { get; set; }
    }
}