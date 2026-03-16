using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StadiumCompany.Models
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime DateCreation { get; set; }
    }
}
