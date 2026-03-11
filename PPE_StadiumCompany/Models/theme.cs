using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StadiumCompany.Models
{
    public class Theme
    {
        public int Id { get; set; }
        public string Libelle { get; set; }

        public override string ToString() => Libelle;
    }
}
