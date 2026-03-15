using System;

namespace StadiumCompany.Models
{
    public class Score
    {
        public int Id { get; set; }
        public int UtilisateurId { get; set; }
        public int QuestionnaireId { get; set; }
        public string QuestionnaireNom { get; set; }
        public int ScoreObtenu { get; set; }
        public int ScoreMax { get; set; }
        public DateTime DatePassage { get; set; }
    }
}