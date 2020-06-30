using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PFA_Project.Data;
using PFA_Project.Model;

namespace MyApp.Namespace
{
    public class EditCoursModel : PageModel
    {  //---------------------------------------------------------------------
    private readonly ApplicationDbContext _db;
    private IWebHostEnvironment _environment;

[BindProperty]
    public Cours cours {get;set;}
    public string FileName { get; set; }
    public IFormFile Upload_img { get; set; }
    public IFormFile Upload_pdf { get; set; }
    public IList<Matiere> matieres {get ; private set ;}
		
    public EditCoursModel(ApplicationDbContext db , IWebHostEnvironment environment ){
            _db = db;
            _environment = environment;
    }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            matieres = _db.Matieres.ToList();   
            cours = await _db.Courses.FindAsync(id);
             if(cours == null){
                 return NotFound();
             }else return Page();
        }

        public async Task<IActionResult> OnPostAsync(){

            matieres = _db.Matieres.ToList();
            try
            {
                if(Upload_img.FileName == null){
                  return Page();
                }
                if (Upload_pdf.FileName == null){
                   return Page();
                }
            }
            catch (NullReferenceException)
            {
                return Page();
            }
 
            var DB_CR = await _db.Courses.FindAsync(cours.IdCours);
            DB_CR.CoursName = cours.CoursName;
            DB_CR.Description = cours.Description;
            DB_CR.IdMatiere = cours.IdMatiere;

        //-----------------------------------=============--------------------------------------------------
        string _imageToBeDeleted = Path.Combine(_environment.ContentRootPath, "wwwroot/dynamic_images", DB_CR.URL_img);
                if ((System.IO.File.Exists(_imageToBeDeleted)))
                {
                    System.IO.File.Delete(_imageToBeDeleted);
                }
         //-----------------------------------=============--------------------------------------------------
        string _PDFToBeDeleted = Path.Combine(_environment.ContentRootPath, "wwwroot/sourse", DB_CR.URL);
                if ((System.IO.File.Exists(_PDFToBeDeleted)))
                {
                    System.IO.File.Delete(_PDFToBeDeleted);
                }
        //===================================image upload ==================================================
         var file = Path.Combine(_environment.ContentRootPath, "wwwroot/dynamic_images", Upload_img.FileName);
          using (var fileStream = new FileStream(file, FileMode.Create)){
             await Upload_img.CopyToAsync(fileStream);
         }
             DB_CR.URL_img = Upload_img.FileName;
        // =================================================================================================
        //=================================== pdf upload ===================================================
         var file2 = Path.Combine(_environment.ContentRootPath, "wwwroot/sourse", Upload_pdf.FileName);
           using (var fileStream = new FileStream(file2, FileMode.Create)){
             await Upload_pdf.CopyToAsync(fileStream);
         }
              DB_CR.URL = Upload_pdf.FileName;
        // =================================================================================================

             try
             {
                 await _db.SaveChangesAsync();
             }
             catch (DbUpdateConcurrencyException)
             {
                 throw;
             }  
             return RedirectToPage("/Cours/CoursList");
        }
    }
}
