﻿namespace ReservationManager
{
    partial class frmCitta
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
            System.Windows.Forms.Label cittaLabel;
            System.Windows.Forms.Label provincia_siglaLabel;
            System.Windows.Forms.Label regioneLabel;
            System.Windows.Forms.Label provincia_nomeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCitta));
            this.prenotazioniDataSet = new ReservationManager.prenotazioniDataSet();
            this.cittaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cittaTableAdapter = new ReservationManager.prenotazioniDataSetTableAdapters.cittaTableAdapter();
            this.tableAdapterManager = new ReservationManager.prenotazioniDataSetTableAdapters.TableAdapterManager();
            this.regioniTableAdapter = new ReservationManager.prenotazioniDataSetTableAdapters.regioniTableAdapter();
            this.cittaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cittaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cittaTextBox = new System.Windows.Forms.TextBox();
            this.provincia_siglaTextBox = new System.Windows.Forms.TextBox();
            this.regioneComboBox = new System.Windows.Forms.ComboBox();
            this.regioniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provincia_nomeTextBox = new System.Windows.Forms.TextBox();
            this.prenotazioniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prenotazioniTableAdapter = new ReservationManager.prenotazioniDataSetTableAdapters.prenotazioniTableAdapter();
            this.clientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientiTableAdapter = new ReservationManager.prenotazioniDataSetTableAdapters.clientiTableAdapter();
            this.clientiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cittaLabel = new System.Windows.Forms.Label();
            provincia_siglaLabel = new System.Windows.Forms.Label();
            regioneLabel = new System.Windows.Forms.Label();
            provincia_nomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prenotazioniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cittaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cittaBindingNavigator)).BeginInit();
            this.cittaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regioniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prenotazioniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cittaLabel
            // 
            cittaLabel.AutoSize = true;
            cittaLabel.Location = new System.Drawing.Point(12, 43);
            cittaLabel.Name = "cittaLabel";
            cittaLabel.Size = new System.Drawing.Size(34, 16);
            cittaLabel.TabIndex = 1;
            cittaLabel.Text = "citta:";
            // 
            // provincia_siglaLabel
            // 
            provincia_siglaLabel.AutoSize = true;
            provincia_siglaLabel.Location = new System.Drawing.Point(278, 43);
            provincia_siglaLabel.Name = "provincia_siglaLabel";
            provincia_siglaLabel.Size = new System.Drawing.Size(97, 16);
            provincia_siglaLabel.TabIndex = 3;
            provincia_siglaLabel.Text = "provincia sigla:";
            // 
            // regioneLabel
            // 
            regioneLabel.AutoSize = true;
            regioneLabel.Location = new System.Drawing.Point(319, 91);
            regioneLabel.Name = "regioneLabel";
            regioneLabel.Size = new System.Drawing.Size(56, 16);
            regioneLabel.TabIndex = 5;
            regioneLabel.Text = "regione:";
            // 
            // provincia_nomeLabel
            // 
            provincia_nomeLabel.AutoSize = true;
            provincia_nomeLabel.Location = new System.Drawing.Point(12, 91);
            provincia_nomeLabel.Name = "provincia_nomeLabel";
            provincia_nomeLabel.Size = new System.Drawing.Size(102, 16);
            provincia_nomeLabel.TabIndex = 7;
            provincia_nomeLabel.Text = "provincia nome:";
            // 
            // prenotazioniDataSet
            // 
            this.prenotazioniDataSet.DataSetName = "prenotazioniDataSet";
            this.prenotazioniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cittaBindingSource
            // 
            this.cittaBindingSource.DataMember = "citta";
            this.cittaBindingSource.DataSource = this.prenotazioniDataSet;
            // 
            // cittaTableAdapter
            // 
            this.cittaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cittaTableAdapter = this.cittaTableAdapter;
            this.tableAdapterManager.clientiTableAdapter = null;
            this.tableAdapterManager.prenotazioni_backupTableAdapter = null;
            this.tableAdapterManager.prenotazioniTableAdapter = null;
            this.tableAdapterManager.regioniTableAdapter = this.regioniTableAdapter;
            this.tableAdapterManager.UpdateOrder = ReservationManager.prenotazioniDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // regioniTableAdapter
            // 
            this.regioniTableAdapter.ClearBeforeFill = true;
            // 
            // cittaBindingNavigator
            // 
            this.cittaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cittaBindingNavigator.BindingSource = this.cittaBindingSource;
            this.cittaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cittaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cittaBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cittaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cittaBindingNavigatorSaveItem});
            this.cittaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cittaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cittaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cittaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cittaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cittaBindingNavigator.Name = "cittaBindingNavigator";
            this.cittaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cittaBindingNavigator.Size = new System.Drawing.Size(589, 31);
            this.cittaBindingNavigator.TabIndex = 0;
            this.cittaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
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
            // cittaBindingNavigatorSaveItem
            // 
            this.cittaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cittaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cittaBindingNavigatorSaveItem.Image")));
            this.cittaBindingNavigatorSaveItem.Name = "cittaBindingNavigatorSaveItem";
            this.cittaBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.cittaBindingNavigatorSaveItem.Text = "Salva dati";
            this.cittaBindingNavigatorSaveItem.Click += new System.EventHandler(this.cittaBindingNavigatorSaveItem_Click);
            // 
            // cittaTextBox
            // 
            this.cittaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cittaBindingSource, "citta", true));
            this.cittaTextBox.Location = new System.Drawing.Point(52, 40);
            this.cittaTextBox.Name = "cittaTextBox";
            this.cittaTextBox.Size = new System.Drawing.Size(181, 22);
            this.cittaTextBox.TabIndex = 2;
            // 
            // provincia_siglaTextBox
            // 
            this.provincia_siglaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cittaBindingSource, "provincia_sigla", true));
            this.provincia_siglaTextBox.Location = new System.Drawing.Point(381, 40);
            this.provincia_siglaTextBox.Name = "provincia_siglaTextBox";
            this.provincia_siglaTextBox.Size = new System.Drawing.Size(100, 22);
            this.provincia_siglaTextBox.TabIndex = 4;
            // 
            // regioneComboBox
            // 
            this.regioneComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.regioniBindingSource, "regione", true));
            this.regioneComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cittaBindingSource, "regione", true));
            this.regioneComboBox.DataSource = this.regioniBindingSource;
            this.regioneComboBox.DisplayMember = "regione";
            this.regioneComboBox.FormattingEnabled = true;
            this.regioneComboBox.Location = new System.Drawing.Point(381, 88);
            this.regioneComboBox.Name = "regioneComboBox";
            this.regioneComboBox.Size = new System.Drawing.Size(177, 24);
            this.regioneComboBox.TabIndex = 6;
            this.regioneComboBox.ValueMember = "ID_regione";
            // 
            // regioniBindingSource
            // 
            this.regioniBindingSource.DataMember = "regioni";
            this.regioniBindingSource.DataSource = this.prenotazioniDataSet;
            // 
            // provincia_nomeTextBox
            // 
            this.provincia_nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cittaBindingSource, "provincia_nome", true));
            this.provincia_nomeTextBox.Location = new System.Drawing.Point(120, 88);
            this.provincia_nomeTextBox.Name = "provincia_nomeTextBox";
            this.provincia_nomeTextBox.Size = new System.Drawing.Size(180, 22);
            this.provincia_nomeTextBox.TabIndex = 8;
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
            // clientiBindingSource
            // 
            this.clientiBindingSource.DataMember = "clienti";
            this.clientiBindingSource.DataSource = this.prenotazioniDataSet;
            // 
            // clientiTableAdapter
            // 
            this.clientiTableAdapter.ClearBeforeFill = true;
            // 
            // clientiBindingSource1
            // 
            this.clientiBindingSource1.DataMember = "FK_clienti_citta";
            this.clientiBindingSource1.DataSource = this.cittaBindingSource;
            // 
            // clientiDataGridView
            // 
            this.clientiDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientiDataGridView.AutoGenerateColumns = false;
            this.clientiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.clientiDataGridView.DataSource = this.clientiBindingSource1;
            this.clientiDataGridView.Location = new System.Drawing.Point(42, 152);
            this.clientiDataGridView.Name = "clientiDataGridView";
            this.clientiDataGridView.RowHeadersWidth = 51;
            this.clientiDataGridView.RowTemplate.Height = 24;
            this.clientiDataGridView.Size = new System.Drawing.Size(497, 265);
            this.clientiDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 160;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cognome";
            this.dataGridViewTextBoxColumn3.HeaderText = "cognome";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 160;
            // 
            // frmCitta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 455);
            this.Controls.Add(this.clientiDataGridView);
            this.Controls.Add(provincia_nomeLabel);
            this.Controls.Add(this.provincia_nomeTextBox);
            this.Controls.Add(regioneLabel);
            this.Controls.Add(this.regioneComboBox);
            this.Controls.Add(provincia_siglaLabel);
            this.Controls.Add(this.provincia_siglaTextBox);
            this.Controls.Add(cittaLabel);
            this.Controls.Add(this.cittaTextBox);
            this.Controls.Add(this.cittaBindingNavigator);
            this.Name = "frmCitta";
            this.Text = "Anagrafica Città";
            this.Load += new System.EventHandler(this.frmCitta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prenotazioniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cittaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cittaBindingNavigator)).EndInit();
            this.cittaBindingNavigator.ResumeLayout(false);
            this.cittaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regioniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prenotazioniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private prenotazioniDataSet prenotazioniDataSet;
        private System.Windows.Forms.BindingSource cittaBindingSource;
        private prenotazioniDataSetTableAdapters.cittaTableAdapter cittaTableAdapter;
        private prenotazioniDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cittaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cittaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cittaTextBox;
        private System.Windows.Forms.TextBox provincia_siglaTextBox;
        private System.Windows.Forms.ComboBox regioneComboBox;
        private prenotazioniDataSetTableAdapters.regioniTableAdapter regioniTableAdapter;
        private System.Windows.Forms.BindingSource regioniBindingSource;
        private System.Windows.Forms.TextBox provincia_nomeTextBox;
        private System.Windows.Forms.BindingSource prenotazioniBindingSource;
        private prenotazioniDataSetTableAdapters.prenotazioniTableAdapter prenotazioniTableAdapter;
        private System.Windows.Forms.BindingSource clientiBindingSource;
        private prenotazioniDataSetTableAdapters.clientiTableAdapter clientiTableAdapter;
        private System.Windows.Forms.BindingSource clientiBindingSource1;
        private System.Windows.Forms.DataGridView clientiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}