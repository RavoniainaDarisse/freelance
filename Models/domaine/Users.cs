using Microsoft.AspNetCore.Identity;
using System;

namespace freelance.Models.domaine
{
    public class Users : IdentityUser
    {
        public string? Nom { get; set; }
        public string? Photo { get; set; }
        public string? Portfolio { get; set; }
        public string? Competences { get; set; }
        public bool Disponibilite { get; set; }
        public DateTime Date_Inscription { get; set; }
        public RoleUser RoleUser { get; set; } = RoleUser.freelance;
    }

    public enum RoleUser
    {
        freelance,
        entreprise,
        admin
    }
}
