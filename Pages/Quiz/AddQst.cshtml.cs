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
    public class AddQstModel : PageModel
    {    
        private readonly ApplicationDbContext _db;
    [BindProperty]
        public Question question {get;set;}
        public Quiz quiz {get;set;}
        public IList<Quiz> quizzes {get ; private set ;}
        public static int globaleIdQuiz {get;private set;}
        public string choise {get; set;}


        public AddQstModel(ApplicationDbContext db ){
                _db = db;
        }
        public  IActionResult OnGet(int id)
        {
             quiz =  _db.Quizzes.Find(id);
             globaleIdQuiz = quiz.IdQuiz;
             if(quiz == null){
                 return NotFound();
             }else return Page();
        }

        public IActionResult OnPost(){
           quiz =  _db.Quizzes.Find(globaleIdQuiz);
           if(quiz == null){
                 return Page();
             }
            quiz.QestNbr = quiz.QestNbr + 1;
            question.IdQuiz = globaleIdQuiz;
            

                if(ModelState.IsValid){
                    var DB_QST = _db.Questions.Find(question.IdQst);
                    if(DB_QST != null){
                        return Page();    
                    }
                    _db.Questions.Add(question);
                    _db.SaveChanges();
                    return RedirectToPage("/Quiz/QuizList");
                }else{
                    return Page();
                }
        }        
    }
}
