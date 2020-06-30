using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PFA_Project.Data;
using PFA_Project.Model;

namespace PFA_Project.Pages.Professeurs
{
    public class profListModel : PageModel
    {
    
        private readonly ApplicationDbContext _db;
        public IList<Utilisateur> professors {get ; private set ;}


      public profListModel(ApplicationDbContext db ){
            _db = db;
       }
        public void OnGet()
        {
            professors = _db.Utilisateurs.Where(s=> s.Status == 'P').ToList();
        }
        public async Task<IActionResult> OnPostDelete(string id)
        {
             var Prof =await _db.Utilisateurs.FindAsync(id);
             
             if(Prof == null){
                 return NotFound();   
             }
            _db.Utilisateurs.Remove(Prof);
            await _db.SaveChangesAsync(); 
            return RedirectToPage();
        }
    }
}
