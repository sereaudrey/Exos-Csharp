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
    public partial class Devin : Form
    {
        // Création des variables et listes
        public string MotChoisi { get; set; }
        private List<char> Lettres = new List<char>();
        private List<string> Mots = new List<string>();
        public int NbBonneRep = 0;
        

        public Devin()
        {
            InitializeComponent();
        }

        private void CmdAbandon_Click(object sender, EventArgs e)
        {
            //Ouvre la fenêtre choix et ferme devin
            Choix choix = new Choix();
            choix.Show();
            this.Hide();
        }

        private void LblMotCache_Click(object sender, EventArgs e)
        {
            // boucle pour afficher _ pour chaque lettre du mot choisi
            foreach (char lettre in MotChoisi)
            {
                LblMotCache.Text += " _ ";
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        // création d'une fonction pour mettre à jour le jeu après chaque proposition
        void RaffraichirEcran()
        {
            LblMotCache.Text = "";
            NbBonneRep = 0;
            foreach (char lettre in MotChoisi)
            {
                if (Lettres.Contains(lettre))
                {
                    LblMotCache.Text += lettre;
                    NbBonneRep++;
                }
                else
                {
                    LblMotCache.Text += " _ ";
                }
            }
        }
       
        private void CmdProposer_Click(object sender, EventArgs e)
        {   //proposition du bon mot
            if (TxtSaisie.Text.Equals(MotChoisi, StringComparison.InvariantCultureIgnoreCase))
            {
                MessageBox.Show("Bravo vous avez deviné le mot !");
                this.Close();
            }
            else if(TxtSaisie.Text.Length>=2)
            {
                //Mauvaise proposition de mot
                Mots.Add(TxtSaisie.Text);
                LblMotsCites.Text += TxtSaisie.Text + " - ";
                TxtSaisie.Text = "";
            }
            else
            {
                //Proposition d'une lettre
                var unchar = TxtSaisie.Text[0];
                if (Lettres.Contains(unchar))
                {
                    TxtSaisie.Text = "";
                    MessageBox.Show("Lettre déjà citée");
                    return;
                }
                else
                {
                    Lettres.Add(TxtSaisie.Text[0]);
                    RaffraichirEcran();
                    LblLettresCitees.Text += unchar + " - ";
                    TxtSaisie.Text = "";
                }
            }

            // Gérer le nombre d'erreur pour mettre fin à la partie
            int NbErreur = Lettres.Except(MotChoisi.ToList()).Count()+ Mots.Count;

            if (NbErreur >= 11)
            {
                MessageBox.Show("Perdu, le mot à trouver était " + MotChoisi + ".");
            } else if (NbBonneRep == MotChoisi.Length)
            {
                MessageBox.Show("Bravo vous avez deviné le mot !");
                this.Close();
            }

           // Gérer le pendu a afficher après chaque erreur
            if (NbErreur==1)
            {
                PictPendu.Image = Properties.Resources.pendu1;
            }
            else if (NbErreur == 2)
            {
                PictPendu.Image = Properties.Resources.pendu2;
            }
            else if (NbErreur == 3)
            {
                PictPendu.Image = Properties.Resources.pendu3;
            }
            else if (NbErreur == 4)
            {
                PictPendu.Image = Properties.Resources.pendu4;
            }
            else if (NbErreur == 5)
            {
                PictPendu.Image = Properties.Resources.pendu5;
            }
            else if (NbErreur == 6)
            {
                PictPendu.Image = Properties.Resources.pendu6;
            }
            else if (NbErreur == 7)
            {
                PictPendu.Image = Properties.Resources.pendu7;
            }
            else if (NbErreur == 8)
            {
                PictPendu.Image = Properties.Resources.pendu8;
            }
            else if (NbErreur == 9)
            {
                PictPendu.Image = Properties.Resources.pendu9;
            }
            else if (NbErreur == 10)
            {
                PictPendu.Image = Properties.Resources.pendu10;
            }
            else if (NbErreur == 11)
            {
                PictPendu.Image = Properties.Resources.pendu11;
            }

            
            /*Autre base de code qui peut fonctionner :
             foreach (char unelettre in TxtSaisie.Text)
            {
                if(Lettres.Contains(unelettre))
                {
                    MessageBox.Show("Lettre déjà citée");
                    TxtSaisie.Text = "";
                }
                else if (!Lettres.Contains(unelettre) && MotChoisi.Contains(unelettre))
                {
                    Lettres.Add(unelettre);
                    MotChoisi.IndexOf()
                    LblMotCache.Text += unelettre;
                    TxtSaisie.Text = "";
                }
                else
                {
                    LblLettresCitees.Text += unelettre;
                    TxtSaisie.Text = "";
                    //Ajouter une barre au pendu
                }
            }*/
        }

        private void Devin_Load(object sender, EventArgs e)
        {
            CmdProposer.Enabled = false;
            foreach (char lettre in MotChoisi)
            {
                LblMotCache.Text += " _ ";
            }
        }

        private void TxtSaisie_TextChanged(object sender, EventArgs e)
        {
            if (TxtSaisie.Text == "")
            {
                CmdProposer.Enabled = false;
            }
            else
            {
                CmdProposer.Enabled = true;
            }
        }

        private void nouvellePartieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Choix choix = new Choix();
            choix.Show();
            this.Close();
        }
        
        private void CmdQuitter_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}