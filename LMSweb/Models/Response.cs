using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMSweb.Models
{
    [MetadataType(typeof(Response))]
    public class Response
    {
        [Key]
        public int RID { get; set; }
        public string Answer { get; set;}
        public virtual Student Student { get; set; }
        public virtual Mission Mission { get; set; }
       
        [ForeignKey("CID")]
        public virtual Course Course { get; set; }

        [ForeignKey("DQID")]
        public virtual DefaultQuestion DefaultQuestion { get; set; }
    }
}