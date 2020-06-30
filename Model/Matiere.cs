using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFA_Project.Model
{
    public class Matiere
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int IdMatiere { get; set; }

        [Required]
        public string NomMatiere { get; set; }
        [Required]
        public int NbrEtudiant { get; set; }

        [Required]
        public string IdProf { get; set; }
        
        [Required]
        public int IdFiliere { get; set; }

        [ForeignKey("IdProf")]
        public Utilisateur utilisateur { get; set; }

        [ForeignKey("IdFiliere")]
        public Filiere filiere { get; set; }
    }
}