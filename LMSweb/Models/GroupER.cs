using System.ComponentModel.DataAnnotations;

namespace LMSweb.Models
{
    public class GroupER
    {
        [Key]
        public int RID { get; set; }
        public int GQID { get; set; }
        public virtual GroupQuestion GroupQuestion { get; set; }

        public string Answer { get; set; }   //1~5分
        public string Comments { get; set; }
        public int GID { get; set; }
        public virtual Group Group { get; set; }
        public string EvaluatorSID { get; set; }
        public string MID { get; set; }
        public virtual Mission mission { get; set; }
        public string CID { get; set; }
        public virtual Course Course { get; set; }
    }
}