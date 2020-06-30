using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PFA_Project.Data;
using PFA_Project.Model;

namespace MyApp.Namespace
{
    public class AnswerModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;

     [BindProperty]
        public string answer {get;set;}
        public IList<int> Urlid {get ; private set ;}

        public Reponse reponse {get;set;}
        public Question question {get;set;}
        public static int GlobalId {get;set;}

        public IList<Question> questions {get ; private set ;}
        

        public AnswerModel(ApplicationDbContext db , UserManager<IdentityUser> userManager ){
                _db = db;
                _userManager = userManager;  
        }
        public  IActionResult OnGet(int id)
        {
             question =  _db.Questions.Find(id);
             if(question == null){
                 return RedirectToPage("/Etudiant/MyList");
             }
            GlobalId = question.IdQst;
            Urlid = (from quiz in _db.Quizzes.ToList()
             join  cr in _db.Courses.ToList()
             on quiz.IdCours equals cr.IdCours
             where quiz.IdQuiz == question.IdQuiz
             select cr.IdCours).ToList();

             if(question == null){
                 return NotFound();
             }else return Page();
        }

        public IActionResult OnPost(){
                    reponse = new Reponse();
                    reponse.IdQst = GlobalId;
                    reponse.IdEtud = _userManager.GetUserId(HttpContext.User);
                    reponse.MonReponse = answer;
                    var DB_Res = _db.Reponses.Find(reponse.IdReponse);
                    if(DB_Res != null){
                        return Page();    
                    }
                    _db.Reponses.Add(reponse);
                    _db.SaveChanges();
                    // return Redirect("/Etudiant/TakeQuiz?id="+@Urlid.ElementAt(0));
                    return Redirect("/Etudiant/MyList");
        }           
    }
}
