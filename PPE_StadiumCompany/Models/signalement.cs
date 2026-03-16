using System;

namespace StadiumCompany.Models
{
    public enum StatutSignalement
    {
        a_corriger,
        en_correction,
        corrige
    }

    public class Signalement
    {
        public int Id { get; set; }
        public int IdUtilisateur { get; set; }
        public string LoginUtilisateur { get; set; }
        public int IdQuestion { get; set; }
        public string LibelleQuestion { get; set; }
        public int IdQuestionnaire { get; set; }
        public string NomQuestionnaire { get; set; }
        public string Message { get; set; }
        public DateTime DateEnvoi { get; set; }
        public StatutSignalement Statut { get; set; }
    }
}