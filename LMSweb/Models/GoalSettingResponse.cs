using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMSweb.Models;

public class GoalSettingResponse //目標設置答覆
{
    [Key]
    public int GSRID { get; set; }
    public int DQID { get; set; }
    public string SID { get; set; }
    public string MID { get; set; }
    public string  Answer { get; set; }
    [ForeignKey("DQID")]
    public DefaultQuestion DefaultQuestion { get; set; }
    [ForeignKey("SID")]
    public Student Student { get; set; }
    [ForeignKey("MID")]
    public Mission Mission { get; set; }
}
