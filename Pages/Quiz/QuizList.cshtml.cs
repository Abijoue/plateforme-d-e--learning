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
    public class QuizListModel : PageModel
    {
      private readonly ApplicationDbContext _db;
      public QuizListModel(ApplicationDbContext db ){
            _db = db;
       }
        public IList<Quiz> quizzes {get ; private set ;}
        public IList<Cours> courses {get ; private set ;}


        public void OnGet()
        {
            quizzes = _db.Quizzes.ToList();
            courses = _db.Courses.ToList();

        }
        public async Task<IActionResult> OnPostDelete(int id)
        {
             var qz =await _db.Quizzes.FindAsync(id);
             
             if(qz == null){
                 return NotFound();   
             }
            _db.Quizzes.Remove(qz);
            await _db.SaveChangesAsync(); 
            return RedirectToPage();
             
        }
    }
}
