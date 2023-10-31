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
        }
        #endregion
    }
}