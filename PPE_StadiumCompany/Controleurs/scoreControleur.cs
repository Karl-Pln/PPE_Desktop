using System;
using System.Collections.Generic;
using StadiumCompany.DAO;
using StadiumCompany.Models;

namespace StadiumCompany.Controllers
{
    public class ScoreController
    {
        private readonly ScoreDAO dao = new ScoreDAO();

        public bool Enregistrer(int utilisateurId, int questionnaireId, int scoreObtenu, int scoreMax)
        {
            if (utilisateurId <= 0 || questionnaireId <= 0) return false;

            var s = new Score
            {
                UtilisateurId = utilisateurId,
                QuestionnaireId = questionnaireId,
                ScoreObtenu = scoreObtenu,
                ScoreMax = scoreMax,
                DatePassage = DateTime.Now
            };
            return dao.Enregistrer(s);
        }

        public List<Score> GetByUtilisateur(int utilisateurId)
        {
            if (utilisateurId <= 0) return new List<Score>();
            return dao.GetByUtilisateur(utilisateurId);
        }
    }
}