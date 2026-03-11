using System.Collections.Generic;
using StadiumCompany.DAO;
using StadiumCompany.Models;

namespace StadiumCompany.Controllers
{
    public class ReponsePossibleController
    {
        private readonly ReponsePossibleDAO dao = new ReponsePossibleDAO();

        public List<ReponsePossible> GetByQuestion(int questionId)
        {
            if (questionId <= 0)
                return new List<ReponsePossible>();

            return dao.GetByQuestion(questionId);
        }

        public int Ajouter(ReponsePossible r)
        {
            if (string.IsNullOrEmpty(r.Libelle) || r.QuestionId <= 0)
                return -1;

            return dao.Ajouter(r);
        }

        public bool Modifier(ReponsePossible r)
        {
            if (r.Id <= 0 || string.IsNullOrEmpty(r.Libelle))
                return false;

            return dao.Modifier(r);
        }

        public bool Supprimer(int id)
        {
            if (id <= 0)
                return false;

            return dao.Supprimer(id);
        }

        public bool SupprimerParQuestion(int questionId)
        {
            if (questionId <= 0)
                return false;

            return dao.SupprimerParQuestion(questionId);
        }
    }
}