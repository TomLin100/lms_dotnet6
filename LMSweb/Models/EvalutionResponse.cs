using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMSweb.Models
{
    public class EvalutionResponse
    {
        [Key]
        public int RID { get; set; }
        public int DQID { get; set; }
        [ForeignKey("DQID")]
        public virtual DefaultQuestion DefaultQuestion { get; set; }

        public string Answer { get; set; }   //1~5分
        public string SID { get; set; }
        [ForeignKey("SID")]
        public virtual Student Student { get; set; }

        public string EvaluatorSID { get; set; }
        public string MID { get; set; }
        [ForeignKey("MID")]
        public virtual Mission Mission { get; set; }
        public string CID { get; set; }
        [ForeignKey("CID")]
        public virtual Course Course { get; set; }
    }
}