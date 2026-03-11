using MySql.Data.MySqlClient;

namespace StadiumCompany.Database
{
    public class DBConnexion
    {
        private static readonly string connectionString =
            "Server=localhost;" +
            "Database=ppe_stadiumcompany;" +
            "User=root;" +
            "Password=password;";

        public MySqlConnection GetConnexion()
        {
            return new MySqlConnection(connectionString);
        }
    }
}