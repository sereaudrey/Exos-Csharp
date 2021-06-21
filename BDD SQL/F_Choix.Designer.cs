
namespace GestStagiaire
{
    partial class F_Choix
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
            this.CbStagiaire = new System.Windows.Forms.ComboBox();
            this.CmdValid = new System.Windows.Forms.Button();
            this.CmdFin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CbStagiaire
            // 
            this.CbStagiaire.FormattingEnabled = true;
            this.CbStagiaire.Location = new System.Drawing.Point(15, 23);
            this.CbStagiaire.Name = "CbStagiaire";
            this.CbStagiaire.Size = new System.Drawing.Size(254, 21);
            this.CbStagiaire.TabIndex = 0;
            // 
            // CmdValid
            // 
            this.CmdValid.Location = new System.Drawing.Point(81, 78);
            this.CmdValid.Name = "CmdValid";
            this.CmdValid.Size = new System.Drawing.Size(124, 38);
            this.CmdValid.TabIndex = 1;
            this.CmdValid.Text = "Valider";
            this.CmdValid.UseVisualStyleBackColor = true;
            this.CmdValid.Click += new System.EventHandler(this.CmdValid_Click);
            // 
            // CmdFin
            // 
            this.CmdFin.Location = new System.Drawing.Point(85, 139);
            this.CmdFin.Name = "CmdFin";
            this.CmdFin.Size = new System.Drawing.Size(119, 35);
            this.CmdFin.TabIndex = 2;
            this.CmdFin.Text = "Fermer";
            this.CmdFin.UseVisualStyleBackColor = true;
            this.CmdFin.Click += new System.EventHandler(this.CmdFin_Click);
            // 
            // F_Choix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 192);
            this.Controls.Add(this.CmdFin);
            this.Controls.Add(this.CmdValid);
            this.Controls.Add(this.CbStagiaire);
            this.Name = "F_Choix";
            this.Text = "Choix du stagiaire";
            this.Load += new System.EventHandler(this.F_Choix_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CbStagiaire;
        private System.Windows.Forms.Button CmdValid;
        private System.Windows.Forms.Button CmdFin;
    }
}