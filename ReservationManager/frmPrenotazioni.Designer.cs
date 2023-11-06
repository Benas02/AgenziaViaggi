namespace ReservationManager
{
    partial class frmPrenotazioni
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.prenotazioniDataSet = new ReservationManager.prenotazioniDataSet();
            this.prenotazioniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prenotazioniTableAdapter = new ReservationManager.prenotazioniDataSetTableAdapters.prenotazioniTableAdapter();
            this.tableAdapterManager = new ReservationManager.prenotazioniDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.prenotazioniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prenotazioniBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // prenotazioniDataSet
            // 
            this.prenotazioniDataSet.DataSetName = "prenotazioniDataSet";
            this.prenotazioniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prenotazioniBindingSource
            // 
            this.prenotazioniBindingSource.DataMember = "prenotazioni";
            this.prenotazioniBindingSource.DataSource = this.prenotazioniDataSet;
            // 
            // prenotazioniTableAdapter
            // 
            this.prenotazioniTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cittaTableAdapter = null;
            this.tableAdapterManager.clientiTableAdapter = null;
            this.tableAdapterManager.prenotazioni_backupTableAdapter = null;
            this.tableAdapterManager.prenotazioniTableAdapter = this.prenotazioniTableAdapter;
            this.tableAdapterManager.regioniTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ReservationManager.prenotazioniDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmPrenotazioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmPrenotazioni";
            this.Text = "frmPrenotazioni";
            this.Load += new System.EventHandler(this.Prenotazioni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prenotazioniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prenotazioniBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private prenotazioniDataSet prenotazioniDataSet;
        private System.Windows.Forms.BindingSource prenotazioniBindingSource;
        private prenotazioniDataSetTableAdapters.prenotazioniTableAdapter prenotazioniTableAdapter;
        private prenotazioniDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}