using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using StadiumCompany.Database;
using StadiumCompany.Models;

namespace StadiumCompany.DAO
{
    public class ScoreDAO
    {
        private readonly DBConnexion dbConnexion = new DBConnexion();

        public bool Enregistrer(Score s)
        {
            try
            {
                using (MySqlConnection conn = dbConnexion.GetConnexion())
                {
                    conn.Open();
                    string sql = @"INSERT INTO score (utilisateur_id, questionnaire_id, score, score_max, date_passage)
                                   VALUES (@uid, @qid, @score, @scoreMax, @date)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@uid", s.UtilisateurId);
                        cmd.Parameters.AddWithValue("@qid", s.QuestionnaireId);
                        cmd.Parameters.AddWithValue("@score", s.ScoreObtenu);
                        cmd.Parameters.AddWithValue("@scoreMax", s.ScoreMax);
                        cmd.Parameters.AddWithValue("@date", s.DatePassage);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur DAO Enregistrer score : " + ex.Message);
            }
            return false;
        }

        public List<Score> GetByUtilisateur(int utilisateurId)
        {
            List<Score> liste = new List<Score>();
            try
            {
                using (MySqlConnection conn = dbConnexion.GetConnexion())
                {
                    conn.Open();
                    string sql = @"SELECT s.*, q.nom AS questionnaire_nom
                                   FROM score s
                                   JOIN questionnaire q ON q.id = s.questionnaire_id
                                   WHERE s.utilisateur_id = @uid
                                   ORDER BY s.date_passage DESC";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@uid", utilisateurId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                liste.Add(new Score
                                {
                                    Id = Convert.ToInt32(reader["id"]),
                                    UtilisateurId = utilisateurId,
                                    QuestionnaireId = Convert.ToInt32(reader["questionnaire_id"]),
                                    QuestionnaireNom = reader["questionnaire_nom"].ToString(),
                                    ScoreObtenu = Convert.ToInt32(reader["score"]),
                                    ScoreMax = Convert.ToInt32(reader["score_max"]),
                                    DatePassage = Convert.ToDateTime(reader["date_passage"])
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur DAO GetByUtilisateur : " + ex.Message);
            }
            return liste;
        }
    }
}