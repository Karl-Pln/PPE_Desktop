using MySql.Data.MySqlClient;
using StadiumCompany.Models;
using StadiumCompany.Database;
using System;
using System.Windows.Forms;

namespace StadiumCompany.DAO
{
    public class UtilisateurDAO
    {
        private readonly DBConnexion dbConnexion = new DBConnexion();

        public Utilisateur Connexion(string login, string password)
        {
            try
            {
                using (MySqlConnection conn = dbConnexion.GetConnexion())
                {
                    conn.Open();
                    string sql = "SELECT * FROM utilisateurs WHERE login = @login AND password = @password";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.AddWithValue("@password", password);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Utilisateur()
                                {
                                    Id = Convert.ToInt32(reader["id"]),
                                    Login = reader["login"].ToString(),
                                    Password = reader["password"].ToString(),
                                    Nom = reader["nom"].ToString(),
                                    Prenom = reader["prenom"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur DAO Connexion : " + ex.Message);
            }
            return null;
        }

        public bool EmailExiste(string login)
        {
            try
            {
                using (MySqlConnection conn = dbConnexion.GetConnexion())
                {
                    conn.Open();
                    string sql = "SELECT COUNT(*) FROM utilisateurs WHERE login = @login";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@login", login);
                        return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur DAO EmailExiste : " + ex.Message);
            }
            return false;
        }

        public bool Inscrire(Utilisateur u)
        {
            try
            {
                using (MySqlConnection conn = dbConnexion.GetConnexion())
                {
                    conn.Open();
                    string sql = "INSERT INTO utilisateurs (login, password, nom, prenom) VALUES (@login, @password, @nom, @prenom)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@login", u.Login);
                        cmd.Parameters.AddWithValue("@password", u.Password);
                        cmd.Parameters.AddWithValue("@nom", u.Nom);
                        cmd.Parameters.AddWithValue("@prenom", u.Prenom);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur DAO Inscrire : " + ex.Message);
            }
            return false;
        }
    }
}