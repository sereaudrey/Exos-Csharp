namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.GbSaisie = new System.Windows.Forms.GroupBox();
            this.CmdAjout = new System.Windows.Forms.Button();
            this.TxtSaisie = new System.Windows.Forms.TextBox();
            this.LblList1 = new System.Windows.Forms.Label();
            this.CmdDel1 = new System.Windows.Forms.Button();
            this.CmdFin = new System.Windows.Forms.Button();
            this.LblList2 = new System.Windows.Forms.Label();
            this.CmdDel2 = new System.Windows.Forms.Button();
            this.CmdFlDr = new System.Windows.Forms.Button();
            this.CmdFlGa = new System.Windows.Forms.Button();
            this.ListBResult1 = new System.Windows.Forms.ListBox();
            this.ListBResult2 = new System.Windows.Forms.ListBox();
            this.GbSaisie.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbSaisie
            // 
            this.GbSaisie.BackColor = System.Drawing.Color.White;
            this.GbSaisie.Controls.Add(this.CmdAjout);
            this.GbSaisie.Controls.Add(this.TxtSaisie);
            this.GbSaisie.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbSaisie.Location = new System.Drawing.Point(33, 42);
            this.GbSaisie.Name = "GbSaisie";
            this.GbSaisie.Size = new System.Drawing.Size(554, 106);
            this.GbSaisie.TabIndex = 0;
            this.GbSaisie.TabStop = false;
            this.GbSaisie.Text = "Saisissez un texte pour l\'intégrer à la liste 1";
            // 
            // CmdAjout
            // 
            this.CmdAjout.Location = new System.Drawing.Point(411, 37);
            this.CmdAjout.Name = "CmdAjout";
            this.CmdAjout.Size = new System.Drawing.Size(117, 45);
            this.CmdAjout.TabIndex = 1;
            this.CmdAjout.Text = "Ajouter";
            this.CmdAjout.UseVisualStyleBackColor = true;
            this.CmdAjout.Click += new System.EventHandler(this.CmdAjout_Click);
            // 
            // TxtSaisie
            // 
            this.TxtSaisie.Location = new System.Drawing.Point(6, 46);
            this.TxtSaisie.MaxLength = 200;
            this.TxtSaisie.Name = "TxtSaisie";
            this.TxtSaisie.Size = new System.Drawing.Size(374, 27);
            this.TxtSaisie.TabIndex = 0;
            this.TxtSaisie.TextChanged += new System.EventHandler(this.TxtSaisie_TextChanged);
            // 
            // LblList1
            // 
            this.LblList1.AutoSize = true;
            this.LblList1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblList1.Location = new System.Drawing.Point(96, 166);
            this.LblList1.Name = "LblList1";
            this.LblList1.Size = new System.Drawing.Size(51, 20);
            this.LblList1.TabIndex = 1;
            this.LblList1.Text = "Liste 1";
            // 
            // CmdDel1
            // 
            this.CmdDel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdDel1.Location = new System.Drawing.Point(75, 425);
            this.CmdDel1.Name = "CmdDel1";
            this.CmdDel1.Size = new System.Drawing.Size(114, 46);
            this.CmdDel1.TabIndex = 3;
            this.CmdDel1.Text = "Effacer";
            this.CmdDel1.UseVisualStyleBackColor = true;
            this.CmdDel1.Click += new System.EventHandler(this.CmdDel1_Click);
            // 
            // CmdFin
            // 
            this.CmdFin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdFin.Location = new System.Drawing.Point(228, 487);
            this.CmdFin.Name = "CmdFin";
            this.CmdFin.Size = new System.Drawing.Size(127, 47);
            this.CmdFin.TabIndex = 4;
            this.CmdFin.Text = "Quitter";
            this.CmdFin.UseVisualStyleBackColor = true;
            this.CmdFin.Click += new System.EventHandler(this.CmdFin_Click);
            // 
            // LblList2
            // 
            this.LblList2.AutoSize = true;
            this.LblList2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblList2.Location = new System.Drawing.Point(413, 166);
            this.LblList2.Name = "LblList2";
            this.LblList2.Size = new System.Drawing.Size(51, 20);
            this.LblList2.TabIndex = 5;
            this.LblList2.Text = "Liste 2";
            // 
            // CmdDel2
            // 
            this.CmdDel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdDel2.Location = new System.Drawing.Point(387, 425);
            this.CmdDel2.Name = "CmdDel2";
            this.CmdDel2.Size = new System.Drawing.Size(114, 46);
            this.CmdDel2.TabIndex = 7;
            this.CmdDel2.Text = "Effacer";
            this.CmdDel2.UseVisualStyleBackColor = true;
            this.CmdDel2.Click += new System.EventHandler(this.CmdDel2_Click);
            // 
            // CmdFlDr
            // 
            this.CmdFlDr.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdFlDr.Location = new System.Drawing.Point(258, 227);
            this.CmdFlDr.Name = "CmdFlDr";
            this.CmdFlDr.Size = new System.Drawing.Size(63, 35);
            this.CmdFlDr.TabIndex = 8;
            this.CmdFlDr.Text = "-->";
            this.CmdFlDr.UseCompatibleTextRendering = true;
            this.CmdFlDr.UseVisualStyleBackColor = true;
            this.CmdFlDr.Click += new System.EventHandler(this.CmdFlDr_Click);
            // 
            // CmdFlGa
            // 
            this.CmdFlGa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdFlGa.Location = new System.Drawing.Point(258, 309);
            this.CmdFlGa.Name = "CmdFlGa";
            this.CmdFlGa.Size = new System.Drawing.Size(63, 35);
            this.CmdFlGa.TabIndex = 9;
            this.CmdFlGa.Text = "<--";
            this.CmdFlGa.UseCompatibleTextRendering = true;
            this.CmdFlGa.UseVisualStyleBackColor = true;
            this.CmdFlGa.Click += new System.EventHandler(this.CmdFlGa_Click);
            // 
            // ListBResult1
            // 
            this.ListBResult1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBResult1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBResult1.FormattingEnabled = true;
            this.ListBResult1.ItemHeight = 20;
            this.ListBResult1.Location = new System.Drawing.Point(40, 203);
            this.ListBResult1.Name = "ListBResult1";
            this.ListBResult1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ListBResult1.Size = new System.Drawing.Size(188, 182);
            this.ListBResult1.TabIndex = 10;
            this.ListBResult1.SelectedIndexChanged += new System.EventHandler(this.ListBResult1_SelectedIndexChanged);
            // 
            // ListBResult2
            // 
            this.ListBResult2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBResult2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBResult2.FormattingEnabled = true;
            this.ListBResult2.ItemHeight = 20;
            this.ListBResult2.Location = new System.Drawing.Point(360, 203);
            this.ListBResult2.Name = "ListBResult2";
            this.ListBResult2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ListBResult2.Size = new System.Drawing.Size(188, 182);
            this.ListBResult2.TabIndex = 11;
            this.ListBResult2.SelectedIndexChanged += new System.EventHandler(this.ListBResult2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(603, 546);
            this.Controls.Add(this.ListBResult2);
            this.Controls.Add(this.ListBResult1);
            this.Controls.Add(this.CmdFlGa);
            this.Controls.Add(this.CmdFlDr);
            this.Controls.Add(this.CmdDel2);
            this.Controls.Add(this.LblList2);
            this.Controls.Add(this.CmdFin);
            this.Controls.Add(this.CmdDel1);
            this.Controls.Add(this.LblList1);
            this.Controls.Add(this.GbSaisie);
            this.Name = "Form1";
            this.Text = "Jeu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GbSaisie.ResumeLayout(false);
            this.GbSaisie.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GbSaisie;
        private System.Windows.Forms.Button CmdAjout;
        private System.Windows.Forms.TextBox TxtSaisie;
        private System.Windows.Forms.Label LblList1;
        private System.Windows.Forms.Button CmdDel1;
        private System.Windows.Forms.Button CmdFin;
        private System.Windows.Forms.Label LblList2;
        private System.Windows.Forms.Button CmdDel2;
        private System.Windows.Forms.Button CmdFlDr;
        private System.Windows.Forms.Button CmdFlGa;
        private System.Windows.Forms.ListBox ListBResult1;
        private System.Windows.Forms.ListBox ListBResult2;
    }
}

