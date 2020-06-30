using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PFA_Project.Data;
using PFA_Project.Model;

namespace MyApp.Namespace
{
    public class EditMatiereModel : PageModel
    {
        private readonly ApplicationDbContext _db;
		[BindProperty]
		public Matiere subject {get;set;}
        public IList<Utilisateur> users {get ; private set ;}
         public EditMatiereModel(ApplicationDbContext db ){
            _db = db;
        }
        public async Task<IActionResult> OnGetAsync(int id){
        
        
            users = _db.Utilisateurs.ToList();
        
             subject =await _db.Matieres.FindAsync(id);

             if(subject == null){
                 return NotFound();
             }else return Page();
        }

        public async Task<IActionResult> OnPostAsync(){
            
            if(!ModelState.IsValid){                
                return Page();
            }
            
            var DB_Sub = await _db.Matieres.FindAsync(subject.IdMatiere);
            DB_Sub.NomMatiere = subject.NomMatiere;
            DB_Sub.IdProf = subject.IdProf;
            
             try
             {
                 await _db.SaveChangesAsync();
             }
             catch (DbUpdateConcurrencyException)
             {
                 throw;
             }
             return RedirectToPage("/Matiere/MatiereList");
        }
    }
}
