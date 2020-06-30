using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PFA_Project.Data;
using PFA_Project.Model;

namespace PFA_Project.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext _db;


        public IList<Utilisateur> utilisateurs {get ; set ;}
        public IList<PFA_Project.Model.Cours> courses {get ;  set ;} 
        public IList<PFA_Project.Model.Quiz> quizzes {get ;  set ;} 
        public IList<PFA_Project.Model.Commentaire> commentaires {get ;  set ;} 




        public IndexModel(ILogger<IndexModel> logger , ApplicationDbContext db )
        {
            _logger = logger;
            _db = db;
        }

        public void OnGet()
        {
            utilisateurs = _db.Utilisateurs.ToList();
            courses = _db.Courses.ToList();
            commentaires = _db.Commentaires.ToList();
            quizzes = _db.Quizzes.ToList();

        }
    }
}
