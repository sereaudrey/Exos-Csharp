
namespace GestStagiaire
{
    partial class F_AfficheAuto
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stagiaireDataSet = new GestStagiaire.StagiaireDataSet();
            this.tStagiaireBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tStagiaireTableAdapter = new GestStagiaire.StagiaireDataSetTableAdapters.TStagiaireTableAdapter();
            this.idStagiaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomStagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomStagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateNaissanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stagiaireDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tStagiaireBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStagiaireDataGridViewTextBoxColumn,
            this.nomStagDataGridViewTextBoxColumn,
            this.prenomStagDataGridViewTextBoxColumn,
            this.sectionDataGridViewTextBoxColumn,
            this.dateNaissanceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tStagiaireBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 312);
            this.dataGridView1.TabIndex = 0;
            // 
            // stagiaireDataSet
            // 
            this.stagiaireDataSet.DataSetName = "StagiaireDataSet";
            this.stagiaireDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tStagiaireBindingSource
            // 
            this.tStagiaireBindingSource.DataMember = "TStagiaire";
            this.tStagiaireBindingSource.DataSource = this.stagiaireDataSet;
            // 
            // tStagiaireTableAdapter
            // 
            this.tStagiaireTableAdapter.ClearBeforeFill = true;
            // 
            // idStagiaireDataGridViewTextBoxColumn
            // 
            this.idStagiaireDataGridViewTextBoxColumn.DataPropertyName = "Id_Stagiaire";
            this.idStagiaireDataGridViewTextBoxColumn.HeaderText = "Id_Stagiaire";
            this.idStagiaireDataGridViewTextBoxColumn.Name = "idStagiaireDataGridViewTextBoxColumn";
            // 
            // nomStagDataGridViewTextBoxColumn
            // 
            this.nomStagDataGridViewTextBoxColumn.DataPropertyName = "NomStag";
            this.nomStagDataGridViewTextBoxColumn.HeaderText = "NomStag";
            this.nomStagDataGridViewTextBoxColumn.Name = "nomStagDataGridViewTextBoxColumn";
            // 
            // prenomStagDataGridViewTextBoxColumn
            // 
            this.prenomStagDataGridViewTextBoxColumn.DataPropertyName = "PrenomStag";
            this.prenomStagDataGridViewTextBoxColumn.HeaderText = "PrenomStag";
            this.prenomStagDataGridViewTextBoxColumn.Name = "prenomStagDataGridViewTextBoxColumn";
            // 
            // sectionDataGridViewTextBoxColumn
            // 
            this.sectionDataGridViewTextBoxColumn.DataPropertyName = "Section";
            this.sectionDataGridViewTextBoxColumn.HeaderText = "Section";
            this.sectionDataGridViewTextBoxColumn.Name = "sectionDataGridViewTextBoxColumn";
            // 
            // dateNaissanceDataGridViewTextBoxColumn
            // 
            this.dateNaissanceDataGridViewTextBoxColumn.DataPropertyName = "DateNaissance";
            this.dateNaissanceDataGridViewTextBoxColumn.HeaderText = "DateNaissance";
            this.dateNaissanceDataGridViewTextBoxColumn.Name = "dateNaissanceDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Fermer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F_AfficheAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "F_AfficheAuto";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.F_AfficheAuto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stagiaireDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tStagiaireBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private StagiaireDataSet stagiaireDataSet;
        private System.Windows.Forms.BindingSource tStagiaireBindingSource;
        private StagiaireDataSetTableAdapters.TStagiaireTableAdapter tStagiaireTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStagiaireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomStagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomStagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateNaissanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}