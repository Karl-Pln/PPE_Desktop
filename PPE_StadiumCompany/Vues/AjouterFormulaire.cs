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
        private ReponsePossibleController reponsePossibleController;

        private Utilisateur utilisateurConnecte;
        private int questionnaireIdEdition = -1;

        // Index de la question en cours de modification (-1 = mode ajout)
        private int indexQuestionEnEdition = -1;

        private List<QuestionEnCours> questionsEnCours = new List<QuestionEnCours>();

        private class QuestionEnCours
        {
            public int IdBDD { get; set; } = -1; // -1 = nouvelle, >0 = existante en BDD
            public string Libelle { get; set; }
            public TypeReponse TypeReponse { get; set; }
            public string BonneReponse { get; set; }
            public List<ReponsePossible> Reponses { get; set; } = new List<ReponsePossible>();
        }

        // Constructeur mode création
        public AjouterFormulaire(Utilisateur utilisateur)
        {
            InitializeComponent();
            utilisateurConnecte = utilisateur;
            questionnaireController = new QuestionnaireController();
            questionController = new QuestionController();
            reponsePossibleController = new ReponsePossibleController();

            ChargerThemes();
            ConfigurerGrille();
            MettreAJourGroupeReponse();

            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
        }

        // Constructeur mode édition
        public AjouterFormulaire(Utilisateur utilisateur, int questionnaireId) : this(utilisateur)
        {
            questionnaireIdEdition = questionnaireId;
            PreRemplirQuestionnaire(questionnaireId);
            button2.Text = "Modifier Questionnaire";
        }

        // =====================================================================
        // INITIALISATION
        // =====================================================================

        private void ChargerThemes()
        {
            List<Theme> themes = questionnaireController.GetThemes();
            comboBox1.DataSource = themes;
            comboBox1.DisplayMember = "Libelle";
            comboBox1.ValueMember = "Id";
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
            dataGridView1.Columns.Add("bonneReponse", "Bonne réponse");

            dataGridView1.Columns["numero"].Width = 35;
            dataGridView1.Columns["intitule"].Width = 150;
            dataGridView1.Columns["type"].Width = 90;
            dataGridView1.Columns["bonneReponse"].Width = 100;
        }

        private void PreRemplirQuestionnaire(int id)
        {
            Questionnaire q = questionnaireController.GetById(id);
            if (q == null) return;

            textBox1.Text = q.Nom;

            foreach (Theme t in comboBox1.Items)
            {
                if (t.Id == q.ThemeId) { comboBox1.SelectedItem = t; break; }
            }

            List<Question> questions = questionController.GetByQuestionnaire(id);
            foreach (var question in questions)
            {
                var qec = new QuestionEnCours
                {
                    IdBDD = question.Id,
                    Libelle = question.Libelle,
                    TypeReponse = question.TypeReponse,
                    BonneReponse = question.BonneReponse
                };

                if (question.TypeReponse == TypeReponse.ListeValeurs)
                    qec.Reponses = reponsePossibleController.GetByQuestion(question.Id);

                questionsEnCours.Add(qec);
                AfficherQuestionDansGrille(qec);
            }

            numericUpDown1.Value = questionsEnCours.Count;
        }

        // =====================================================================
        // CLIC SUR UNE LIGNE → PRÉ-REMPLIR LES CHAMPS
        // =====================================================================

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= questionsEnCours.Count) return;

            indexQuestionEnEdition = e.RowIndex;
            QuestionEnCours qec = questionsEnCours[e.RowIndex];

            textBox2.Text = qec.Libelle;

            comboBox2.SelectedItem = qec.TypeReponse == TypeReponse.VraiFaux
                ? "VraiFaux" : "ListeValeurs";

            MettreAJourGroupeReponse();

            if (qec.TypeReponse == TypeReponse.VraiFaux)
            {
                rbVrai.Checked = qec.BonneReponse == "Vrai";
                rbFaux.Checked = qec.BonneReponse == "Faux";
            }
            else
            {
                dgvReponses.Rows.Clear();
                foreach (var rep in qec.Reponses)
                {
                    int idx = dgvReponses.Rows.Add();
                    dgvReponses.Rows[idx].Cells["colReponseLibelle"].Value = rep.Libelle;
                    dgvReponses.Rows[idx].Cells["colReponseCorrecte"].Value = rep.EstCorrecte;
                }
            }

            button1.Text = "Modifier la question";
        }

        // =====================================================================
        // AFFICHAGE / RESET
        // =====================================================================

        private void MettreAJourGroupeReponse()
        {
            bool isVraiFaux = comboBox2.SelectedItem?.ToString() == "VraiFaux";
            pnlVraiFaux.Visible = isVraiFaux;
            pnlListeValeurs.Visible = !isVraiFaux;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MettreAJourGroupeReponse();
        }

        private void ResetChampsQuestion()
        {
            textBox2.Text = "";
            comboBox2.SelectedIndex = 0;
            rbVrai.Checked = false;
            rbFaux.Checked = false;
            dgvReponses.Rows.Clear();
            txtNouvelleReponse.Text = "";
            indexQuestionEnEdition = -1;
            button1.Text = "Ajouter la question";
            MettreAJourGroupeReponse();
        }

        private void AfficherQuestionDansGrille(QuestionEnCours qec)
        {
            string bonneRep = qec.TypeReponse == TypeReponse.VraiFaux
                ? qec.BonneReponse
                : string.Join(", ", qec.Reponses.FindAll(r => r.EstCorrecte).ConvertAll(r => r.Libelle));

            dataGridView1.Rows.Add(questionsEnCours.Count, qec.Libelle, qec.TypeReponse.ToString(), bonneRep);
        }

        private void MettreAJourLigneGrille(int index, QuestionEnCours qec)
        {
            string bonneRep = qec.TypeReponse == TypeReponse.VraiFaux
                ? qec.BonneReponse
                : string.Join(", ", qec.Reponses.FindAll(r => r.EstCorrecte).ConvertAll(r => r.Libelle));

            dataGridView1.Rows[index].Cells["intitule"].Value = qec.Libelle;
            dataGridView1.Rows[index].Cells["type"].Value = qec.TypeReponse.ToString();
            dataGridView1.Rows[index].Cells["bonneReponse"].Value = bonneRep;
        }

        // =====================================================================
        // BOUTON AJOUTER RÉPONSE (ListeValeurs)
        // =====================================================================

        private void btnAjouterReponse_Click(object sender, EventArgs e)
        {
            string libelle = txtNouvelleReponse.Text.Trim();
            if (string.IsNullOrEmpty(libelle))
            {
                MessageBox.Show("Saisissez le libellé de la réponse.");
                return;
            }

            int idx = dgvReponses.Rows.Add();
            dgvReponses.Rows[idx].Cells["colReponseLibelle"].Value = libelle;
            dgvReponses.Rows[idx].Cells["colReponseCorrecte"].Value = false;
            txtNouvelleReponse.Text = "";
        }

        // =====================================================================
        // BOUTON AJOUTER / MODIFIER LA QUESTION
        // =====================================================================

        private void button1_Click(object sender, EventArgs e)
        {
            string intitule = textBox2.Text.Trim();
            string type = comboBox2.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(intitule))
            {
                MessageBox.Show("Veuillez saisir l'intitulé de la question.");
                return;
            }

            // Modification ou création de la QuestionEnCours
            QuestionEnCours qec = indexQuestionEnEdition >= 0
                ? questionsEnCours[indexQuestionEnEdition]
                : new QuestionEnCours();

            qec.Libelle = intitule;
            qec.TypeReponse = type == "VraiFaux" ? TypeReponse.VraiFaux : TypeReponse.ListeValeurs;

            if (type == "VraiFaux")
            {
                if (!rbVrai.Checked && !rbFaux.Checked)
                {
                    MessageBox.Show("Veuillez indiquer la bonne réponse (Vrai ou Faux).");
                    return;
                }
                qec.BonneReponse = rbVrai.Checked ? "Vrai" : "Faux";
                qec.Reponses.Clear();
            }
            else
            {
                if (dgvReponses.Rows.Count == 0)
                {
                    MessageBox.Show("Veuillez ajouter au moins une réponse.");
                    return;
                }

                bool auMoinsUneCorrecte = false;
                qec.Reponses.Clear();
                foreach (DataGridViewRow row in dgvReponses.Rows)
                {
                    string lib = row.Cells["colReponseLibelle"].Value?.ToString();
                    bool correct = row.Cells["colReponseCorrecte"].Value != null
                                   && (bool)row.Cells["colReponseCorrecte"].Value;
                    if (!string.IsNullOrWhiteSpace(lib))
                    {
                        qec.Reponses.Add(new ReponsePossible { Libelle = lib, EstCorrecte = correct });
                        if (correct) auMoinsUneCorrecte = true;
                    }
                }

                if (!auMoinsUneCorrecte)
                {
                    MessageBox.Show("Veuillez cocher au moins une bonne réponse.");
                    return;
                }

                qec.BonneReponse = null;
            }

            if (indexQuestionEnEdition >= 0)
            {
                // Mise à jour de la ligne dans la grille
                MettreAJourLigneGrille(indexQuestionEnEdition, qec);

                // UPDATE immédiat en BDD si la question existait déjà
                if (qec.IdBDD > 0)
                {
                    var q = new Question
                    {
                        Id = qec.IdBDD,
                        QuestionnaireId = questionnaireIdEdition,
                        Libelle = qec.Libelle,
                        TypeReponse = qec.TypeReponse,
                        BonneReponse = qec.BonneReponse,
                        Ordre = indexQuestionEnEdition + 1
                    };
                    questionController.Modifier(q);

                    if (qec.TypeReponse == TypeReponse.ListeValeurs)
                    {
                        reponsePossibleController.SupprimerParQuestion(qec.IdBDD);
                        foreach (var rep in qec.Reponses)
                        {
                            rep.QuestionId = qec.IdBDD;
                            reponsePossibleController.Ajouter(rep);
                        }
                    }
                }
            }
            else
            {
                // Nouvelle question : ajout dans la liste et la grille
                questionsEnCours.Add(qec);
                AfficherQuestionDansGrille(qec);
                numericUpDown1.Value = questionsEnCours.Count;
            }

            ResetChampsQuestion();
        }

        // =====================================================================
        // BOUTON AJOUTER / MODIFIER LE QUESTIONNAIRE
        // =====================================================================

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

            int questionnaireId;

            if (questionnaireIdEdition > 0)
            {
                var q = new Questionnaire
                {
                    Id = questionnaireIdEdition,
                    Nom = nomQuestionnaire,
                    ThemeId = theme.Id
                };
                questionnaireController.Modifier(q, utilisateurConnecte.Id);

                // Supprimer les anciennes questions qui ne sont plus dans la liste
                List<Question> anciennes = questionController.GetByQuestionnaire(questionnaireIdEdition);
                foreach (var aq in anciennes)
                {
                    if (!questionsEnCours.Exists(qec => qec.IdBDD == aq.Id))
                        questionController.Supprimer(aq.Id);
                }

                questionnaireId = questionnaireIdEdition;
            }
            else
            {
                var q = new Questionnaire
                {
                    Nom = nomQuestionnaire,
                    ThemeId = theme.Id,
                    CreateurId = utilisateurConnecte.Id
                };
                questionnaireId = questionnaireController.Ajouter(q);
            }

            if (questionnaireId <= 0)
            {
                MessageBox.Show("Échec de l'enregistrement du questionnaire.");
                return;
            }

            // Enregistrer uniquement les nouvelles questions (IdBDD == -1)
            int ordre = 1;
            foreach (var qec in questionsEnCours)
            {
                if (qec.IdBDD == -1)
                {
                    var question = new Question
                    {
                        QuestionnaireId = questionnaireId,
                        Libelle = qec.Libelle,
                        TypeReponse = qec.TypeReponse,
                        BonneReponse = qec.BonneReponse,
                        Ordre = ordre
                    };

                    int newId = questionController.Ajouter(question);

                    if (qec.TypeReponse == TypeReponse.ListeValeurs && newId > 0)
                    {
                        foreach (var rep in qec.Reponses)
                        {
                            rep.QuestionId = newId;
                            reponsePossibleController.Ajouter(rep);
                        }
                    }
                }
                ordre++;
            }

            MessageBox.Show(questionnaireIdEdition > 0
                ? "Questionnaire modifié avec succès !"
                : "Questionnaire ajouté avec succès !");
            this.Close();
        }

        private void btnSupprimerQuestion_Click(object sender, EventArgs e)
        {
            if (indexQuestionEnEdition < 0)
            {
                MessageBox.Show("Cliquez d'abord sur une question dans la liste.");
                return;
            }

            QuestionEnCours qec = questionsEnCours[indexQuestionEnEdition];

            DialogResult confirm = MessageBox.Show(
                $"Supprimer la question « {qec.Libelle} » ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes) return;

            // Supprimer en BDD si elle existe déjà
            if (qec.IdBDD > 0)
                questionController.Supprimer(qec.IdBDD);

            // Supprimer de la liste et de la grille
            questionsEnCours.RemoveAt(indexQuestionEnEdition);
            dataGridView1.Rows.RemoveAt(indexQuestionEnEdition);

            // Renuméroter les lignes
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                dataGridView1.Rows[i].Cells["numero"].Value = i + 1;

            numericUpDown1.Value = questionsEnCours.Count;
            ResetChampsQuestion();
        }

        private void btnNouvelleQuestion_Click(object sender, EventArgs e)
        {
            // Remet tous les champs à zéro et repasse en mode ajout
            ResetChampsQuestion();
        }

        private void label1_Click(object sender, EventArgs e) { }
    }
}