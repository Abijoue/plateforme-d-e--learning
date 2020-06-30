using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFA_Project.Model
{
    public class Filiere
    {

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
       
        public int IdFiliere { get; set; }

        [Required]
        public string NomFiliere { get; set; }

        public List<Utilisateur> ListEtud { get; set; }

         public Filiere()
        {
            this.ListEtud = new List<Utilisateur>();
            

        }
    }

 
}