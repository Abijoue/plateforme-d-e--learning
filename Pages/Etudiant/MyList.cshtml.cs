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
    public class MyListModel : PageModel
    {
      private readonly ApplicationDbContext _db;
      private readonly UserManager<IdentityUser> _userManager;

      public MyListModel(ApplicationDbContext db , UserManager<IdentityUser> userManager  ){
            _db = db;
            _userManager = userManager;  
       }
       public IList<Inscription> inscriptions {get ; private set ;}
       public IList<Utilisateur> etudiants {get ; private set ;}
       public IList<Cours> courses {get ; private set ;}

       public string userID {get;set;}

        public void OnGet()
        {
            inscriptions = _db.Inscriptions.ToList();
            etudiants = _db.Utilisateurs.ToList();
            courses = _db.Courses.ToList();
            userID = _userManager.GetUserId(HttpContext.User);
        }
        public async Task<IActionResult> OnPostDelete(int id)
        {
             var insc =await _db.Inscriptions.FindAsync(id);
            
             if(insc == null){
                 return NotFound();   
             }
             
            _db.Inscriptions.Remove(insc);
            await _db.SaveChangesAsync(); 
            return RedirectToPage();
             
        }
    }
}
