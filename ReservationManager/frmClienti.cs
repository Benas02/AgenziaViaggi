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
    public partial class frmClienti : Form
    {
        public frmClienti()
        {
            InitializeComponent();
        }

        private void clientiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.prenotazioniDataSet);

        }

        private void frmClienti_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'prenotazioniDataSet.prenotazioni'. È possibile spostarla o rimuoverla se necessario.
            this.prenotazioniTableAdapter.Fill(this.prenotazioniDataSet.prenotazioni);
            // TODO: questa riga di codice carica i dati nella tabella 'prenotazioniDataSet.citta'. È possibile spostarla o rimuoverla se necessario.
            this.cittaTableAdapter.Fill(this.prenotazioniDataSet.citta);
            // TODO: questa riga di codice carica i dati nella tabella 'prenotazioniDataSet.citta'. È possibile spostarla o rimuoverla se necessario.
            this.cittaTableAdapter.Fill(this.prenotazioniDataSet.citta);
            // TODO: questa riga di codice carica i dati nella tabella 'prenotazioniDataSet.clienti'. È possibile spostarla o rimuoverla se necessario.
            this.clientiTableAdapter.Fill(this.prenotazioniDataSet.clienti);

        }

        private void newCitta_Click(object sender, EventArgs e)
        {
            frmCitta cityForm = new frmCitta();
            cityForm.ShowDialog();

            this.cittaTableAdapter.Fill(this.prenotazioniDataSet.citta);
        }
    }
}
