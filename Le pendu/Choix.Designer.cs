namespace WindowsFormsApp2
{
    partial class Choix
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.changerLeNombreDeJoueursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSaisie = new System.Windows.Forms.TextBox();
            this.CmdValid = new System.Windows.Forms.Button();
            this.CmdQuitter = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changerLeNombreDeJoueursToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(637, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // changerLeNombreDeJoueursToolStripMenuItem
            // 
            this.changerLeNombreDeJoueursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.changerLeNombreDeJoueursToolStripMenuItem.Name = "changerLeNombreDeJoueursToolStripMenuItem";
            this.changerLeNombreDeJoueursToolStripMenuItem.Size = new System.Drawing.Size(179, 20);
            this.changerLeNombreDeJoueursToolStripMenuItem.Text = "Changer le nombre de joueurs";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem2.Text = "2";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem3.Text = "3";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem4.Text = "4";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mot à faire deviner :";
            // 
            // TxtSaisie
            // 
            this.TxtSaisie.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSaisie.Location = new System.Drawing.Point(45, 76);
            this.TxtSaisie.MaxLength = 50;
            this.TxtSaisie.Name = "TxtSaisie";
            this.TxtSaisie.Size = new System.Drawing.Size(397, 25);
            this.TxtSaisie.TabIndex = 2;
            this.TxtSaisie.TextChanged += new System.EventHandler(this.TxtSaisie_TextChanged);
            // 
            // CmdValid
            // 
            this.CmdValid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdValid.Location = new System.Drawing.Point(503, 68);
            this.CmdValid.Name = "CmdValid";
            this.CmdValid.Size = new System.Drawing.Size(116, 41);
            this.CmdValid.TabIndex = 3;
            this.CmdValid.Text = "Valider";
            this.CmdValid.UseVisualStyleBackColor = true;
            this.CmdValid.Click += new System.EventHandler(this.CmdValid_Click);
            // 
            // CmdQuitter
            // 
            this.CmdQuitter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdQuitter.Location = new System.Drawing.Point(234, 149);
            this.CmdQuitter.Name = "CmdQuitter";
            this.CmdQuitter.Size = new System.Drawing.Size(123, 37);
            this.CmdQuitter.TabIndex = 9;
            this.CmdQuitter.Text = "Quitter";
            this.CmdQuitter.UseVisualStyleBackColor = true;
            this.CmdQuitter.Click += new System.EventHandler(this.button3_Click);
            // 
            // Choix
            // 
            this.AcceptButton = this.CmdValid;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 209);
            this.Controls.Add(this.CmdQuitter);
            this.Controls.Add(this.CmdValid);
            this.Controls.Add(this.TxtSaisie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Choix";
            this.Text = "Le pendu";
            this.Load += new System.EventHandler(this.Choix_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSaisie;
        private System.Windows.Forms.Button CmdValid;
        private System.Windows.Forms.Button CmdQuitter;
        private System.Windows.Forms.ToolStripMenuItem changerLeNombreDeJoueursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
    }
}

