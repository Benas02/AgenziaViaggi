using classReservations;
using System.Data;

namespace TestReservation
{
    [TestClass]
    public class TestReservation
    {
        #region "Count Customers"
        [TestMethod]
        public void Customers()
        {
            Reservation reservation = new Reservation();
            DataTable customers;

            customers = reservation.Customers();

            if (customers == null)
            {
                throw new Exception("Customers Load Failed");
            }

            if (customers.Rows.Count != 930)
            {
                //test DB contains 930 customers
                throw new Exception("Customers Count Doesn't Match");
            }            
        }
        #endregion

        #region "Customers Nome e Cognome"
        [TestMethod]
        public void CustomersNameSurname()
        {
            Reservation reservation = new Reservation();
            DataTable customers;

            customers = reservation.Customers("Claudio", "Rossi");

            if (customers == null)
            {
                throw new Exception("Customers Load Failed");
            }

            if (customers.Rows.Count != 5)
            {
                //test DB contains 5 customers
                throw new Exception("Customers Count Doesn't Match");
            }

            customers = reservation.Customers("Leo", "Messi");

            if (customers == null)
            {
                throw new Exception("Customers Load Failed");
            }

            if (customers.Rows.Count != 0)
            {
                //test DB contains 5 customers
                throw new Exception("Customers Count Doesn't Match");
            }
        }
        #endregion

        #region "Count Reservations"
        [TestMethod]
        public void Reservations()
        {
            Reservation reservation = new Reservation();
            DataTable customers;

            customers = reservation.Reservations();

            if (customers == null)
            {
                throw new Exception("Reservations Load Failed");
            }

            if (customers.Rows.Count != 9268)
            {
                //test DB contains 9268 customers
                throw new Exception("Reservations Count Doesn't Match");
            }
        }
        #endregion

        #region "Reservations ID"
        [TestMethod]
        public void ReservationsID()
        {
            Reservation reservation = new Reservation();
            DataTable customers;

            customers = reservation.Reservations(21);

            if (customers == null)
            {
                throw new Exception("Reservations Load Failed");
            }

            if (customers.Rows.Count != 1)
            {
                //test DB contains 5 customers
                throw new Exception("Reservations Count Doesn't Match");
            }

            customers = reservation.Reservations(12345);

            if (customers == null)
            {
                throw new Exception("Reservations Load Failed");
            }

            if (customers.Rows.Count != 0)
            {
                //test DB contains 5 customers
                throw new Exception("Reservations Count Doesn't Match");
            }
        }
        #endregion
    }
}