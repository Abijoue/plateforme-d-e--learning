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
    public class MatiereListModel : PageModel
    {
      private readonly ApplicationDbContext _db;
      public MatiereListModel(ApplicationDbContext db ){
            _db = db;
       }
       public IList<Matiere> matieres {get ; private set ;}
       public IList<Filiere> filieres {get ; private set ;}

       public IList<Utilisateur> utilisateurs {get ; private set ;}
       

        public void OnGet()
        {
            matieres = _db.Matieres.ToList();
            filieres = _db.Filieres.ToList();
            utilisateurs = _db.Utilisateurs.ToList();
        }
        public async Task<IActionResult> OnPostDelete(int id)
        {
             var Sub =await _db.Matieres.FindAsync(id);
             
             if(Sub == null){
                 return NotFound();   
             }
            _db.Matieres.Remove(Sub);
            await _db.SaveChangesAsync(); 
            return RedirectToPage();
             
        }
    }
}
