using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StadiumCompany.Models;

namespace StadiumCompany.Models
{
    public enum TypeReponse
    {
        VraiFaux,
        ListeValeurs
    }

    public class Question
    {
        public int Id { get; set; }
        public int QuestionnaireId { get; set; }
        public string Libelle { get; set; }
        public TypeReponse TypeReponse { get; set; }
        public string BonneReponse { get; set; }
        public int Ordre { get; set; }
        public List<ReponsePossible> ReponsesPossibles { get; set; } = new List<ReponsePossible>();
    }
}