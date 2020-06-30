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
    public class QstListModel : PageModel
    {
     private readonly ApplicationDbContext _db;
      public QstListModel(ApplicationDbContext db ){
            _db = db;
       }
        public IList<Question> questions {get ; private set ;}

        public void OnGet( int id )
        {
            questions = _db.Questions.Where(s => s.IdQuiz == id).ToList();

        }
    }
}
