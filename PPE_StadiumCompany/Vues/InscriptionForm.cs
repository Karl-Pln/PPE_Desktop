using System;
using System.Windows.Forms;
using StadiumCompany.Controllers;

namespace StadiumCompany.Vues
{
    public partial class InscriptionForm : Form
    {
        private UtilisateurController controller;

        public InscriptionForm()
        {
            InitializeComponent();
            controller = new UtilisateurController();
        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            bool success = controller.Inscrire(
                txtLogin.Text,
                txtPassword.Text,
                txtNom.Text,
                txtPrenom.Text
            );

            if (success)
            {
                ConnexionForm connexion = new ConnexionForm();
                connexion.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Échec de l'inscription. Le login existe peut-être déjà.");
            }
        }

        private void btnToConnexion_Click(object sender, EventArgs e)
        {
            ConnexionForm connexionForm = new ConnexionForm();
            connexionForm.Show();
            this.Hide();
        }
    }
}