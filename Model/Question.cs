using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFA_Project.Model
{
    public class Question
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int IdQst { get; set; }

        [Required]
        public string Qst { get; set; }

        public string Choix1 { get; set; }
        public string Choixe2 { get; set; }

        public string Choix3 { get; set; }

        public string Choixe4 { get; set; }

        public string ChoixeCorrect { get; set; }

        [Required]
        public int IdQuiz { get; set; }
        
        [ForeignKey("IdQuiz")]
        public Quiz quiz { get; set; }
        

    }
}