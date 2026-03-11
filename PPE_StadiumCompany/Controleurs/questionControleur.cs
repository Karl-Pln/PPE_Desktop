using System.Collections.Generic;
using StadiumCompany.DAO;
using StadiumCompany.Models;

namespace StadiumCompany.Controllers
{
    public class QuestionController
    {
        private readonly QuestionDAO dao = new QuestionDAO();

        public List<Question> GetByQuestionnaire(int questionnaireId)
        {
            if (questionnaireId <= 0)
                return new List<Question>();

            return dao.GetByQuestionnaire(questionnaireId);
        }

        public int Ajouter(Question q)
        {
            if (string.IsNullOrEmpty(q.Libelle) || q.QuestionnaireId <= 0)
                return -1;

            return dao.Ajouter(q);
        }

        public bool Modifier(Question q)
        {
            if (q.Id <= 0 || string.IsNullOrEmpty(q.Libelle))
                return false;

            return dao.Modifier(q);
        }

        public bool Supprimer(int id)
        {
            if (id <= 0)
                return false;

            return dao.Supprimer(id);
        }
    }
}