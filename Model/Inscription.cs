using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFA_Project.Model
{
    public class Inscription
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int IdInscription { get; set; }

        [Required]
        public  int IdCours { get; set; }
        
        [Required]
        public string IdEtudiant { get; set; }

        [ForeignKey("IdCours")]
        public Cours cours { get; set; }
        
        [ForeignKey("IdEtudiant")]
        public Utilisateur utilisateur { get; set; }

        public Inscription(){
            
        }


    }
}