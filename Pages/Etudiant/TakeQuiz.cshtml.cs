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
    public class TakeQuizModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;

    [BindProperty]
        public Reponse reponse {get;set;}
        public Quiz quiz {get;set;}
        public IList<Quiz> quizzes {get ; private set ;}
        public static int globaleIdQuiz {get;private set;}
         public static int size {get;private set;}
        public static int frikingID {get; set;}
 

        public IList<Question> questionsDefault {get ; private set ;}
        public IList<Question> questions {get ; private set ;}

        public IList<Reponse> reponses {get ; private set ;}
        public IList<string> answer {get ; set ;}




        public TakeQuizModel(ApplicationDbContext db , UserManager<IdentityUser> userManager ){
                _db = db;
                _userManager = userManager;  
        }
        public IActionResult OnGet(int id)
        {
            quizzes =  _db.Quizzes.Where(s => s.IdCours == id).ToList();
            if(quizzes.Count == 0){
                 return RedirectToPage("/Opps");
            }
            
            quiz = quizzes[0];
            globaleIdQuiz = quiz.IdQuiz;
            size = quizzes.Count;
            // questions = _db.Questions.Where(s => s.IdQuiz == globaleIdQuiz).ToList();
            questionsDefault = _db.Questions.Where(s => s.IdQuiz == globaleIdQuiz ).ToList();
            // var tp1= (from rep in _db.Reponses.ToList()
            //             where !questionsDefault.Any(qst => qst.IdQst == rep.IdQst)
            //             select rep).ToList();
             questions = (from qst in questionsDefault
                        where ! _db.Reponses.ToList().Any(rep => rep.IdQst == qst.IdQst && rep.IdEtud == _userManager.GetUserId(HttpContext.User))
                        select qst).ToList();
            if (questions.Count == 0) {
                ViewData["id"] = globaleIdQuiz;
                return RedirectToPage("/Etudiant/Score", new {id = globaleIdQuiz});
            }
            //  reponses = (from rep in _db.Reponses.ToList()
            //             join qst in questions
            //             on rep.IdQst equals qst.IdQst
            //             join Q in _db.Quizzes.ToList()
            //             on qst.IdQuiz equals Q.IdQuiz
            //             select rep).ToList();

            return null;
        }

        public IActionResult OnPost(){

            
                if(ModelState.IsValid){
                var DB_REP = _db.Reponses.Find(reponse.IdReponse);
                if(DB_REP != null){
                    return Page();    
                }
                _db.Reponses.Add(reponse);
                _db.SaveChanges();
                return RedirectToPage("/Etudiant/TakeQuiz");
                }else{
                    return Page();
                }
            // }
            // return Redirect("MyList");                   
        } 
    }
}
