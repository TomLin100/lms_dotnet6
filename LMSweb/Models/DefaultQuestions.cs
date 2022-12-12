using System.ComponentModel.DataAnnotations;

namespace LMSweb.Models;

public class DefaultQuestions
{
    [Key]
    public int DQID { get; set; }
    [Required]
    public string Type { get; set; }
    [Required]
    public string Description { get; set; }

    [Required]
    public string Property { get; set; }
}
