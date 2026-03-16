using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using StadiumCompany.Database;
using StadiumCompany.Models;

namespace StadiumCompany.DAO
{
    public class SignalementDAO
    {
        private readonly DBConnexion dbConnexion = new DBConnexion();

        public List<Signalement> GetTousLesSignalements()
        {
            List<Signalement> liste = new List<Signalement>();
            try
            {
                using (MySqlConnection conn = dbConnexion.GetConnexion())
                {
                    conn.Open();
                    string sql = @"
                        SELECT s.id, s.id_utilisateur, u.login,
                               s.id_question, q.libelle AS libelle_question,
                               s.id_questionnaire, qn.nom AS nom_questionnaire,
                               s.message, s.date_envoi, s.statut
                        FROM signalement s
                        JOIN utilisateurs u   ON s.id_utilisateur   = u.id
                        JOIN question q       ON s.id_question      = q.id
                        JOIN questionnaire qn ON s.id_questionnaire = qn.id
                        ORDER BY s.date_envoi DESC";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            liste.Add(new Signalement
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                IdUtilisateur = Convert.ToInt32(reader["id_utilisateur"]),
                                LoginUtilisateur = reader["login"].ToString(),
                                IdQuestion = Convert.ToInt32(reader["id_question"]),
                                LibelleQuestion = reader["libelle_question"].ToString(),
                                IdQuestionnaire = Convert.ToInt32(reader["id_questionnaire"]),
                                NomQuestionnaire = reader["nom_questionnaire"].ToString(),
                                Message = reader["message"].ToString(),
                                DateEnvoi = Convert.ToDateTime(reader["date_envoi"]),
                                Statut = (StatutSignalement)Enum.Parse(
                                                       typeof(StatutSignalement),
                                                       reader["statut"].ToString())
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur DAO GetTousLesSignalements : " + ex.Message);
            }
            return liste;
        }

        public bool ModifierStatut(int id, StatutSignalement statut)
        {
            try
            {
                using (MySqlConnection conn = dbConnexion.GetConnexion())
                {
                    conn.Open();
                    string sql = "UPDATE signalement SET statut = @statut WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@statut", statut.ToString());
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur DAO ModifierStatut : " + ex.Message);
            }
            return false;
        }
    }
}