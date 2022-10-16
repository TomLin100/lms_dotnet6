using System.ComponentModel.DataAnnotations;

namespace LMSweb.Models
{
    public class EvalutionResponse
    {
        [Key]
        public int RID { get; set; }
        public int DQID { get; set; }
        public virtual DefaultQuestion DefaultQuestion { get; set; }

        public string Answer { get; set; }   //1~5分
        public string SID { get; set; }
        public virtual Student Student { get; set; }

        public string EvaluatorSID { get; set; }
        public string MID { get; set; }

        public virtual Mission mission { get; set; }
        public string CID { get; set; }
        public virtual Course Course { get; set; }
    }
}