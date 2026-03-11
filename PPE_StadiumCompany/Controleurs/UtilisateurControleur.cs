using StadiumCompany.DAO;
using StadiumCompany.Models;

namespace StadiumCompany.Controllers
{
    public class UtilisateurController
    {
        private readonly UtilisateurDAO dao = new UtilisateurDAO();

        public Utilisateur Connexion(string login, string password)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
                return null;

            return dao.Connexion(login, password);
        }

        public bool Inscrire(string login, string password, string nom, string prenom)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password)
                || string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(prenom))
                return false;

            if (dao.EmailExiste(login))
                return false;

            var u = new Utilisateur
            {
                Login = login,
                Password = password,
                Nom = nom,
                Prenom = prenom
            };
            return dao.Inscrire(u);
        }
    }
}