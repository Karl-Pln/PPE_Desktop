using System.Collections.Generic;
using StadiumCompany.DAO;
using StadiumCompany.Models;

namespace StadiumCompany.Controllers
{
    public class QuestionnaireController
    {
        private readonly QuestionnaireDAO dao = new QuestionnaireDAO();

        public List<Questionnaire> GetAll()
        {
            return dao.GetAll();
        }

        public int Ajouter(Questionnaire q)
        {
            if (string.IsNullOrEmpty(q.Nom) || q.ThemeId <= 0)
                return -1;

            return dao.Ajouter(q);
        }

        public bool Modifier(Questionnaire q)
        {
            if (q.Id <= 0 || string.IsNullOrEmpty(q.Nom) || q.ThemeId <= 0)
                return false;

            return dao.Modifier(q);
        }

        public bool Supprimer(int id)
        {
            if (id <= 0)
                return false;

            return dao.Supprimer(id);
        }

        public List<Theme> GetThemes()
        {
            return dao.GetThemes();
        }
    }
}