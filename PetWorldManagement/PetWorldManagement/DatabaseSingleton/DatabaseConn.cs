using System.Data.SqlClient;


namespace PetWorldManagement
{
    public class DatabaseConn
    {
        private static DatabaseConn database = null;
        private SqlConnection connection;

        // Private constructor to prevent instantiation
        private DatabaseConn()
        {
            InitializedDataConnection();
        }

        // Singleton pattern with getInstance method
        public static DatabaseConn getInstance()
        {
            if (database == null)
            {
                database = new DatabaseConn();
            }
            return database;
        }

        // Method to get the connection
        public SqlConnection GetConnection()
        {
            // Ensure the connection is open before returning
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                InitializedDataConnection();
            }
            return connection;
        }

        public void InitializedDataConnection()
        {
            string connectionString = "Data Source=LAPTOP-MDIE4LJM\\SQLEXPRESS;Initial Catalog=PetManagement;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            connection = new SqlConnection(connectionString);
        }
    }
}
