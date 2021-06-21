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
    public partial class FCreationStag : Form
    {
        public FCreationStag()
        {
            InitializeComponent();
        }

        private void CmdFin_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void CmdValid_Click(object sender, EventArgs e)
        {
            string chaineDeConnexion = "Data Source=localhost;Initial Catalog=Stagiaire;Integrated Security=SSPI";
            //string chaineDeConnexion = "Data Source-localhost;Initial Catalog=Stagiaire;User Id = sa; Pwd = 123456";

            try
            {
                //ouverture de la connexion à SQLServer
                SqlConnection MaConnexion = new SqlConnection(chaineDeConnexion);
                MaConnexion.Open();
                //MessageBox.Show("MaConnexion Ouverte");

                //Insertion des données avec une requête préparée (ou paramétrée)
                SqlCommand commande = MaConnexion.CreateCommand();
                //requête paramétrée
                commande.CommandText = "INSERT INTO TStagiaire(Id_Stagiaire,NomStag,PrenomStag,Section,DateNaissance)"+
                    " VALUES(@Id,@nom,@prenom,@section,@datenaissance)";

                //binding paramètres

                // parametre @Id
                SqlParameter paramId = new SqlParameter("@Id", TxtId.Text);
                paramId.Direction = ParameterDirection.Input;
                paramId.DbType = DbType.Int32;

                //parametre nom
                SqlParameter paramNom = new SqlParameter("@nom", TxtNom.Text);
                paramNom.Direction = ParameterDirection.Input;
                paramNom.DbType = DbType.String;
                paramNom.Size = 30;

                //parametre prenom
                SqlParameter paramPrenom = new SqlParameter("@prenom", TxtPrenom.Text);
                paramPrenom.Direction = ParameterDirection.Input;
                paramPrenom.DbType = DbType.String;
                paramPrenom.Size = 20;

                //parametre section
                SqlParameter paramSection = new SqlParameter("@section", TxtSection.Text);
                paramSection.Direction = ParameterDirection.Input;
                paramSection.DbType = DbType.String;
                paramSection.Size = 5;

                //parametre date de naissance
                DateTime Madate = Convert.ToDateTime(DTPNaissance.Value);
                SqlParameter paramDate = new SqlParameter("@datenaissance", Madate);
                paramDate.Direction = ParameterDirection.Input;
                paramDate.DbType = DbType.DateTime;

                //envoyer les paramètres dans la requête
                commande.Parameters.Add(paramId);
                commande.Parameters.Add(paramNom);
                commande.Parameters.Add(paramPrenom);
                commande.Parameters.Add(paramSection);
                commande.Parameters.Add(paramDate);

                //execution de la requete paramétrée
                commande.ExecuteNonQuery();
                MaConnexion.Close();

                TxtId.Text = "";
                TxtNom.Text = "";
                TxtPrenom.Text = "";
                TxtSection.Text = ""; 
            }
            catch (Exception d)
            {
                MessageBox.Show("Erreur rencontrée :" +d.Message);
            }
        }
    }
}
