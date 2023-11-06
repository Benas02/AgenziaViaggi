namespace ReservationManager
{
    partial class frmRegioni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegioni));
            System.Windows.Forms.Label regioneLabel;
            System.Windows.Forms.Label area_geograficaLabel;
            this.prenotazioniDataSet = new ReservationManager.prenotazioniDataSet();
            this.regioniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regioniTableAdapter = new ReservationManager.prenotazioniDataSetTableAdapters.regioniTableAdapter();
            this.tableAdapterManager = new ReservationManager.prenotazioniDataSetTableAdapters.TableAdapterManager();
            this.regioniBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.regioniBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.regioneTextBox = new System.Windows.Forms.TextBox();
            this.area_geograficaTextBox = new System.Windows.Forms.TextBox();
            this.cittaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cittaTableAdapter = new ReservationManager.prenotazioniDataSetTableAdapters.cittaTableAdapter();
            this.cittaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            regioneLabel = new System.Windows.Forms.Label();
            area_geograficaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prenotazioniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regioniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regioniBindingNavigator)).BeginInit();
            this.regioniBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cittaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cittaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // prenotazioniDataSet
            // 
            this.prenotazioniDataSet.DataSetName = "prenotazioniDataSet";
            this.prenotazioniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // regioniBindingSource
            // 
            this.regioniBindingSource.DataMember = "regioni";
            this.regioniBindingSource.DataSource = this.prenotazioniDataSet;
            // 
            // regioniTableAdapter
            // 
            this.regioniTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cittaTableAdapter = null;
            this.tableAdapterManager.clientiTableAdapter = null;
            this.tableAdapterManager.NomeCognomeTableAdapter = null;
            this.tableAdapterManager.prenotazioni_backupTableAdapter = null;
            this.tableAdapterManager.prenotazioniTableAdapter = null;
            this.tableAdapterManager.regioniTableAdapter = this.regioniTableAdapter;
            this.tableAdapterManager.UpdateOrder = ReservationManager.prenotazioniDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // regioniBindingNavigator
            // 
            this.regioniBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.regioniBindingNavigator.BindingSource = this.regioniBindingSource;
            this.regioniBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.regioniBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.regioniBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.regioniBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.regioniBindingNavigatorSaveItem});
            this.regioniBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.regioniBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.regioniBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.regioniBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.regioniBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.regioniBindingNavigator.Name = "regioniBindingNavigator";
            this.regioniBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.regioniBindingNavigator.Size = new System.Drawing.Size(772, 27);
            this.regioniBindingNavigator.TabIndex = 0;
            this.regioniBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Aggiungi nuovo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 24);
            this.bindingNavigatorCountItem.Text = "di {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Numero totale di elementi";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Elimina";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Sposta in prima posizione";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Sposta indietro";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posizione";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posizione corrente";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Sposta avanti";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Sposta in ultima posizione";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // regioniBindingNavigatorSaveItem
            // 
            this.regioniBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.regioniBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("regioniBindingNavigatorSaveItem.Image")));
            this.regioniBindingNavigatorSaveItem.Name = "regioniBindingNavigatorSaveItem";
            this.regioniBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.regioniBindingNavigatorSaveItem.Text = "Salva dati";
            this.regioniBindingNavigatorSaveItem.Click += new System.EventHandler(this.regioniBindingNavigatorSaveItem_Click);
            // 
            // regioneLabel
            // 
            regioneLabel.AutoSize = true;
            regioneLabel.Location = new System.Drawing.Point(12, 53);
            regioneLabel.Name = "regioneLabel";
            regioneLabel.Size = new System.Drawing.Size(56, 16);
            regioneLabel.TabIndex = 1;
            regioneLabel.Text = "regione:";
            // 
            // regioneTextBox
            // 
            this.regioneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.regioniBindingSource, "regione", true));
            this.regioneTextBox.Location = new System.Drawing.Point(74, 50);
            this.regioneTextBox.Name = "regioneTextBox";
            this.regioneTextBox.Size = new System.Drawing.Size(164, 22);
            this.regioneTextBox.TabIndex = 2;
            // 
            // area_geograficaLabel
            // 
            area_geograficaLabel.AutoSize = true;
            area_geograficaLabel.Location = new System.Drawing.Point(322, 53);
            area_geograficaLabel.Name = "area_geograficaLabel";
            area_geograficaLabel.Size = new System.Drawing.Size(106, 16);
            area_geograficaLabel.TabIndex = 3;
            area_geograficaLabel.Text = "area geografica:";
            // 
            // area_geograficaTextBox
            // 
            this.area_geograficaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.regioniBindingSource, "area_geografica", true));
            this.area_geograficaTextBox.Location = new System.Drawing.Point(434, 50);
            this.area_geograficaTextBox.Name = "area_geograficaTextBox";
            this.area_geograficaTextBox.Size = new System.Drawing.Size(186, 22);
            this.area_geograficaTextBox.TabIndex = 4;
            // 
            // cittaBindingSource
            // 
            this.cittaBindingSource.DataMember = "FK_citta_regioni";
            this.cittaBindingSource.DataSource = this.regioniBindingSource;
            // 
            // cittaTableAdapter
            // 
            this.cittaTableAdapter.ClearBeforeFill = true;
            // 
            // cittaDataGridView
            // 
            this.cittaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cittaDataGridView.AutoGenerateColumns = false;
            this.cittaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cittaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3});
            this.cittaDataGridView.DataSource = this.cittaBindingSource;
            this.cittaDataGridView.Location = new System.Drawing.Point(32, 102);
            this.cittaDataGridView.Name = "cittaDataGridView";
            this.cittaDataGridView.RowHeadersWidth = 51;
            this.cittaDataGridView.RowTemplate.Height = 24;
            this.cittaDataGridView.Size = new System.Drawing.Size(709, 304);
            this.cittaDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_citta";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_citta";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "citta";
            this.dataGridViewTextBoxColumn2.HeaderText = "Citta";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "provincia_nome";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nome Provincia";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "provincia_sigla";
            this.dataGridViewTextBoxColumn3.HeaderText = "Sigla Provincia";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // frmRegioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 432);
            this.Controls.Add(this.cittaDataGridView);
            this.Controls.Add(area_geograficaLabel);
            this.Controls.Add(this.area_geograficaTextBox);
            this.Controls.Add(regioneLabel);
            this.Controls.Add(this.regioneTextBox);
            this.Controls.Add(this.regioniBindingNavigator);
            this.Name = "frmRegioni";
            this.Text = "Anagrafica Regioni";
            this.Load += new System.EventHandler(this.frmRegioni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prenotazioniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regioniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regioniBindingNavigator)).EndInit();
            this.regioniBindingNavigator.ResumeLayout(false);
            this.regioniBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cittaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cittaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private prenotazioniDataSet prenotazioniDataSet;
        private System.Windows.Forms.BindingSource regioniBindingSource;
        private prenotazioniDataSetTableAdapters.regioniTableAdapter regioniTableAdapter;
        private prenotazioniDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator regioniBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton regioniBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox regioneTextBox;
        private System.Windows.Forms.TextBox area_geograficaTextBox;
        private System.Windows.Forms.BindingSource cittaBindingSource;
        private prenotazioniDataSetTableAdapters.cittaTableAdapter cittaTableAdapter;
        private System.Windows.Forms.DataGridView cittaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}