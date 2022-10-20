using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMSweb.Models
{
    [MetadataType(typeof(Response))]
    public class Response
    {
        [Key]
        public int RID { get; set; }
        public int DQID { get; set; }
        public string CID { get; set; }
        public string SID { get; set; }
        public string MID { get; set; }
        public string Answer { get; set;}

        [ForeignKey("SID")]
        public virtual Student Student { get; set; }

        [ForeignKey("MID")]
        public virtual Mission Mission { get; set; }
       
        [ForeignKey("CID")]
        public virtual Course Course { get; set; }

        [ForeignKey("DQID")]
        public virtual DefaultQuestion DefaultQuestion { get; set; }
    }
}