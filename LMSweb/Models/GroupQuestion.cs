using System.ComponentModel.DataAnnotations;

namespace LMSweb.Models
{
    public class GroupQuestion
    {
        [Key]
        public int GQID { get; set; }

        [Display(Name = "題型")]
        public string Type { get; set; }

        [Display(Name = "題目")]
        public string Description { get; set; }

        public virtual ICollection<GroupOption> GroupOptions { get; set; }
        public virtual ICollection<GroupER> GroupERs { get; set; }
    }
}