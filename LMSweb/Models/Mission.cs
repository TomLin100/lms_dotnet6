using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMSweb.Models;
public class Mission
{
    [Key]
    public string MID { get; set; } // 任務編號
    public string MName { get; set; } // 任務名稱
    public string MDetail { get; set; } // 任務內容
    public string MStart { get; set; } // 任務開始時間
    public string MEnd { get; set; } // 任務結束時間
    public string RelateKP { get; set; } // 相關知識點
    public bool IsDrawing { get; set; } // 是否開放繪製流程圖
    public bool IsCoding { get; set; } // 是否開放撰寫程式碼
    public bool IsDiscuss { get; set; } // 是否開放討論
    public bool IsAssess { get; set; } // 是否開放自評與互評
    public bool IsGoalSetting { get; set; } // 是否開放目標設置
    public bool IsReflect { get; set; } // 是否開放自我反思
    public bool IsGReflect { get; set; } // 是否開放組間互評
    public bool IsJourney { get; set; } // 是否開放學習表現(互評版)
    public string CID { get; set; }
    [ForeignKey("CID")]
    public Course Course { get; set; }
}