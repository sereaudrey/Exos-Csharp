using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdFin_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void CmdAjout_Click(object sender, EventArgs e)
        {
           if (ListBResult1.Text == "")
            {
                ListBResult1.Items.Add(TxtSaisie.Text);
                TxtSaisie.Text = "";
            } else {
                ListBResult1.Text += Environment.NewLine + TxtSaisie.Text;
                TxtSaisie.Text = "";
            }
        }

        private void CmdFlDr_Click(object sender, EventArgs e)
        {
            List<string> Noms = new List<string>();

            foreach(string Item in ListBResult1.SelectedItems)
            {
                ListBResult2.Items.Add(Item);
                Noms.Add(Item);
                
            }
            foreach (string Item in Noms)
            {
                ListBResult1.Items.Remove(Item);
            }

        }

        private void CmdDel1_Click(object sender, EventArgs e)
        {
            if (ListBResult1.Text == "")
            {
                CmdDel1.Enabled = false;
            }
            ListBResult1.Items.Clear();
        }

        private void CmdDel2_Click(object sender, EventArgs e)
        {
            if (ListBResult2.Text == "")
            {
                CmdDel2.Enabled = false;
            }
            ListBResult2.Items.Clear();
        }

        private void CmdFlGa_Click(object sender, EventArgs e)
        {
            List<string> Noms2 = new List<string>();

            if (ListBResult2.Text == "")
            {
                CmdFlGa.Enabled = false;
            }

            foreach (string Item in ListBResult2.SelectedItems)
            {
                ListBResult1.Items.Add(Item);
                Noms2.Add(Item);

            }
            foreach (string Item in Noms2)
            {
                ListBResult2.Items.Remove(Item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CmdAjout.Enabled = false;
            CmdFlDr.Enabled = false;
            CmdDel1.Enabled = false;
            CmdFlGa.Enabled = false;
            CmdDel2.Enabled = false;
            //Pourquoi je dois tous les désactiver dans le load si je les désactive déjà dans les zones qui correspondent ? Si je mets pas ici ça ne désactive qu'après un clic
            // Pourquoi quand ils sont désactivés, certains sont en rouges et pas les autres ?

        }

        private void TxtSaisie_TextChanged(object sender, EventArgs e)
        {
            if (TxtSaisie.Text == "")
            {
                CmdAjout.Enabled = false;
            }
            else
            {
                CmdAjout.Enabled = true;
            }
        }

        private void ListBResult1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBResult1.Text == "")
            {
                CmdFlDr.Enabled = false;
                CmdDel1.Enabled = false;
            } else
            {
                CmdFlDr.Enabled = true;
                CmdDel1.Enabled = true;
            }
        }

        private void ListBResult2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBResult2.Text == "")
            {
                CmdFlGa.Enabled = false;
                CmdDel2.Enabled = false;
            } else
            {
                CmdFlGa.Enabled = true;
                CmdDel2.Enabled = true;
            }
        }
    }
}
