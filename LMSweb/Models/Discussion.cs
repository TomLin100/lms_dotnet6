using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMSweb.Models;

public class Discussion
{
    [Key]
    public int DisID { get; set; }
    public string SID { get; set; }
    public string GID { get; set; }
    public string MID { get; set; }
    public string Detail { get; set; }
    public string DiscussionTime { get; set; }

    [ForeignKey("SID")]
    public virtual Student Student { get; set; }
    [ForeignKey("MID")]
    public virtual Mission Mission { get; set; }
    [ForeignKey("GID")]
    public virtual Group Group { get; set; }
}
