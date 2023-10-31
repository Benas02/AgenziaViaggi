using System.Data;
using System.Data.SqlClient;

namespace classReservations
{
    public class Reservation
    {
        #region "Parametri"
        // Declare ADO.NET objects
        SqlConnection connection;               // Represents a connection to the database
        SqlDataReader reader;                   // Represents a forward-only stream of data from the database
        SqlDataAdapter adapter;                 // Represents a set of data commands                  

        // Define the connection string to the SQL Server database
        string connectionString;
        #endregion

        #region "Costruttore"
        public Reservation()
        {
            this.connectionString = "Data Source=(local); Initial Catalog=prenotazioni; Integrated Security=True";
            this.connectToDB();
        }
        public Reservation(string server, string database)
        {
            this.connectionString = $"Data Source={server}; Initial Catalog={database}; Integrated Security=True";
            this.connectToDB();
        }
        public Reservation(string server, string database, string username, string password)
        {
            this.connectionString = $"user id={username};data source='{server}';persist security info=True;initial catalog={database};password={password};MultipleActiveResultSets=true";
            this.connectToDB();
        }
        #endregion

        #region "Connessione al DataBase"
        private void connectToDB()
        {
            this.connection = new SqlConnection(this.connectionString);
            this.connection.Open();
        }
        #endregion

        #region "Customers"
        public DataTable Customers()
        {
            string queryString;
            SqlCommand command;                     // Represents a SQL command to be executed
            DataTable dataTable;                    // Represents an in-memory table to store data
            DataSet dataSet;                        // Represents a dataset to hold multiple tables

            // Define the SQL query to retrieve data from the "clienti" table
            queryString = "SELECT * FROM clienti";

            // Create a new SQL command with the query and a database connection
            command = new SqlCommand(queryString, this.connection);

            // Create a data adapter with the query and the same database connection
            adapter = new SqlDataAdapter(queryString, this.connection);

            // Create a new dataset to store the retrieved data
            dataSet = new DataSet();

            // Fill the dataset with data from the "clienti" table
            adapter.Fill(dataSet, "Clienti");

            // Retrieve the DataTable containing the data from the dataset
            dataTable = dataSet.Tables["Clienti"];

            // Return the DataTable containing the retrieved data
            return dataTable;
        }

//  -------------------------------------------------------------------------------------------------
        public DataTable Customers(string nome, string cognome)
        {
            string queryString;
            SqlCommand command;                     // Represents a SQL command to be executed
            DataTable dataTable;                    // Represents an in-memory table to store data
            DataSet dataSet;         

            // Define the SQL query to retrieve data from the "clienti" table
            queryString = "SELECT * FROM clienti WHERE nome = '" + nome + "' AND cognome = '" + cognome + "'";

            // Create a new SQL command with the query and a database connection
            command = new SqlCommand(queryString, this.connection);

            // Create a data adapter with the query and the same database connection
            adapter = new SqlDataAdapter(queryString, this.connection);

            // Create a new dataset to store the retrieved data
            dataSet = new DataSet();

            // Fill the dataset with data from the "clienti" table
            adapter.Fill(dataSet, "Clienti");

            // Retrieve the DataTable containing the data from the dataset
            dataTable = dataSet.Tables["Clienti"];

            // Return the DataTable containing the retrieved data
            return dataTable;
        }
        #endregion
    }
}