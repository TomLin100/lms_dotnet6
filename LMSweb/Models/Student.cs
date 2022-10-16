using System.ComponentModel.DataAnnotations;

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

        [Required]
        [Display(Name = "課程編號")]
        public string CID { get; set; }

        public virtual Group group{ get; set; }
        public virtual Course course { get; set; }
        public virtual ICollection<StudentMission> StudentMissions { get; set; }
        public virtual ICollection<LearningBehavior> LearningBehaviors { get; set; }
        public virtual ICollection<Response> Responses { get; set; }
        public virtual ICollection<EvalutionResponse> EvalutionResponses { get; set; }
    }
}