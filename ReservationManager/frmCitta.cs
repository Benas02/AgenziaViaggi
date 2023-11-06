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
    public partial class frmCitta : Form
    {
        public frmCitta()
        {
            InitializeComponent();
        }

        private void cittaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cittaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.prenotazioniDataSet);

        }

        private void frmCitta_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'prenotazioniDataSet.clienti'. È possibile spostarla o rimuoverla se necessario.
            this.clientiTableAdapter.Fill(this.prenotazioniDataSet.clienti);
            // TODO: questa riga di codice carica i dati nella tabella 'prenotazioniDataSet.clienti'. È possibile spostarla o rimuoverla se necessario.
            this.clientiTableAdapter.Fill(this.prenotazioniDataSet.clienti);
            // TODO: questa riga di codice carica i dati nella tabella 'prenotazioniDataSet.clienti'. È possibile spostarla o rimuoverla se necessario.
            this.clientiTableAdapter.Fill(this.prenotazioniDataSet.clienti);
            // TODO: questa riga di codice carica i dati nella tabella 'prenotazioniDataSet.prenotazioni'. È possibile spostarla o rimuoverla se necessario.
            this.prenotazioniTableAdapter.Fill(this.prenotazioniDataSet.prenotazioni);
            // TODO: questa riga di codice carica i dati nella tabella 'prenotazioniDataSet.regioni'. È possibile spostarla o rimuoverla se necessario.
            this.regioniTableAdapter.Fill(this.prenotazioniDataSet.regioni);
            // TODO: questa riga di codice carica i dati nella tabella 'prenotazioniDataSet.citta'. È possibile spostarla o rimuoverla se necessario.
            this.cittaTableAdapter.Fill(this.prenotazioniDataSet.citta);

        }
    }
}
