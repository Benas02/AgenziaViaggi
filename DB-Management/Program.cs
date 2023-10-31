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

// ------------------------------------------------------------------------------------------------

    Console.WriteLine("\n--------------------------------------------------\n");

// ------------------------------------------------------------------------------------------------

    // Create a new SqlDataAdapter and associate it with a query string and a database connection.
    adapter = new SqlDataAdapter(queryString, connection);

    // Create a new DataSet to store retrieved data from the database.
    DataSet dataSet = new DataSet();

    // Populate the DataSet with data from the database using the SqlDataAdapter.
    adapter.Fill(dataSet, "Clienti");

    // Retrieve the table named "Clienti" from the DataSet and store it in a variable.
    dataTable = dataSet.Tables["Clienti"];

    // Iterate through each row in the "Clienti" table.
    foreach (DataRow row in dataTable.Rows)
    {
        // Print the values of "id_cliente," "nome," and "cognome" columns for the current row to the console.
        Console.WriteLine($"{row["id_cliente"]} \t{row["nome"], -10} \t{row["cognome"]}");
    }

// ------------------------------------------------------------------------------------------------

    Console.WriteLine("\n--------------------------------------------------\n");

// ------------------------------------------------------------------------------------------------

    string textNome, textCognome;

    Console.Write("Nome: ");
    textNome = Console.ReadLine();

    Console.Write("Cognome: ");
    textCognome = Console.ReadLine();

    queryString = "SELECT * FROM prenotazioni JOIN clienti ON prenotazioni.cliente = clienti.ID_cliente " +
        "WHERE nome = '" + textNome + "' AND cognome = '" + textCognome + "'";

    // Create a new SqlDataAdapter and associate it with a query string and a database connection.
    adapter = new SqlDataAdapter(queryString, connection);

    // Create a new DataSet to store retrieved data from the database.
    dataSet = new DataSet();

    // Populate the DataSet with data from the database using the SqlDataAdapter.
    adapter.Fill(dataSet, "Clienti");

    // Retrieve the table named "Clienti" from the DataSet and store it in a variable.
    dataTable = dataSet.Tables["Clienti"];

    // Iterate through each row in the "Clienti" table.
    foreach (DataRow row in dataTable.Rows)
    {
        // Print the values of "id_cliente," "nome," and "cognome" columns for the current row to the console.
        Console.WriteLine($"{row["nome"]} \t{row["cognome"],-10} \t{row["arrivo"], -10} \t" +
            $"{ row["partenza"]} \t{ row["importo"],-10} \t{ row["tipo_struttura"], -10}");
    }
    
// ------------------------------------------------------------------------------------------------

    Console.WriteLine("\n--------------------------------------------------\n");

// ------------------------------------------------------------------------------------------------

    string regione, areaGeografica;

    Console.Write("Regione: ");
    regione = Console.ReadLine();

    Console.Write("Area Geografica: ");
    areaGeografica = Console.ReadLine();

    queryString = "INSERT INTO regioni (regione, area_geografica) " +
        "VALUES ('" + regione + "', '" + areaGeografica + "')";

    // Create a SQL command with the query and the database connection
    command = new SqlCommand(queryString, connection);

    // Open the database connection
    connection.Open();

    command.ExecuteNonQuery();

    // ------------------------------------------------------------------------------------------------
}