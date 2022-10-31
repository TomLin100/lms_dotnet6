using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMSweb.Models
{
    public class StudentCode
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SCID {get; set;}

        [ForeignKey("CID")]
        public virtual Course Course { get; set; }

        [ForeignKey("MID")]
        public virtual Mission Mission { get; set; }

        [ForeignKey("GID")]
        public virtual Group Group { get; set; }

        public string CodePath { get; set; }

        public bool IsEdit { get; set; }
    }
}