namespace WindowsFormsApp2
{
    partial class Devin
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSaisie = new System.Windows.Forms.TextBox();
            this.CmdProposer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CmdAbandon = new System.Windows.Forms.Button();
            this.LblLettresCitees = new System.Windows.Forms.Label();
            this.LblMotCache = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nouvellePartieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CmdQuitter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblMotsCites = new System.Windows.Forms.Label();
            this.PictPendu = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictPendu)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 54);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ecrivez une lettre ou proposez un mot :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtSaisie
            // 
            this.TxtSaisie.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSaisie.Location = new System.Drawing.Point(250, 45);
            this.TxtSaisie.MaxLength = 50;
            this.TxtSaisie.Name = "TxtSaisie";
            this.TxtSaisie.Size = new System.Drawing.Size(197, 27);
            this.TxtSaisie.TabIndex = 6;
            this.TxtSaisie.TextChanged += new System.EventHandler(this.TxtSaisie_TextChanged);
            // 
            // CmdProposer
            // 
            this.CmdProposer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdProposer.Location = new System.Drawing.Point(503, 38);
            this.CmdProposer.Name = "CmdProposer";
            this.CmdProposer.Size = new System.Drawing.Size(149, 41);
            this.CmdProposer.TabIndex = 7;
            this.CmdProposer.Text = "Proposer";
            this.CmdProposer.UseVisualStyleBackColor = true;
            this.CmdProposer.Click += new System.EventHandler(this.CmdProposer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lettres déjà citées : ";
            // 
            // CmdAbandon
            // 
            this.CmdAbandon.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAbandon.Location = new System.Drawing.Point(247, 470);
            this.CmdAbandon.Name = "CmdAbandon";
            this.CmdAbandon.Size = new System.Drawing.Size(180, 37);
            this.CmdAbandon.TabIndex = 12;
            this.CmdAbandon.Text = "Abandonner la partie";
            this.CmdAbandon.UseVisualStyleBackColor = true;
            this.CmdAbandon.Click += new System.EventHandler(this.CmdAbandon_Click);
            // 
            // LblLettresCitees
            // 
            this.LblLettresCitees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblLettresCitees.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLettresCitees.Location = new System.Drawing.Point(159, 122);
            this.LblLettresCitees.Name = "LblLettresCitees";
            this.LblLettresCitees.Size = new System.Drawing.Size(617, 26);
            this.LblLettresCitees.TabIndex = 13;
            // 
            // LblMotCache
            // 
            this.LblMotCache.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblMotCache.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMotCache.Location = new System.Drawing.Point(29, 266);
            this.LblMotCache.Name = "LblMotCache";
            this.LblMotCache.Size = new System.Drawing.Size(398, 173);
            this.LblMotCache.TabIndex = 14;
            this.LblMotCache.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblMotCache.Click += new System.EventHandler(this.LblMotCache_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvellePartieToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nouvellePartieToolStripMenuItem
            // 
            this.nouvellePartieToolStripMenuItem.Name = "nouvellePartieToolStripMenuItem";
            this.nouvellePartieToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.nouvellePartieToolStripMenuItem.Text = "Nouvelle partie";
            this.nouvellePartieToolStripMenuItem.Click += new System.EventHandler(this.nouvellePartieToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // CmdQuitter
            // 
            this.CmdQuitter.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdQuitter.Location = new System.Drawing.Point(28, 471);
            this.CmdQuitter.Name = "CmdQuitter";
            this.CmdQuitter.Size = new System.Drawing.Size(146, 35);
            this.CmdQuitter.TabIndex = 22;
            this.CmdQuitter.Text = "Quitter le jeu";
            this.CmdQuitter.UseVisualStyleBackColor = true;
            this.CmdQuitter.Click += new System.EventHandler(this.CmdQuitter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mots déjà cités :";
            // 
            // LblMotsCites
            // 
            this.LblMotsCites.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblMotsCites.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMotsCites.Location = new System.Drawing.Point(159, 179);
            this.LblMotsCites.Name = "LblMotsCites";
            this.LblMotsCites.Size = new System.Drawing.Size(617, 28);
            this.LblMotsCites.TabIndex = 24;
            // 
            // PictPendu
            // 
            this.PictPendu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictPendu.ImageLocation = "";
            this.PictPendu.Location = new System.Drawing.Point(488, 237);
            this.PictPendu.Name = "PictPendu";
            this.PictPendu.Size = new System.Drawing.Size(288, 270);
            this.PictPendu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictPendu.TabIndex = 17;
            this.PictPendu.TabStop = false;
            // 
            // Devin
            // 
            this.AcceptButton = this.CmdProposer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.LblMotsCites);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmdQuitter);
            this.Controls.Add(this.PictPendu);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.LblMotCache);
            this.Controls.Add(this.LblLettresCitees);
            this.Controls.Add(this.CmdAbandon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmdProposer);
            this.Controls.Add(this.TxtSaisie);
            this.Controls.Add(this.label2);
            this.Name = "Devin";
            this.Text = "Trouvez le mot !";
            this.Load += new System.EventHandler(this.Devin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictPendu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSaisie;
        private System.Windows.Forms.Button CmdProposer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CmdAbandon;
        private System.Windows.Forms.Label LblLettresCitees;
        private System.Windows.Forms.Label LblMotCache;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nouvellePartieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.PictureBox PictPendu;
        private System.Windows.Forms.Button CmdQuitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblMotsCites;
    }
}