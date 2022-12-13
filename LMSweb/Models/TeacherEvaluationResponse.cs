using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMSweb.Models;

public class TeacherEvaluationResponse //教師評價答覆
{
    [Key]
    public int TERID { get; set; }
    public int DQID { get; set; }
    public string MID { get; set; }
    public string GID { get; set; }
    public string Answer { get; set; } //答覆內容
    [ForeignKey("DQID")]
    public DefaultQuestion DefaultQuestion { get; set; }
    [ForeignKey("MID")]
    public Mission Mission { get; set; }
    [ForeignKey("GID")]
    public Group Group { get; set; }
}
