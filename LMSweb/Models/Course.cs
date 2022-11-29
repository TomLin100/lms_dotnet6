using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMSweb.Models;
public class Course
{
    [Key]
    public string CID { get; set; }
    public string CName { get; set; }
    public bool IsAddPeerAssessmemt { get; set; } //是否加入同儕互評機制
    public bool IsAddMetacognition { get; set; } //是否加入後設認知
    public string TID { get; set; }
    [ForeignKey("TID")]
    public Teacher Teacher { get; set; }
    public ICollection<Student> Students { get; set; }
    public ICollection<Mission> Missions { get; set; }
    public ICollection<KnowledgePoint> KnowledgePoints { get; set; }
}