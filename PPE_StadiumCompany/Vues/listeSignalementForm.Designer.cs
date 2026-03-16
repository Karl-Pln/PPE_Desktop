namespace StadiumCompany.Vues
{
    partial class ListeSignalements
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgvSignalements = new DataGridView();
            lblStatut = new Label();
            cboStatut = new ComboBox();
            btnFermer = new Button();
            lblTitre = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSignalements).BeginInit();
            SuspendLayout();
            // 
            // dgvSignalements
            // 
            dgvSignalements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSignalements.Location = new Point(12, 45);
            dgvSignalements.Name = "dgvSignalements";
            dgvSignalements.RowHeadersWidth = 40;
            dgvSignalements.Size = new Size(960, 380);
            dgvSignalements.TabIndex = 0;
            dgvSignalements.SelectionChanged += dgvSignalements_SelectionChanged;
            // 
            // lblStatut
            // 
            lblStatut.AutoSize = true;
            lblStatut.Location = new Point(12, 440);
            lblStatut.Name = "lblStatut";
            lblStatut.Size = new Size(375, 25);
            lblStatut.TabIndex = 1;
            lblStatut.Text = "Changer le statut du signalement sélectionné :";
            // 
            // cboStatut
            // 
            cboStatut.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatut.FormattingEnabled = true;
            cboStatut.Items.AddRange(new object[] { "a_corriger", "en_correction", "corrige" });
            cboStatut.Location = new Point(406, 437);
            cboStatut.Name = "cboStatut";
            cboStatut.Size = new Size(180, 33);
            cboStatut.TabIndex = 2;
            cboStatut.SelectedIndexChanged += cboStatut_SelectedIndexChanged;
            // 
            // btnFermer
            // 
            btnFermer.Location = new Point(860, 433);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(110, 40);
            btnFermer.TabIndex = 2;
            btnFermer.Text = "Fermer";
            btnFermer.UseVisualStyleBackColor = true;
            btnFermer.Click += btnFermer_Click;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitre.Location = new Point(12, 10);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(270, 32);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Liste des signalements";
            // 
            // ListeSignalements
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 490);
            Controls.Add(lblTitre);
            Controls.Add(dgvSignalements);
            Controls.Add(lblStatut);
            Controls.Add(cboStatut);
            Controls.Add(btnFermer);
            Name = "ListeSignalements";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestion des signalements";
            ((System.ComponentModel.ISupportInitialize)dgvSignalements).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSignalements;
        private System.Windows.Forms.Label lblStatut;
        private System.Windows.Forms.ComboBox cboStatut;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label lblTitre;
    }
}