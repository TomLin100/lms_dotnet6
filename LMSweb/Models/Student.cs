using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMSweb.Models
{
    [MetadataType(typeof(Student))]
    public class Student
    {
        [Key]
        [Required]
        [Display(Name = "學號")]
        public string SID { get; set; }

        [Required]
        [Display(Name = "姓名")]
        public string SName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "密碼")]
        public string SPassword { get; set; }

        [Required]
        [Display(Name = "性別")]
        public string Sex { get; set; }


        [Display(Name = "積分")]
        public string Score { get; set; }

        [ForeignKey("GID")]
        public virtual Group Group{ get; set; }

        [ForeignKey("CID")]
        public virtual Course Course { get; set; }
        public virtual ICollection<StudentMission> StudentMissions { get; set; }
        public virtual ICollection<LearningBehavior> LearningBehaviors { get; set; }
        public virtual ICollection<Response> Responses { get; set; }
        public virtual ICollection<EvalutionResponse> EvalutionResponses { get; set; }
    }
}