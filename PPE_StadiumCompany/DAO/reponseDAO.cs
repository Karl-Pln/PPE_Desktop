using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using StadiumCompany.Database;
using StadiumCompany.Models;

namespace StadiumCompany.DAO
{
    public class ReponsePossibleDAO
    {
        private readonly DBConnexion dbConnexion = new DBConnexion();

        public List<ReponsePossible> GetByQuestion(int questionId)
        {
            List<ReponsePossible> liste = new List<ReponsePossible>();
            try
            {
                using (MySqlConnection conn = dbConnexion.GetConnexion())
                {
                    conn.Open();
                    string sql = "SELECT * FROM reponse_possible WHERE question_id = @qid";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@qid", questionId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                liste.Add(new ReponsePossible
                                {
                                    Id = Convert.ToInt32(reader["id"]),
                                    QuestionId = questionId,
                                    Libelle = reader["libelle"].ToString(),
                                    EstCorrecte = Convert.ToBoolean(reader["est_correcte"]),
                                    Poids = Convert.ToInt32(reader["poids"])
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur DAO GetByQuestion : " + ex.Message);
            }
            return liste;
        }

        public int Ajouter(ReponsePossible r)
        {
            try
            {
                using (MySqlConnection conn = dbConnexion.GetConnexion())
                {
                    conn.Open();
                    string sql = @"INSERT INTO reponse_possible (question_id, libelle, est_correcte, poids)
                                   VALUES (@qid, @libelle, @correct, @poids);
                                   SELECT LAST_INSERT_ID();";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@qid", r.QuestionId);
                        cmd.Parameters.AddWithValue("@libelle", r.Libelle);
                        cmd.Parameters.AddWithValue("@correct", r.EstCorrecte);
                        cmd.Parameters.AddWithValue("@poids", r.Poids);
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur DAO Ajouter réponse : " + ex.Message);
            }
            return -1;
        }

        public bool Modifier(ReponsePossible r)
        {
            try
            {
                using (MySqlConnection conn = dbConnexion.GetConnexion())
                {
                    conn.Open();
                    string sql = "UPDATE reponse_possible SET libelle = @libelle, est_correcte = @correct, poids = @poids WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@libelle", r.Libelle);
                        cmd.Parameters.AddWithValue("@correct", r.EstCorrecte);
                        cmd.Parameters.AddWithValue("@poids", r.Poids);
                        cmd.Parameters.AddWithValue("@id", r.Id);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur DAO Modifier réponse : " + ex.Message);
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
                    string sql = "DELETE FROM reponse_possible WHERE id = @id";
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
                MessageBox.Show("Erreur DAO Supprimer réponse : " + ex.Message);
            }
            return false;
        }

        public bool SupprimerParQuestion(int questionId)
        {
            try
            {
                using (MySqlConnection conn = dbConnexion.GetConnexion())
                {
                    conn.Open();
                    string sql = "DELETE FROM reponse_possible WHERE question_id = @qid";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@qid", questionId);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur DAO SupprimerParQuestion : " + ex.Message);
            }
            return false;
        }
    }
}