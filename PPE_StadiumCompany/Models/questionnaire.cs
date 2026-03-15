using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StadiumCompany.Models;

namespace StadiumCompany.Models
{
    public class Questionnaire
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Publie { get; set; }
        public int ThemeId { get; set; }
        public string ThemeLibelle { get; set; }
        public int CreateurId { get; set; }
        public DateTime date_creation { get; set; }

        public List<Question> Questions { get; set; } = new List<Question>();
        public int NombreQuestions => Questions.Count;

    }
}
