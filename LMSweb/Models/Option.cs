using System.ComponentModel.DataAnnotations;

namespace LMSweb.Models
{
    public class Option
    {
        [Key]
        public int OID { get; set; }
        public int QID { get; set; }

        public virtual Question Question { get; set; }

        [Display(Name = "選項")]
        public string OptionName { get; set; }
    }
}