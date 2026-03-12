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

        public FormulaireListe()
        {
            InitializeComponent();
            controller = new QuestionnaireController();

            groupBox1.Visible = false;
            ConfigurerGrille();
            ChargerQuestionnaires();
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

            questionnaires.Columns["id"].Visible = false;
            questionnaires.Columns["nom"].Width = 250;
            questionnaires.Columns["theme"].Width = 180;
            questionnaires.Columns["nbQuestions"].Width = 120;
        }

        private void ChargerQuestionnaires()
        {
            questionnaires.Rows.Clear();
            List<Questionnaire> liste = controller.GetAll();
            foreach (var q in liste)
            {
                questionnaires.Rows.Add(q.Id, q.Nom, q.ThemeLibelle, q.NombreQuestions);
            }
        }

        // Bouton "Nouveau"
        private void ajouterQuestionnaire_Click(object sender, EventArgs e)
        {
            AjouterFormulaire ajouterForm = new AjouterFormulaire();
            ajouterForm.ShowDialog();
            ChargerQuestionnaires();
        }

        // Bouton "Modifier" - ouvre le groupBox
        private void button1_Click(object sender, EventArgs e)
        {
            if (questionnaires.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un questionnaire.");
                return;
            }

            Modif_NomQuestionnaire.Text = questionnaires.SelectedRows[0].Cells["nom"].Value.ToString();
            groupBox1.Visible = true;
        }

        // Bouton "Modifier" dans le groupBox - enregistre
        private void button3_Click(object sender, EventArgs e)
        {
            if (questionnaires.SelectedRows.Count == 0) return;

            string nouveauNom = Modif_NomQuestionnaire.Text.Trim();
            if (string.IsNullOrEmpty(nouveauNom))
            {
                MessageBox.Show("Le nom ne peut pas être vide.");
                return;
            }

            int id = Convert.ToInt32(questionnaires.SelectedRows[0].Cells["id"].Value);

            Questionnaire q = new Questionnaire
            {
                Id = id,
                Nom = nouveauNom,
                ThemeId = 0
            };

            bool succes = controller.Modifier(q);
            if (succes)
            {
                MessageBox.Show("Questionnaire modifié !");
                groupBox1.Visible = false;
                ChargerQuestionnaires();
            }
            else
            {
                MessageBox.Show("Échec de la modification.");
            }
        }

        // Bouton "Supprimer" dans le groupBox
        private void button2_Click(object sender, EventArgs e)
        {
            if (questionnaires.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un questionnaire.");
                return;
            }

            string nom = questionnaires.SelectedRows[0].Cells["nom"].Value.ToString();
            DialogResult confirm = MessageBox.Show(
                $"Supprimer le questionnaire « {nom} » et toutes ses questions ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                int id = Convert.ToInt32(questionnaires.SelectedRows[0].Cells["id"].Value);
                bool succes = controller.Supprimer(id);
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
    }
}