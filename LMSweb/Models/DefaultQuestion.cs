using System.ComponentModel.DataAnnotations;

namespace LMSweb.Models
{
    public class DefaultQuestion
    {
        [Key]
        public int DQID { get; set; }

        [Display(Name = "題型")]
        public string Type { get; set; }

        [Display(Name = "問卷分類")]
        public string Class { get; set; }  //目標設置、反思題目

        [Display(Name = "題目")]
        public string Description { get; set; }

        public virtual ICollection<DefaultOption> DefaultOptions { get; set; }
        public virtual ICollection<Response> Responses { get; set; }
        public virtual ICollection<EvalutionResponse> EvalutionResponses { get; set; }
    }
}