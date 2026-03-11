namespace StadiumCompany.Models
{
    public class ReponsePossible
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Libelle { get; set; }
        public bool EstCorrecte { get; set; }
        public int Poids { get; set; } // Sprint 3
    }
}