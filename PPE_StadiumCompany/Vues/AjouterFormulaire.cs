using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StadiumCompany.Controllers;
using StadiumCompany.Models;

namespace StadiumCompany.Vues
{
    public partial class AjouterFormulaire : Form
    {
        private QuestionnaireController questionnaireController;
        private QuestionController questionController;

        private List<Question> questionsEnCours = new List<Question>();

        public AjouterFormulaire()
        {
            InitializeComponent();
            questionnaireController = new QuestionnaireController();
            questionController = new QuestionController();

            ChargerThemes();
            ChargerTypesReponse();
            ConfigurerGrille();
        }

        private void ChargerThemes()
        {
            List<Theme> themes = questionnaireController.GetThemes();
            comboBox1.DataSource = themes;
            comboBox1.DisplayMember = "Libelle";
            comboBox1.ValueMember = "Id";
        }

        private void ChargerTypesReponse()
        {
            comboBox2.Items.Clear();
            comboBox2.Items.Add("VraiFaux");
            comboBox2.Items.Add("ListeValeurs");
            comboBox2.SelectedIndex = 0;
        }

        private void ConfigurerGrille()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("numero", "N°");
            dataGridView1.Columns.Add("intitule", "Question");
            dataGridView1.Columns.Add("type", "Type");

            dataGridView1.Columns["numero"].Width = 35;
            dataGridView1.Columns["intitule"].Width = 120;
            dataGridView1.Columns["type"].Width = 90;
        }

        // Bouton "Ajouter la question"
        private void button1_Click(object sender, EventArgs e)
        {
            string intitule = textBox2.Text.Trim();
            string type = comboBox2.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(intitule))
            {
                MessageBox.Show("Veuillez saisir l'intitulé de la question.");
                return;
            }

            var question = new Question
            {
                Libelle = intitule,
                TypeReponse = type == "VraiFaux" ? TypeReponse.VraiFaux : TypeReponse.ListeValeurs,
                Ordre = questionsEnCours.Count + 1
            };

            questionsEnCours.Add(question);
            dataGridView1.Rows.Add(questionsEnCours.Count, intitule, type);
            numericUpDown1.Value = questionsEnCours.Count;

            textBox2.Text = "";
            comboBox2.SelectedIndex = 0;
        }

        // Bouton "Ajouter Questionnaire"
        private void button2_Click(object sender, EventArgs e)
        {
            string nomQuestionnaire = textBox1.Text.Trim();
            Theme theme = comboBox1.SelectedItem as Theme;

            if (string.IsNullOrEmpty(nomQuestionnaire))
            {
                MessageBox.Show("Veuillez saisir le nom du questionnaire.");
                return;
            }

            if (theme == null)
            {
                MessageBox.Show("Veuillez sélectionner un thème.");
                return;
            }

            if (questionsEnCours.Count == 0)
            {
                MessageBox.Show("Veuillez ajouter au moins une question.");
                return;
            }

            var questionnaire = new Questionnaire
            {
                Nom = nomQuestionnaire,
                ThemeId = theme.Id
            };

            int newId = questionnaireController.Ajouter(questionnaire);

            if (newId <= 0)
            {
                MessageBox.Show("Échec de la création du questionnaire.");
                return;
            }

            foreach (var q in questionsEnCours)
            {
                q.QuestionnaireId = newId;
                questionController.Ajouter(q);
            }

            MessageBox.Show("Questionnaire ajouté avec succès !");
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e) { }
    }
}