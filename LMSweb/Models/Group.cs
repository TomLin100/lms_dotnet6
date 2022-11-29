using System.ComponentModel.DataAnnotations;

namespace LMSweb.Models;
public class Group
{
    [Key]
    public string GID { get; set; }
    public string GName { get; set; }
    public ICollection<Student> Students { get; set; }
}