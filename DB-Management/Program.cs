using System.Data;
using System.Data.SqlClient;

// Define the connection string to the SQL Server database
string connectionString = "Data Source=(local); Initial Catalog=prenotazioni; Integrated Security=True";

// Define the SQL query to select data from the 'clienti' table
string queryString = "SELECT * FROM clienti WHERE id_cliente < 10";

// Declare ADO.NET objects
SqlConnection connection;               // Represents a connection to the database
SqlCommand command;                     // Represents a SQL command to be executed
SqlDataReader reader;                   // Represents a forward-only stream of data from the database
SqlDataAdapter adapter;                 // Represents a set of data commands
DataTable dataTable;                    // Represents an in-memory table to store data

// Create a connection to the database using the connection string
using (connection = new SqlConnection(connectionString))
{
    // Create a SQL command with the query and the database connection
    command = new SqlCommand(queryString, connection);

    // Open the database connection
    connection.Open();

    // Execute the SQL query and retrieve the results into a SqlDataReader
    reader = command.ExecuteReader();

    // Iterate through the result set and print the data
    while (reader.Read()) {
        // Retrieve and print the values from the reader
        Console.WriteLine("{0}\t{1}\t\t{2}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
    }

    // Close the SqlDataReader to release resources
    reader.Close();
}