using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using freelance.Models.domaine;

namespace freelance.Data
{
    public partial class MyDbContext : IdentityDbContext<Users> // Assure-toi d'hériter de IdentityDbContext<Users>
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        // Utilisation de SQLite
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=database.db");
            }
        }

        // Configurer la structure des tables et des relations
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // Ne pas oublier d'appeler la méthode base pour les configurations par défaut d'Identity

            // Si tu as d'autres relations ou configurations spécifiques à définir, fais-le ici
            modelBuilder.Entity<Users>()
                .Property(u => u.Nom)
                .IsRequired()  // Exemple de configuration d'un champ
                .HasMaxLength(100); // Exemple de configuration de la longueur du champ

            // Configure les relations ou autres entités si nécessaire
        }

        // Ajoute les DbSet pour les entités si nécessaire (par exemple Projects, Applications, Transactions, etc.)
        public DbSet<Projects> Projects { get; set; }
        public DbSet<Applications> Applications { get; set; }
        public DbSet<Transactions> Transactions { get; set; }
        public DbSet<Messages> Messages { get; set; }
    }
}
