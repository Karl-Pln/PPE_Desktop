using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StadiumCompany.Controllers;
using StadiumCompany.Models;

namespace StadiumCompany.Vues
{
    public partial class QuestionnaireDetail : Form
    {
        private QuestionController questionController;
        private ReponsePossibleController reponsePossibleController;
        private ScoreController scoreController;

        private Utilisateur utilisateurConnecte;
        private Questionnaire questionnaire;

        private List<Question> questions;
        private int indexQuestionActuelle = 0;
        private int scoreObtenu = 0;

        public QuestionnaireDetail(Utilisateur utilisateur, Questionnaire questionnaire)
        {
            InitializeComponent();
            utilisateurConnecte = utilisateur;
            this.questionnaire = questionnaire;
            questionController = new QuestionController();
            reponsePossibleController = new ReponsePossibleController();
            scoreController = new ScoreController();

            ChargerQuestions();
            AfficherQuestion();
        }

        // =====================================================================
        // CHARGEMENT
        // =====================================================================

        private void ChargerQuestions()
        {
            questions = questionController.GetByQuestionnaire(questionnaire.Id);

            foreach (var q in questions)
            {
                if (q.TypeReponse == TypeReponse.ListeValeurs)
                    q.ReponsesPossibles = reponsePossibleController.GetByQuestion(q.Id);
            }

            lblTitreQuestionnaire.Text = questionnaire.Nom;
            lblScoreMax.Text = $"/ {questions.Count} questions";
        }

        
        // AFFICHAGE D'UNE QUESTION
        

        private void AfficherQuestion()
        {
            if (indexQuestionActuelle >= questions.Count)
            {
                return;               
            }

            Question q = questions[indexQuestionActuelle];

            lblNumeroQuestion.Text = $"Question {indexQuestionActuelle + 1} / {questions.Count}";
            lblLibelleQuestion.Text = q.Libelle;

            pnlReponses.Controls.Clear();

            if (q.TypeReponse == TypeReponse.VraiFaux)
                AfficherReponsesVraiFaux();
            else
                AfficherReponsesListeValeurs(q);

            btnValider.Enabled = false;
            btnValider.Visible = true;
            btnSuivant.Enabled = false;
            btnSuivant.Visible = true;

            // Sur la dernière question le bouton "Suivant" s'appellera "Terminer"
            // mais on le change seulement après validation (voir btnValider_Click)
            btnSuivant.Text = indexQuestionActuelle == questions.Count - 1
                ? "Terminer"
                : "Suivant >";
        }

        private void AfficherReponsesVraiFaux()
        {
            var rbVrai = new RadioButton
            {
                Text = "Vrai",
                Name = "rbVrai",
                Location = new System.Drawing.Point(10, 10),
                AutoSize = true,
                Font = new System.Drawing.Font("Segoe UI", 11F)
            };
            var rbFaux = new RadioButton
            {
                Text = "Faux",
                Name = "rbFaux",
                Location = new System.Drawing.Point(10, 50),
                AutoSize = true,
                Font = new System.Drawing.Font("Segoe UI", 11F)
            };

            rbVrai.CheckedChanged += (s, e) => { if (rbVrai.Checked) btnValider.Enabled = true; };
            rbFaux.CheckedChanged += (s, e) => { if (rbFaux.Checked) btnValider.Enabled = true; };

            pnlReponses.Controls.Add(rbVrai);
            pnlReponses.Controls.Add(rbFaux);
        }

        private void AfficherReponsesListeValeurs(Question q)
        {
            int y = 10;
            foreach (var rep in q.ReponsesPossibles)
            {
                var rb = new RadioButton
                {
                    Text = rep.Libelle,
                    Name = "rb_" + rep.Id,
                    Tag = rep,
                    Location = new System.Drawing.Point(10, y),
                    AutoSize = true,
                    Font = new System.Drawing.Font("Segoe UI", 11F)
                };
                rb.CheckedChanged += (s, e) => { if (rb.Checked) btnValider.Enabled = true; };
                pnlReponses.Controls.Add(rb);
                y += 40;
            }
        }

        
        // BOUTON VALIDER
        

        private void btnValider_Click(object sender, EventArgs e)
        {
            Question q = questions[indexQuestionActuelle];
            bool bonneReponse = false;

            if (q.TypeReponse == TypeReponse.VraiFaux)
            {
                foreach (Control ctrl in pnlReponses.Controls)
                {
                    if (ctrl is RadioButton rb && rb.Checked)
                    {
                        bonneReponse = rb.Name == "rbVrai"
                            ? q.BonneReponse == "Vrai"
                            : q.BonneReponse == "Faux";
                        break;
                    }
                }
            }
            else
            {
                foreach (Control ctrl in pnlReponses.Controls)
                {
                    if (ctrl is RadioButton rb && rb.Checked)
                    {
                        ReponsePossible rep = rb.Tag as ReponsePossible;
                        bonneReponse = rep != null && rep.EstCorrecte;
                        break;
                    }
                }
            }

            if (bonneReponse)
            {
                scoreObtenu++;
                lblFeedback.Text = "✔ Bonne réponse !";
                lblFeedback.ForeColor = System.Drawing.Color.SeaGreen;
            }
            else
            {
                lblFeedback.Text = $"✘ Mauvaise réponse. La bonne réponse était : {GetBonneReponseTexte(q)}";
                lblFeedback.ForeColor = System.Drawing.Color.IndianRed;
            }

            lblFeedback.Visible = true;
            btnValider.Enabled = false;
            btnSuivant.Enabled = true;

            foreach (Control ctrl in pnlReponses.Controls)
                ctrl.Enabled = false;
        }

        private string GetBonneReponseTexte(Question q)
        {
            if (q.TypeReponse == TypeReponse.VraiFaux)
                return q.BonneReponse;

            foreach (var rep in q.ReponsesPossibles)
                if (rep.EstCorrecte) return rep.Libelle;

            return "?";
        }

        
        // BOUTON SUIVANT / TERMINER
        

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            bool estDerniereQuestion = indexQuestionActuelle == questions.Count - 1;

            if (estDerniereQuestion)
            {
                // Enregistrer le score et fermer
                scoreController.Enregistrer(
                    utilisateurConnecte.Id,
                    questionnaire.Id,
                    scoreObtenu,
                    questions.Count
                );

                MessageBox.Show(
                    $"Questionnaire terminé !\nVotre score : {scoreObtenu} / {questions.Count}\n{GetMessageScore()}",
                    "Résultat",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.Close(); // Retour à FormulaireListe
            }
            else
            {
                indexQuestionActuelle++;
                lblFeedback.Visible = false;
                btnSuivant.Enabled = false;
                AfficherQuestion();
            }
        }

        private string GetMessageScore()
        {
            double pourcentage = (double)scoreObtenu / questions.Count * 100;
            if (pourcentage == 100) return " Parfait !";
            if (pourcentage >= 75) return " Très bien !";
            if (pourcentage >= 50) return " Pas mal !";
            return " À revoir...";
        }
    }
}