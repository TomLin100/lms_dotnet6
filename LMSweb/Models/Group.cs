using System.ComponentModel.DataAnnotations;

namespace LMSweb.Models;
public class Group
{
    [Key]
    public string GID { get; set; }
    public string GName { get; set; }
    public virtual ICollection<Student> Students { get; set; }
    public virtual ICollection<Discussion> Discussions { get; set; }
}
