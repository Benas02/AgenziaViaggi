using System.Data;
using System.Runtime.CompilerServices;
using classReservations;

Reservation reservation = new Reservation();
setScelta();

#region "Stampa Menu"
int stampaMenu()
{
    int answer;

    Console.WriteLine("\n---------------------------------");

    // Display the menu options
    Console.WriteLine("\n1) VISUALIZZARE TUTTI I CLIENTI");
    Console.WriteLine("2) VISUALIZZARE CLIENTE (NOME - COGNOME)");
    Console.WriteLine("3) VISUALIZZARE TUTTE LE PRENOTAZIONI");
    Console.WriteLine("4) VISUALIZZARE PRENOTAZIONE (ID)");
    Console.WriteLine("5) VISUALIZZARE PRENOTAZIONE (NOME - COGNOME)");
    Console.WriteLine("0) USCIRE");

    do
    {
        // Prompt the user to select an action and read the input as an integer
        Console.Write("\nSelezionare l'Azione da Eseguire (0-5): ");
        answer = Int32.Parse(Console.ReadLine());
    } while (answer < 0 || answer > 5);

    return answer;
}
#endregion

#region "Set Scelta"
void setScelta()
{
    int menu;

    do
    {
        // Display the menu and get the user's selection
        menu = stampaMenu();

        switch (menu)
        {
            case 1:
                printClienti(reservation.Customers());
                break;
            case 2:
                CustomersNameSurname(reservation);
                break;
            case 3:
                reservation.Reservations();
                break;
            case 4:
                int idReservations;

                do
                {
                    Console.Write("\nID: ");
                    idReservations = Int32.Parse(Console.ReadLine());
                } while (idReservations < 0);

                reservation.Reservations(idReservations);
                break;
            case 5:
                string firstNameReservations;
                Console.Write("\nFirst Name: ");
                firstNameReservations = Console.ReadLine();

                string secondNameReservations;
                Console.Write("\nSecond Name: ");
                secondNameReservations = Console.ReadLine();

                reservation.Reservations(firstNameReservations, secondNameReservations);
                break;
            case 0:
                // Action 0: Exit the program (commented out)
                //Environment.Exit(0);              // CHIUDE IL PROGRAMMA
                break;
            default:
                Console.WriteLine("ERROR");
                break;
        }
    } while (menu != 0);
}
#endregion

void CustomersNameSurname(Reservation reservation)
{
    string firstNameCustomers;
    Console.Write("\nFirst Name: ");
    firstNameCustomers = Console.ReadLine();

    string secondNameCustomers;
    Console.Write("Second Name: ");
    secondNameCustomers = Console.ReadLine();

    printClienti(reservation.Customers(firstNameCustomers, secondNameCustomers));
}

#region "Print Clienti"
void printClienti(DataTable clienti)
{
    foreach (DataRow row in clienti.Rows)
    {
        // Print the values of "id_cliente," "nome," and "cognome" columns for the current row to the console.
        Console.WriteLine($"{row["id_cliente"], -5} \t{row["nome"],-10} \t{row["cognome"], -10} \t{row["dataNascita"], -10} \t{row["NomeCitta"]}");
    }
}
#endregion

#region "Print Prenotazioni"
void printPrenotazioni(DataTable clienti)
{
    foreach (DataRow row in clienti.Rows)
    {
        // Print the values of "id_cliente," "nome," and "cognome" columns for the current row to the console.
        Console.WriteLine($"{row["nome"],-10} \t{row["cognome"],-10} \t{row["dataNascita"],-10} \t{row["NomeCitta"]}");
    }
}
#endregion