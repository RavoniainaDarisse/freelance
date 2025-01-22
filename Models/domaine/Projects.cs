using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace freelance.Models.domaine
{
    public class Projects
    {
        public Guid Id { get; set; }
        public required string Titre { get; set; }
        public required string description { get; set; }
        public int budget { get; set; }
        public DateTime date_creation { get; set; }
        public Users? entreprise_id { get; set; }
        
    }
}