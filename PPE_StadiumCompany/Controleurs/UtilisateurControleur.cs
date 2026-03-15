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
            {
                return null;
            }
            string Passwordhash = HashPassword(password);
            return dao.Connexion(login, password);
        }

        public bool Inscrire(string login, string password, string nom, string prenom)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password)
                || string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(prenom))
            {
                return false;
            }

            if (dao.EmailExiste(login))
            {
                return false;
            }

            var utilisateur = new Utilisateur
            {
                Login = login,
                Password = password,
                Nom = nom,
                Prenom = prenom
            };
            string Passwordhash = HashPassword(password);
            return dao.Inscrire(utilisateur);
        }

        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }
    }
}