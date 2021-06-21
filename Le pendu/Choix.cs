using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Choix : Form
    {
        //public int Victoire { get; set; }

        public Choix()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void CmdValid_Click(object sender, EventArgs e)
        {
            TxtSaisie.Text = "";
            Devin devine = new Devin();
            devine.MotChoisi = TxtSaisie.Text;
            devine.Show();
            this.Hide();


            
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void Choix_Load(object sender, EventArgs e)
        {
            CmdValid.Enabled = false;
        }

        private void TxtSaisie_TextChanged(object sender, EventArgs e)
        {
            if (TxtSaisie.Text == "")
            {
                CmdValid.Enabled = false;
            }
            else
            {
                CmdValid.Enabled = true;
            }
        }

        /*private void LblNbVictoire_Click(object sender, EventArgs e)
        {
            LblNbVictoire.Text += Convert.ToString(Victoire);
        }

        protected override void OnShown(EventArgs e)
        {
            LblNbVictoire.Text = Convert.ToString(Victoire);
            base.OnShown(e);

        }*/
    }
}
