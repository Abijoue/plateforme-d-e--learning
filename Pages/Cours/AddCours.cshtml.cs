using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PFA_Project.Data;
using PFA_Project.Model;

namespace MyApp.Namespace
{
    public class AddCoursModel : PageModel
    {
        //--------------------------------------------------------------------
        //---------------------------------------------------------------------
    private readonly ApplicationDbContext _db;
    private readonly UserManager<IdentityUser> _userManager;
    private IWebHostEnvironment _environment;

[BindProperty]
    public Cours cours {get;set;}
    public string FileName { get; set; }
    public IFormFile Upload_img { get; set; }
    public IFormFile Upload_pdf { get; set; }


    

    public IList<Matiere> matieres {get ; private set ;}
        // , IWebHostEnvironment IWebHostEnvironment
    public AddCoursModel(ApplicationDbContext db , IWebHostEnvironment environment ,UserManager<IdentityUser> userManager ){
            _db = db;
            _environment = environment;
            _userManager = userManager;  
    }

    public void OnGet()
    {
        matieres = _db.Matieres.ToList();

    }
    public async Task<IActionResult> OnPostAsync(IFormFile photo){
        //===================================image upload ==================================================
         var file = Path.Combine(_environment.ContentRootPath, "wwwroot/dynamic_images", Upload_img.FileName);
          using (var fileStream = new FileStream(file, FileMode.Create)){
             await Upload_img.CopyToAsync(fileStream);
         }
             cours.URL_img = Upload_img.FileName;
        // =================================================================================================
        //=================================== pdf upload ===================================================
         var file2 = Path.Combine(_environment.ContentRootPath, "wwwroot/sourse", Upload_pdf.FileName);
           using (var fileStream = new FileStream(file2, FileMode.Create)){
             await Upload_pdf.CopyToAsync(fileStream);
         }
              cours.URL = Upload_pdf.FileName;
        // =================================================================================================
           cours.DatePub = DateTime.Now.ToString();
           cours.Auteur = _userManager.GetUserId(HttpContext.User);

            // if(ModelState.IsValid){
                var DB_Fil = _db.Courses.Find(cours.IdCours);
                if(DB_Fil != null){
                    return Page();    
                } 


                _db.Courses.Add(cours);
                _db.SaveChanges();
                return RedirectToPage("/Cours/CoursList");
            // }else{
            //     return RedirectToPage("/Cours/AddCours");;
            // }
        }
    }
}
