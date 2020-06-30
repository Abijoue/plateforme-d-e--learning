using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFA_Project.Model
{
    public class Commentaire
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int IdComm { get; set; }

        [Required]
        public string Body { get; set; }

        
        [DisplayFormat(ApplyFormatInEditMode = true,DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public string DatePub { get; set; }
        
        [Required]
        public int IdCours { get; set; }

        [Required]
        public string IdAuteur { get; set; }

    }
}