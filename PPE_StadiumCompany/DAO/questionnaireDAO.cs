using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using StadiumCompany.Database;
using StadiumCompany.Models;

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
                        SELECT q.id, q.nom, q.theme_id, q.createur_id,
                               t.libelle AS theme_libelle,
                               COUNT(qu.id) AS nb_questions
                        FROM questionnaire q
                        JOIN theme t ON t.id = q.theme_id
                        LEFT JOIN question qu ON qu.questionnaire_id = q.id
                        GROUP BY q.id, q.nom, q.theme_id, q.createur_id, t.libelle
                        ORDER BY q.nom";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var qst = new Questionnaire
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Nom = reader["nom"].ToString(),
                                ThemeId = Convert.ToInt32(reader["theme_id"]),
                                ThemeLibelle = reader["theme_libelle"].ToString(),
                                CreateurId = Convert.ToInt32(reader["createur_id"])
                            };
                            int nb = Convert.ToInt32(reader["nb_questions"]);
                            for (int i = 0; i < nb; i++) qst.Questions.Add(new Question());
                            liste.Add(qst);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur DAO GetAll : " + ex.Message);
            }
            return liste;
        }

        public Questionnaire GetById(int id)
        {
            try
            {
                using (MySqlConnection conn = dbConnexion.GetConnexion())
                {
                    conn.Open();
                    string sql = @"
                        SELECT q.id, q.nom, q.theme_id, q.createur_id, t.libelle AS theme_libelle
                        FROM questionnaire q
                        JOIN theme t ON t.id = q.theme_id
                        WHERE q.id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Questionnaire
                                {
                                    Id = Convert.ToInt32(reader["id"]),
                                    Nom = reader["nom"].ToString(),
                                    ThemeId = Convert.ToInt32(reader["theme_id"]),
                                    ThemeLibelle = reader["theme_libelle"].ToString(),
                                    CreateurId = Convert.ToInt32(reader["createur_id"])
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur DAO GetById : " + ex.Message);
            }
            return null;
        }

        public int Ajouter(Questionnaire q)
        {
            try
            {
                using (MySqlConnection conn = dbConnexion.GetConnexion())
                {
                    conn.Open();
                    string sql = @"INSERT INTO questionnaire (nom, theme_id, createur_id)
                                   VALUES (@nom, @theme_id, @createur_id);
                                   SELECT LAST_INSERT_ID();";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nom", q.Nom);
                        cmd.Parameters.AddWithValue("@theme_id", q.ThemeId);
                        cmd.Parameters.AddWithValue("@createur_id", q.CreateurId);
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

        public bool Modifier(Questionnaire q)
        {
            try
            {
                using (MySqlConnection conn = dbConnexion.GetConnexion())
                {
                    conn.Open();
                    string sql = "UPDATE questionnaire SET nom = @nom, theme_id = @theme_id WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nom", q.Nom);
                        cmd.Parameters.AddWithValue("@theme_id", q.ThemeId);
                        cmd.Parameters.AddWithValue("@id", q.Id);
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