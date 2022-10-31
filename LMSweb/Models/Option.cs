using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMSweb.Models
{
    public class Option
    {
        [Key]
        public int OID { get; set; }
        [ForeignKey("QID")]
        public virtual Question Question { get; set; }

        [Display(Name = "選項")]
        public string OptionName { get; set; }
    }
}