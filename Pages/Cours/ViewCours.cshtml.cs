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
    public class ViewCoursModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        public IList<Cours> courses {get ; private set ;}
        public IList<Commentaire> commentaires {get ; private set ;}
        public IList<Utilisateur> users {get ; private set ;}

        public static int globaleId {get;private set;}


        public Cours cr {get;set;}
        public Commentaire comment {get;set;}
        public string auteur {get;set;}

        public ViewCoursModel(ApplicationDbContext db ,UserManager<IdentityUser> userManager ){
            _db = db;
            _userManager = userManager;  
       }

        public  IActionResult OnGet(int id)
        {
            cr =  _db.Courses.Find(id);
            ViewData["My_URL"] = cr.URL ;
            commentaires = _db.Commentaires.ToList();
            users = _db.Utilisateurs.ToList();
            globaleId = cr.IdCours;
             if(cr == null){
                 return NotFound();
             }else return Page();

        }

        public IActionResult OnPost()
        {
            comment = new Commentaire();
            comment.Body = Request.Form["body"];
            comment.IdAuteur = _userManager.GetUserId(HttpContext.User);
            comment.DatePub = DateTime.Now.ToString();
            comment.IdCours = globaleId;
            
            if(ModelState.IsValid){
                var DB_Com = _db.Commentaires.Find(comment.IdComm);
                if(DB_Com != null || comment.Body ==""){
                    return Redirect("/Cours/ViewCours?id="+@globaleId);
                }
                _db.Commentaires.Add(comment);
                _db.SaveChanges();
                return Redirect("/Cours/ViewCours?id="+@globaleId);
            }else{
                return Redirect("CoursList");
            }
             
        }

    }
}
