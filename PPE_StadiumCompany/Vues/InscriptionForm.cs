using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PPE_StadiumCompany.DAO;
using PPE_StadiumCompany.Controleurs;
using PPE_StadiumCompany.Modèles;
using PPE_StadiumCompany;


namespace PPE_StadiumCompany
{
    public partial class InscriptionForm : Form
    {
        private UtilisateurControleur controleur;
        public InscriptionForm()
        {
            InitializeComponent();
            controleur = new UtilisateurControleur();
        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            bool success = controleur.Inscription(
            txtLogin.Text,
            txtPassword.Text,
            txtNom.Text,
            txtPrenom.Text
            );

            if (success)
            {
                MessageBox.Show("Inscription réussie !");
                ConnexionForm connexion = new ConnexionForm();
                connexion.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Échec de l'inscription.");
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
