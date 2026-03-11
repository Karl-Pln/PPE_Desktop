using MySql.Data.MySqlClient;
using StadiumCompany.Models;
using StadiumCompany.Database;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StadiumCompany.DAO
{
    public class QuestionnaireDAO
    {
        private readonly DBConnexion dbConnexion = new DBConnexion();

        public List<Questionnaire> GetAll()
        {
            List<Questionnaire> liste = new List<Questionnaire>();
            try
            {
                using (MySqlConnection conn = dbConnexion.GetConnexion())
                {
                    conn.Open();
                    string sql = @"
                        SELECT q.id, q.nom, q.theme_id, t.libelle AS theme_libelle,
                               COUNT(qu.id) AS nb_questions
                        FROM questionnaire q
                        JOIN theme t ON t.id = q.theme_id
                        LEFT JOIN question qu ON qu.questionnaire_id = q.id
                        GROUP BY q.id, q.nom, q.theme_id, t.libelle
                        ORDER BY q.nom";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var questionnaire = new Questionnaire
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Nom = reader["nom"].ToString(),
                                ThemeId = Convert.ToInt32(reader["theme_id"]),
                                ThemeLibelle = reader["theme_libelle"].ToString()
                            };
                            int nb = Convert.ToInt32(reader["nb_questions"]);
                            for (int i = 0; i < nb; i++) questionnaire.Questions.Add(new Question());
                            liste.Add(questionnaire);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur DAO GetAll questionnaires : " + ex.Message);
            }
            return liste;
        }

        public int Ajouter(Questionnaire questionnaire)
        {
            try
            {
                using (MySqlConnection conn = dbConnexion.GetConnexion())
                {
                    conn.Open();
                    string sql = "INSERT INTO questionnaire (nom, theme_id) VALUES (@nom, @theme_id); SELECT LAST_INSERT_ID();";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nom", questionnaire.Nom);
                        cmd.Parameters.AddWithValue("@theme_id", questionnaire.ThemeId);
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur DAO Ajouter questionnaire : " + ex.Message);
            }
            return -1;
        }

        public bool Modifier(Questionnaire questionnaire)
        {
            try
            {
                using (MySqlConnection conn = dbConnexion.GetConnexion())
                {
                    conn.Open();
                    string sql = "UPDATE questionnaire SET nom = @nom, theme_id = @theme_id WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nom", questionnaire.Nom);
                        cmd.Parameters.AddWithValue("@theme_id", questionnaire.ThemeId);
                        cmd.Parameters.AddWithValue("@id", questionnaire.Id);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur DAO Modifier questionnaire : " + ex.Message);
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
                    string sql = "DELETE FROM questionnaire WHERE id = @id";
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
                MessageBox.Show("Erreur DAO Supprimer questionnaire : " + ex.Message);
            }
            return false;
        }

        public List<Theme> GetThemes()
        {
            List<Theme> themes = new List<Theme>();
            try
            {
                using (MySqlConnection conn = dbConnexion.GetConnexion())
                {
                    conn.Open();
                    string sql = "SELECT id, libelle FROM theme ORDER BY libelle";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            themes.Add(new Theme
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Libelle = reader["libelle"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur DAO GetThemes : " + ex.Message);
            }
            return themes;
        }
    }
}