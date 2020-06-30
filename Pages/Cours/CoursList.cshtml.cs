using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PFA_Project.Data;
using PFA_Project.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace MyApp.Namespace
{
    // [Authorize(Roles = "Admin")]
    public class CoursListModel : PageModel
    { 
    private readonly ApplicationDbContext _db;
    private readonly UserManager<IdentityUser> _userManager;
    private readonly ILogger _logger;

    public IFormFile Upload { get; set; }
    public Inscription inscription { get; set; }

    private IWebHostEnvironment _environment;

      public CoursListModel(ApplicationDbContext db , IWebHostEnvironment environment ,UserManager<IdentityUser> userManager ,ILogger<CoursListModel> logger){
            _db = db;
            _environment = environment;
            _userManager = userManager;  
            _logger = logger;

        }
       public IList<Cours> courses {get ; private set ;}
       public IList<Matiere> matieres {get ; private set ;}
       public IList<Inscription> inscriptions {get ; private set ;}
       public string userID {get;set;}


        public void OnGet()
        {
            matieres = _db.Matieres.ToList();
            courses = _db.Courses.ToList();
            userID = _userManager.GetUserId(HttpContext.User);

        }
        public async Task<IActionResult> OnPostDelete(int id)
        {
             var Cours =await _db.Courses.FindAsync(id);
            
             if(Cours == null){
                 return NotFound();   
             }
               string _imageToBeDeleted = Path.Combine(_environment.ContentRootPath, "wwwroot/dynamic_images", Cours.URL_img);
                if ((System.IO.File.Exists(_imageToBeDeleted)))
                {
                    System.IO.File.Delete(_imageToBeDeleted);
                }
            _db.Courses.Remove(Cours);
            await _db.SaveChangesAsync(); 
            return RedirectToPage();
             
        }

        public IActionResult OnPostAdd(int id)
        {
            inscription = new Inscription();
            inscription.IdCours = id;
            inscription.IdEtudiant = _userManager.GetUserId(HttpContext.User);

            inscriptions = _db.Inscriptions.ToList();

            foreach (var element in inscriptions)
            {
                if(element.IdCours == id && element.IdEtudiant == inscription.IdEtudiant){
                    return RedirectToPage("/Cours/CoursList");
                }
            }

                _db.Inscriptions.Add(inscription);
                _db.SaveChanges();
                return RedirectToPage("/Etudiant/MyList");

        }

        // public async Task<IActionResult> OnPostView(int id)
        // {
        //      var Cours =await _db.Courses.FindAsync(id);
            
        //      if(Cours == null){
        //          return NotFound();   
        //      }
            
        //     return Redirect("/ViewCours");
             
        // }
    }
}
