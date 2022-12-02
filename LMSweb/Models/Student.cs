using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMSweb.Models;
public class Student
{
    [Key]
    public string SID { get; set; }
    public string Password { get; set; }
    public string SName { get; set;}
    public string Sex { get; set; }
    public string? CID { get; set; }
    [ForeignKey("CID")]
    public Course Course { get; set; }
    public string? GID { get; set; }
    [ForeignKey("GID")]
    public Group Group { get; set; }
}
