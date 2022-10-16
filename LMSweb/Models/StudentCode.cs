using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMSweb.Models
{
    public class StudentCode
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SCID {get; set;}
        public string CID { get; set; }
        public virtual Course course { get; set; }

        public string MID { get; set; }
        public virtual Mission mission { get; set; }

        public int GID { get; set; }
        public virtual Group group { get; set; }

        public string CodePath { get; set; }

        public bool IsEdit { get; set; }
    }
}