using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace freelance.Models.domaine
{
    public class Messages
    {
        public Guid Id { get; set; }
        public string? sender_id { get; set; }
        public string? receiver_id { get; set; }
        public string? contenu { get; set; }
        public DateTime date_envoi { get; set; }
    }
}