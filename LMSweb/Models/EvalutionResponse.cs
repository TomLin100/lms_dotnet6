using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMSweb.Models
{
    public class EvalutionResponse
    {
        [Key]
        public int RID { get; set; }
        public string Answer { get; set; }   //1~5分
        public string EvaluatorSID { get; set; }
        public virtual Student Student { get; set; }
        public virtual Mission Mission { get; set; }

        [ForeignKey("CID")]
        public virtual Course Course { get; set; }
        
        [ForeignKey("DQID")]
        public virtual DefaultQuestion DefaultQuestion { get; set; }
    }
}