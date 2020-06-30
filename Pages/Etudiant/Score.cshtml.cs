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
    public class ScoreModel : PageModel
    {

        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;

    [BindProperty]
        public Reponse reponse {get;set;}
        public Quiz quiz {get;set;}
        public IList<Quiz> quizzes {get ; private set ;}
        public static int globaleIdQuiz;
        public double YourScore {get;set;}

        public IList<string> correct {get ; private set ;}
        public IList<Question> questions {get ; private set ;} //***************************//

        public IList<Reponse> reponses {get ; private set ;}
        public IList<string> answer {get ; set ;}




        public ScoreModel(ApplicationDbContext db , UserManager<IdentityUser> userManager ){
                _db = db;
                _userManager = userManager;  
        }

        public void OnGet(int id)
        {
            globaleIdQuiz = id;
            quiz = _db.Quizzes.Find(id);
            questions = _db.Questions.Where(s => s.IdQuiz == globaleIdQuiz).ToList();
            reponses = (from rep in _db.Reponses.ToList()
                        join qst in questions
                        on rep.IdQst equals qst.IdQst
                        where rep.IdEtud == _userManager.GetUserId(HttpContext.User)
                        select rep).ToList();
            int res = 0;
            // string str ;
            for (int i = 0; i < reponses.Count; i++)
            {
                // str = questions[i].ChoixeCorrect;
                if(reponses[i].MonReponse == questions[i].ChoixeCorrect){
                        res++;
                }
            }
            var lenght = reponses.Count;
            YourScore = ((float)res / (float) lenght ) * 100.0;
        }
         
    }
}
