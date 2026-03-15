using System;
using System.Windows.Forms;
using StadiumCompany.Controllers;
using StadiumCompany.Models;

namespace StadiumCompany.Vues
{
    public partial class ConnexionForm : Form
    {
        private UtilisateurController controller;

        public ConnexionForm()
        {
            InitializeComponent();
            controller = new UtilisateurController();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            Utilisateur utilisateur = controller.Connexion(
                txtLogin.Text,
                txtPassword.Text
            );

            if (utilisateur != null)
            {
                // On passe l'utilisateur connecté à FormulaireListe
                FormulaireListe mainForm = new FormulaireListe(utilisateur);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login ou mot de passe incorrect.");
            }
        }

        private void btnToInscription_Click(object sender, EventArgs e)
        {
            InscriptionForm inscriptionForm = new InscriptionForm();
            inscriptionForm.Show();
            this.Hide();
        }
    }
}