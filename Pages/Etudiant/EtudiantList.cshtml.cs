using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PFA_Project.Data;
using PFA_Project.Model;

namespace  MyApp.Namespace
{
    public class EtudiantListModel : PageModel
    {
    
        private readonly ApplicationDbContext _db;
        public IList<Utilisateur> Etudiants {get ; private set ;}


      public EtudiantListModel(ApplicationDbContext db ){
            _db = db;
       }
        public void OnGet()
        {
            Etudiants = _db.Utilisateurs.Where(s=> s.Status == 'E').ToList();
        }
        public async Task<IActionResult> OnPostDelete(string id)
        {
             var ETUD =await _db.Utilisateurs.FindAsync(id);
             
             if(ETUD == null){
                 return NotFound();   
             }
            _db.Utilisateurs.Remove(ETUD);
            await _db.SaveChangesAsync(); 
            return RedirectToPage();
        }
    }
}
