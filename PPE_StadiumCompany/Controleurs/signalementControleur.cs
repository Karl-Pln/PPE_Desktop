using System.Collections.Generic;
using StadiumCompany.DAO;
using StadiumCompany.Models;

namespace StadiumCompany.Controllers
{
    public class SignalementController
    {
        private readonly SignalementDAO dao = new SignalementDAO();

        public List<Signalement> GetTousLesSignalements()
        {
            return dao.GetTousLesSignalements();
        }

        public bool ModifierStatut(int id, StatutSignalement statut)
        {
            if (id <= 0) return false;
            return dao.ModifierStatut(id, statut);
        }
    }
}