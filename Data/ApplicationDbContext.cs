using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PFA_Project.Model;

namespace PFA_Project.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Matiere> Matieres { get; set; }
        public DbSet<Filiere> Filieres { get; set; }
        public DbSet<Cours> Courses { get; set; }
        public DbSet<Commentaire> Commentaires { get; set; }
        public DbSet<Inscription> Inscriptions { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Reponse> Reponses { get; set; }

    }
}
