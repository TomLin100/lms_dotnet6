using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMSweb.Models;

public class DefaultOption
{
    [Key]
    public int DOID { get; set; }
    public int DQID { get; set; }
    public string ChoiceItem { get; set; }

    [ForeignKey("DQID")]
    public DefaultQuestion DefaultQuestion { get; set; }
}
