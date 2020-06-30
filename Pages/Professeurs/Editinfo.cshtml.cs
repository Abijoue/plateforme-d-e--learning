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
    public class EditinfoModel : PageModel
    {
        private readonly ApplicationDbContext _db;
		[BindProperty]
		public Utilisateur professor {get;set;}

         public EditinfoModel(ApplicationDbContext db ){
            _db = db;
        }
        public async Task<IActionResult> OnGetAsync(string id)
        {
             professor =await _db.Utilisateurs.FindAsync(id);

             if(professor == null){
                 return NotFound();
             }else return Page();
        }

        public async Task<IActionResult> OnPostAsync(){
            
            if(!ModelState.IsValid){                
                return Page();
            }
            
            var DB_Prof = await _db.Utilisateurs.FindAsync(professor.Id);
            DB_Prof.Nom = professor.Nom;
            DB_Prof.Prenom = professor.Prenom;
            DB_Prof.CIN = professor.CIN;
            DB_Prof.Email = professor.Email;
            
             try
             {
                 await _db.SaveChangesAsync();
             }
             catch (DbUpdateConcurrencyException)
             {
                 throw;
             }
             return RedirectToPage("/Professeurs/profList");
        }
    }
}
