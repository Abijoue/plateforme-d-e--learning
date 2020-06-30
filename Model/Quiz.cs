using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFA_Project.Model
{
    public class Quiz
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int IdQuiz { get; set; }

        [Required]
        public string NomQuize { get; set; }

        public int QestNbr { get; set; }

        // public List<Question> Questions { get; set; }

        [Required]
        public int IdCours { get; set; }
        
        [ForeignKey("IdCours")]
        public Cours cours { get; set; }
        
    }
}