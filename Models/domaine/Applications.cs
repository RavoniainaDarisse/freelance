using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace freelance.Models.domaine
{
    public class Applications
    {
        public Guid Id { get; set; }
        public Users? freelance_id { get; set; }
        public Projects? project_id { get; set; }
        public string? statut { get; set; }
        public DateTime date_soumission { get; set; }
    }
}