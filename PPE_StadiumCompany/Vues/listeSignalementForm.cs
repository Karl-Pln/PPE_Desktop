using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StadiumCompany.Controllers;
using StadiumCompany.Models;

namespace StadiumCompany.Vues
{
    public partial class ListeSignalements : Form
    {
        private SignalementController controller;

        public ListeSignalements()
        {
            InitializeComponent();
            controller = new SignalementController();

            ConfigurerGrille();
            ChargerSignalements();
        }

        private void ConfigurerGrille()
        {
            dgvSignalements.ReadOnly = true;
            dgvSignalements.MultiSelect = false;
            dgvSignalements.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSignalements.AllowUserToAddRows = false;
            dgvSignalements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvSignalements.Columns.Clear();
            dgvSignalements.Columns.Add("id", "ID");
            dgvSignalements.Columns.Add("utilisateur", "Utilisateur");
            dgvSignalements.Columns.Add("questionnaire", "Questionnaire");
            dgvSignalements.Columns.Add("question", "Question");
            dgvSignalements.Columns.Add("message", "Message");
            dgvSignalements.Columns.Add("date", "Date");
            dgvSignalements.Columns.Add("statut", "Statut");

            dgvSignalements.Columns["id"].Visible = false;
            dgvSignalements.Columns["date"].Width = 130;
            dgvSignalements.Columns["statut"].Width = 120;
        }

        private void ChargerSignalements()
        {
            dgvSignalements.Rows.Clear();
            List<Signalement> liste = controller.GetTousLesSignalements();
            foreach (var s in liste)
            {
                dgvSignalements.Rows.Add(
                    s.Id,
                    s.LoginUtilisateur,
                    s.NomQuestionnaire,
                    s.LibelleQuestion,
                    s.Message,
                    s.DateEnvoi.ToString("dd/MM/yyyy HH:mm"),
                    s.Statut.ToString()
                );
            }
        }

        // ComboBox statut - change le statut du signalement sélectionné
        private void cboStatut_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvSignalements.SelectedRows.Count == 0) return;

            int id = Convert.ToInt32(dgvSignalements.SelectedRows[0].Cells["id"].Value);
            StatutSignalement statut = (StatutSignalement)Enum.Parse(
                typeof(StatutSignalement),
                cboStatut.SelectedItem.ToString()
            );

            bool succes = controller.ModifierStatut(id, statut);
            if (succes)
            {
                // Mettre à jour la cellule directement sans recharger toute la grille
                dgvSignalements.SelectedRows[0].Cells["statut"].Value = statut.ToString();
                MessageBox.Show("Statut mis à jour !");
            }
            else
            {
                MessageBox.Show("Échec de la mise à jour du statut.");
            }
        }

        // Sélection d'une ligne → pré-sélectionne le bon statut dans la comboBox
        private void dgvSignalements_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSignalements.SelectedRows.Count == 0) return;

            string statut = dgvSignalements.SelectedRows[0].Cells["statut"].Value?.ToString();
            if (!string.IsNullOrEmpty(statut))
                cboStatut.SelectedItem = statut;
        }

        // Bouton fermer
        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}