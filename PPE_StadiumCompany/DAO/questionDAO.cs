using MySql.Data.MySqlClient;
using StadiumCompany.Models;
using StadiumCompany.Database;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StadiumCompany.DAO
{
    public class QuestionDAO
    {
        private readonly DBConnexion dbConnexion = new DBConnexion();

        public List<Question> GetByQuestionnaire(int questionnaireId)
        {
            List<Question> liste = new List<Question>();
            try
            {
                using (MySqlConnection conn = dbConnexion.GetConnexion())
                {
                    conn.Open();
                    string sql = "SELECT * FROM question WHERE questionnaire_id = @qid ORDER BY ordre, id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@qid", questionnaireId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                liste.Add(new Question
                                {
                                    Id = Convert.ToInt32(reader["id"]),
                                    QuestionnaireId = questionnaireId,
                                    Libelle = reader["libelle"].ToString(),
                                    TypeReponse = reader["type_reponse"].ToString() == "VraiFaux"
                                                         ? TypeReponse.VraiFaux
                                                         : TypeReponse.ListeValeurs,
                                    Ordre = Convert.ToInt32(reader["ordre"])
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur DAO GetByQuestionnaire : " + ex.Message);
            }
            return liste;
        }

        public int Ajouter(Question q)
        {
            try
            {
                using (MySqlConnection conn = dbConnexion.GetConnexion())
                {
                    conn.Open();
                    string sql = @"INSERT INTO question (questionnaire_id, libelle, type_reponse, ordre)
                                   VALUES (@qid, @libelle, @type, @ordre);
                                   SELECT LAST_INSERT_ID();";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@qid", q.QuestionnaireId);
                        cmd.Parameters.AddWithValue("@libelle", q.Libelle);
                        cmd.Parameters.AddWithValue("@type", q.TypeReponse.ToString());
                        cmd.Parameters.AddWithValue("@ordre", q.Ordre);
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur DAO Ajouter question : " + ex.Message);
            }
            return -1;
        }

        public bool Modifier(Question q)
        {
            try
            {
                using (MySqlConnection conn = dbConnexion.GetConnexion())
                {
                    conn.Open();
                    string sql = "UPDATE question SET libelle = @libelle, type_reponse = @type, ordre = @ordre WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@libelle", q.Libelle);
                        cmd.Parameters.AddWithValue("@type", q.TypeReponse.ToString());
                        cmd.Parameters.AddWithValue("@ordre", q.Ordre);
                        cmd.Parameters.AddWithValue("@id", q.Id);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur DAO Modifier question : " + ex.Message);
            }
            return false;
        }

        public bool Supprimer(int id)
        {
            try
            {
                using (MySqlConnection conn = dbConnexion.GetConnexion())
                {
                    conn.Open();
                    string sql = "DELETE FROM question WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur DAO Supprimer question : " + ex.Message);
            }
            return false;
        }
    }
}