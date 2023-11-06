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
    public partial class frmPrenotazioni : Form
    {
        public frmPrenotazioni()
        {
            InitializeComponent();
        }

        private void prenotazioniBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prenotazioniBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.prenotazioniDataSet);

        }

        private void frmPrenotazioni_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'prenotazioniDataSet.NomeCognome'. È possibile spostarla o rimuoverla se necessario.
            this.nomeCognomeTableAdapter.Fill(this.prenotazioniDataSet.NomeCognome);
            // TODO: questa riga di codice carica i dati nella tabella 'prenotazioniDataSet.clienti'. È possibile spostarla o rimuoverla se necessario.
            this.clientiTableAdapter.Fill(this.prenotazioniDataSet.clienti);
            // TODO: questa riga di codice carica i dati nella tabella 'prenotazioniDataSet.prenotazioni'. È possibile spostarla o rimuoverla se necessario.
            this.prenotazioniTableAdapter.Fill(this.prenotazioniDataSet.prenotazioni);

        }

        private void newCliente_Click(object sender, EventArgs e)
        {
            frmClienti clienteForm = new frmClienti();
            clienteForm.ShowDialog();

            this.clientiTableAdapter.Fill(this.prenotazioniDataSet.clienti);
        }
    }
}
