using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFA_Project.Model
{
    public class Cours
    {

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int IdCours { get; set; }

        [Required]
        public string CoursName { get; set; }

        [Required]
        public string URL_img { get; set; }

        public string Description { get; set; }

        public string Auteur  { get; set; }


        [DisplayFormat(ApplyFormatInEditMode = true,DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public string DatePub { get; set; }

        public string URL { get; set; }

        [Required]
        public int IdMatiere { get; set; }

         [ForeignKey("IdMatiere")]
        public Matiere matiere { get; set; }

        // public Cours(){
        //     DatePub = DateTime.Now.ToString();
        // }
    }
}