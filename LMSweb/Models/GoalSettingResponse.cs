using System.ComponentModel.DataAnnotations;

namespace LMSweb.Models;

public class GoalSettingResponse //目標設置答覆
{
    [Key]
    public int GSRID { get; set; }
    public int DQID { get; set; }
    public string SID { get; set; }
    public string CID { get; set; }
    public string MID { get; set; }
    public string  Answer { get; set; }
}
