using System.ComponentModel.DataAnnotations;

namespace LMSweb.Models;

public class DefaultQuestion
{
    [Key]
    public int DQID { get; set; }
    [Required]
    public string Type { get; set; }
    [Required]
    public string Description { get; set; }

    [Required]
    public string Property { get; set; }
    public virtual ICollection<DefaultOption> DefaultOptions { get; set; }
    public virtual ICollection<GoalSettingResponse> GoalSettingResponses { get; set; }
    public virtual ICollection<TeacherEvaluationResponse> TeacherEvaluationResponses { get; set; }
}
