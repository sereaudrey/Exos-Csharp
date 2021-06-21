using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestStagiaire
{
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listeStagiaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_AfficheAuto faffiche = new F_AfficheAuto();
            faffiche.ShowDialog();
        }

        private void ficheStagiaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Choix fchoix = new F_Choix();
            fchoix.Show();
        }

        private void créationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCreationStag creastag = new FCreationStag();
            creastag.ShowDialog();
        }

        private void FMenu_Load(object sender, EventArgs e)
        {
            string chaineDeConnexion = "Data Source=localhost;Initial Catalog=Stagiaire;Integrated Security=SSPI";
            //string chaineDeConnexion = "Data Source-localhost;Initial Catalog=Stagiaire;User Id = sa; Pwd = 123456";

            try
            {
                //ouverture de la connexion à SQLServer
                SqlConnection MaConnexion = new SqlConnection(chaineDeConnexion);
                MaConnexion.Open();
                //MessageBox.Show("MaConnexion Ouverte");

                SqlCommand MaCommande = new SqlCommand();
                string SqlQuery = "Select COUNT (NomStag) as NbStag FROM TStagiaire";

                MaCommande.Connection = MaConnexion;
                MaCommande.CommandText = SqlQuery;
                SqlDataReader reader = MaCommande.ExecuteReader();
                reader.Read();

                TSL_NbStag.Text = "Nombre de stagiaire dans la base : " + reader["NbStag"];
                
                MaConnexion.Close();
            }
            catch (Exception d)
            {
                MessageBox.Show("Erreur rencontrée :" + d.Message);
            }
        }
    }
}
