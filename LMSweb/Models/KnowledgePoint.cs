using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMSweb.Models;
public class KnowledgePoint
{
    [Key]
    public int KPID { get; set; }
    public string KPContent { get; set; }    
    public string CID { get; set; }
    [ForeignKey("CID")]
    public Course Course { get; set; }
}