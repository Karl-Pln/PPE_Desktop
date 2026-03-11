using PPE_StadiumCompany.Controleurs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPE_StadiumCompany.DAO;
using PPE_StadiumCompany.Modèles;
using PPE_StadiumCompany;

namespace PPE_StadiumCompany
{
    public partial class ConnexionForm : Form
    {
        private UtilisateurControleur controleur;
        public ConnexionForm()
        {
            InitializeComponent();
            controleur = new UtilisateurControleur();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string motDePasse = txtPassword.Text;

            Utilisateur utilisateur = controleur.Connexion(login, motDePasse);

            if (utilisateur != null)
            {
                MessageBox.Show("Bienvenue !");
                FormulaireListe mainForm = new FormulaireListe();
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
