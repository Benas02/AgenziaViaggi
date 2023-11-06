using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationManager
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Regioni_Click(object sender, EventArgs e)
        {
            frmRegioni frmRegioni = new frmRegioni();
            frmRegioni.ShowDialog();
        }

        private void Citta_Click(object sender, EventArgs e)
        {
            frmCitta frmCitta = new frmCitta();
            frmCitta.ShowDialog();
        }

        private void Clienti_Click(object sender, EventArgs e)
        {
            frmClienti frmClienti = new frmClienti();
            frmClienti.ShowDialog();
        }

        private void Prenotazioni_Click(object sender, EventArgs e)
        {
            frmPrenotazioni frmPrenotazioni = new frmPrenotazioni();
            frmPrenotazioni.ShowDialog();
        }
    }
}
