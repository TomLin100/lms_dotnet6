using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMSweb.Models
{
    public class GroupOption
    {
        [Key]
        public int GOID { get; set; }
        public int GQID { get; set; }
        public string OptionNum { get; set; }

        [ForeignKey("GQID")]
        public virtual GroupQuestion GroupQuestion { get; set; }
    }
}