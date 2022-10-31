using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMSweb.Models
{
    public class GroupER
    {
        [Key]
        public int RID { get; set; }
        public string EvaluatorSID { get; set; }
        public string Answer { get; set; }   //1~5分
        public string Comments { get; set; }

        [ForeignKey("MID")]
        public string MID { get; set; }
        public virtual Mission Mission { get; set; }
        
        [ForeignKey("CID")]
        public virtual Course Course { get; set; }

        [ForeignKey("GQID")]
        public virtual GroupQuestion GroupQuestion { get; set; }

        [ForeignKey("GID")]
        public virtual Group Group { get; set; }
    }
}