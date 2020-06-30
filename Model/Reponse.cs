using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFA_Project.Model
{
    public class Reponse
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int IdReponse { get; set; }

        [Required]
        public string MonReponse { get; set; }

        [Required]
        public int IdQst { get; set; }

        [Required]
        public string IdEtud { get; set; }

        [ForeignKey("IdEtud")]
        public Utilisateur utilisateur { get; set; }
        
        [ForeignKey("IdQst")]
        public Question question { get; set; }
        
    }
}