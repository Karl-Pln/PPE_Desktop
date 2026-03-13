using MySql.Data.MySqlClient;

namespace StadiumCompany.Database
{
    public class DBConnexion
    {
        private static readonly string connectionString =
            "Server=localhost;" +
            "Database=stadiumcompany;" +
            "User=root;" +
            "Password=password;";

        public MySqlConnection GetConnexion()
        {
            return new MySqlConnection(connectionString);
        }
    }
}