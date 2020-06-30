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
    public class AddMatiereModel : PageModel
    {
    private readonly ApplicationDbContext _db;
      [BindProperty]
      public Matiere matiere {get;set;}
      public IList<Utilisateur> users {get ; private set ;}
      public IList<Filiere> filieres {get ; private set ;}

      public AddMatiereModel(ApplicationDbContext db ){
            _db = db;
        }
        public void OnGet()
        {
            users = _db.Utilisateurs.ToList();
            filieres = _db.Filieres.ToList();
        }
        public IActionResult OnPost(){

            if(ModelState.IsValid){
                var DB_Sub = _db.Matieres.Find(matiere.IdMatiere);
                if(DB_Sub != null){
                    return Page();    
                }
                _db.Matieres.Add(matiere);
                _db.SaveChanges();
                return RedirectToPage("/Matiere/MatiereList");
            }else{
                return Page();
            }
        }
    }
}
