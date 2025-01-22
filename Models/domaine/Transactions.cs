using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace freelance.Models.domaine
{
    public class Transactions
    {
        public Guid Id { get; set; }
        public int montant { get; set; }
        public Users? freelance_id { get; set; }
        public Users? entreprise_id { get; set; }
        public string? statut { get; set; }
        public DateTime date_transaction { get; set; }
    }
}