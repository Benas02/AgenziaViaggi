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
    public partial class frmRegioni : Form
    {
        public frmRegioni()
        {
            InitializeComponent();
        }

        private void regioniBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.regioniBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.prenotazioniDataSet);

        }

        private void frmRegioni_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'prenotazioniDataSet.citta'. È possibile spostarla o rimuoverla se necessario.
            this.cittaTableAdapter.Fill(this.prenotazioniDataSet.citta);
            // TODO: questa riga di codice carica i dati nella tabella 'prenotazioniDataSet.regioni'. È possibile spostarla o rimuoverla se necessario.
            this.regioniTableAdapter.Fill(this.prenotazioniDataSet.regioni);

        }
    }
}
