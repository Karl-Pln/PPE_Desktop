using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StadiumCompany.Controllers;
using StadiumCompany.Models;

namespace StadiumCompany.Vues
{
    public partial class FormulaireListe : Form
    {
        private QuestionnaireController controller;
        private Utilisateur utilisateurConnecte;

        public FormulaireListe(Utilisateur utilisateur)
        {
            InitializeComponent();
            controller = new QuestionnaireController();
            utilisateurConnecte = utilisateur;

            groupBox1.Visible = false;
            ConfigurerGrille();
            ChargerQuestionnaires();

            // Double-clic sur une ligne → ouvrir QuestionnaireDetail
            questionnaires.CellDoubleClick += new DataGridViewCellEventHandler(questionnaires_CellDoubleClick);
        }

        private void ConfigurerGrille()
        {
            questionnaires.ReadOnly = true;
            questionnaires.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            questionnaires.MultiSelect = false;
            questionnaires.AllowUserToAddRows = false;

            questionnaires.Columns.Clear();
            questionnaires.Columns.Add("id", "ID");
            questionnaires.Columns.Add("nom", "Nom du questionnaire");
            questionnaires.Columns.Add("theme", "Thème");
            questionnaires.Columns.Add("nbQuestions", "Nb questions");
            questionnaires.Columns.Add("createurId", "CreateurId");

            questionnaires.Columns["id"].Visible = false;
            questionnaires.Columns["createurId"].Visible = false;
            questionnaires.Columns["nom"].Width = 250;
            questionnaires.Columns["theme"].Width = 180;
            questionnaires.Columns["nbQuestions"].Width = 120;
        }

        private void ChargerQuestionnaires()
        {
            questionnaires.Rows.Clear();
            List<Questionnaire> liste = controller.GetAll();
            foreach (var q in liste)
                questionnaires.Rows.Add(q.Id, q.Nom, q.ThemeLibelle, q.NombreQuestions, q.CreateurId);
        }

        private bool EstCreateur()
        {
            if (questionnaires.SelectedRows.Count == 0) return false;
            int createurId = Convert.ToInt32(questionnaires.SelectedRows[0].Cells["createurId"].Value);
            return createurId == utilisateurConnecte.Id;
        }

        // Double-clic → ouvrir QuestionnaireDetail
        private void questionnaires_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int id = Convert.ToInt32(questionnaires.Rows[e.RowIndex].Cells["id"].Value);
            string nom = questionnaires.Rows[e.RowIndex].Cells["nom"].Value.ToString();
            string theme = questionnaires.Rows[e.RowIndex].Cells["theme"].Value.ToString();
            int createurId = Convert.ToInt32(questionnaires.Rows[e.RowIndex].Cells["createurId"].Value);

            var questionnaire = new Questionnaire
            {
                Id = id,
                Nom = nom,
                ThemeLibelle = theme,
                CreateurId = createurId
            };

            var detail = new QuestionnaireDetail(utilisateurConnecte, questionnaire);
            detail.ShowDialog();
        }

        // Bouton "Nouveau"
        private void ajouterQuestionnaire_Click(object sender, EventArgs e)
        {
            AjouterFormulaire ajouterForm = new AjouterFormulaire(utilisateurConnecte);
            ajouterForm.ShowDialog();
            ChargerQuestionnaires();
        }

        // Bouton "Modifier" - vérifie créateur puis ouvre AjouterFormulaire pré-rempli
        private void button1_Click(object sender, EventArgs e)
        {
            if (questionnaires.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un questionnaire.");
                return;
            }

            if (!EstCreateur())
            {
                MessageBox.Show("Vous ne pouvez modifier que vos propres questionnaires.");
                return;
            }

            int id = Convert.ToInt32(questionnaires.SelectedRows[0].Cells["id"].Value);
            AjouterFormulaire ajouterForm = new AjouterFormulaire(utilisateurConnecte, id);
            ajouterForm.ShowDialog();
            ChargerQuestionnaires();
        }

        // Bouton "Supprimer"
        private void button2_Click(object sender, EventArgs e)
        {
            if (questionnaires.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un questionnaire.");
                return;
            }

            if (!EstCreateur())
            {
                MessageBox.Show("Vous ne pouvez supprimer que vos propres questionnaires.");
                return;
            }

            string nom = questionnaires.SelectedRows[0].Cells["nom"].Value.ToString();
            DialogResult confirm = MessageBox.Show(
                $"Supprimer le questionnaire « {nom} » et toutes ses questions ?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                int id = Convert.ToInt32(questionnaires.SelectedRows[0].Cells["id"].Value);
                bool succes = controller.Supprimer(id, utilisateurConnecte.Id);
                if (succes)
                {
                    MessageBox.Show("Questionnaire supprimé !");
                    groupBox1.Visible = false;
                    ChargerQuestionnaires();
                }
                else
                {
                    MessageBox.Show("Échec de la suppression.");
                }
            }
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            ConnexionForm connexionForm = new ConnexionForm();
            connexionForm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e) { }
    }
}