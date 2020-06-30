using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PFA_Project.Data;
using PFA_Project.Model;

namespace MyApp.Namespace
{
    public class AddQuizModel : PageModel
    {
    private readonly ApplicationDbContext _db;
      [BindProperty]
      public Quiz quiz {get;set;}
      public Question question {get;set;}
      public IList<Cours> cours {get ; private set ;}

      public AddQuizModel(ApplicationDbContext db ){
            _db = db;
        }
        public void OnGet()
        {
            cours = _db.Courses.ToList();
        }
        public IActionResult OnPost(){
            quiz.QestNbr = 0;
            
            if(ModelState.IsValid){
                var DB_Quiz = _db.Quizzes.Find(quiz.IdQuiz);
                if(DB_Quiz != null){
                    return Page();    
                }
                _db.Quizzes.Add(quiz);
                _db.SaveChanges();
                return RedirectToPage("/Quiz/QuizList");
            }else{
                return Page();
            }
        }
    }
}
