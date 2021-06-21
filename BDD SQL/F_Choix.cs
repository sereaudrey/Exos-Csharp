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
    public partial class F_Choix : Form
    {
        public F_Choix()
        {
            InitializeComponent();
        }

        private void F_Choix_Load(object sender, EventArgs e)
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
                string SqlQuery = "Select Id_Stagiaire,NomStag FROM TStagiaire";

                MaCommande.Connection = MaConnexion;
                MaCommande.CommandText = SqlQuery;
                SqlDataReader reader = MaCommande.ExecuteReader();
                while(reader.Read())
                {
                    CbStagiaire.Items.Add(reader["Id_Stagiaire"] + "|" + reader["NomStag"]);
                }

                MaConnexion.Close();
            }
            catch (Exception d)
            {
                MessageBox.Show("Erreur rencontrée :" + d.Message);
            }
        }

        private void CmdValid_Click(object sender, EventArgs e)
        {
            // list ::NumStag|NomStag
            int monindex = CbStagiaire.Text.IndexOf("|");
            //MessageBox.Show("Index= " + Convert.ToString(monindex));
            Global.NumStag = int.Parse(CbStagiaire.Text.Substring(0, monindex));
            //MessageBox.Show("N° Stagiaire = " + Convert.ToString(Global.NumStag));

            F_Affiche AffStag = new F_Affiche();
            AffStag.ShowDialog();
        }

        private void CmdFin_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}
