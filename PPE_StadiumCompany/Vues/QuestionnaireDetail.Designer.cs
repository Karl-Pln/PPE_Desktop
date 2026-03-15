namespace StadiumCompany.Vues
{
    partial class QuestionnaireDetail
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
            lblTitreQuestionnaire = new System.Windows.Forms.Label();
            lblNumeroQuestion = new System.Windows.Forms.Label();
            lblLibelleQuestion = new System.Windows.Forms.Label();
            pnlReponses = new System.Windows.Forms.Panel();
            lblFeedback = new System.Windows.Forms.Label();
            btnValider = new System.Windows.Forms.Button();
            btnSuivant = new System.Windows.Forms.Button();
            lblScoreMax = new System.Windows.Forms.Label();
            SuspendLayout();

            // lblTitreQuestionnaire
            lblTitreQuestionnaire.Location = new System.Drawing.Point(20, 15);
            lblTitreQuestionnaire.Name = "lblTitreQuestionnaire";
            lblTitreQuestionnaire.Size = new System.Drawing.Size(740, 35);
            lblTitreQuestionnaire.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblTitreQuestionnaire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblNumeroQuestion
            lblNumeroQuestion.Location = new System.Drawing.Point(20, 60);
            lblNumeroQuestion.Name = "lblNumeroQuestion";
            lblNumeroQuestion.Size = new System.Drawing.Size(740, 25);
            lblNumeroQuestion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            lblNumeroQuestion.ForeColor = System.Drawing.Color.Gray;
            lblNumeroQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblLibelleQuestion
            lblLibelleQuestion.Location = new System.Drawing.Point(30, 95);
            lblLibelleQuestion.Name = "lblLibelleQuestion";
            lblLibelleQuestion.Size = new System.Drawing.Size(720, 70);
            lblLibelleQuestion.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblLibelleQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // pnlReponses
            pnlReponses.Location = new System.Drawing.Point(30, 175);
            pnlReponses.Name = "pnlReponses";
            pnlReponses.Size = new System.Drawing.Size(720, 200);
            pnlReponses.AutoScroll = true;
            pnlReponses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblFeedback
            lblFeedback.Location = new System.Drawing.Point(30, 385);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new System.Drawing.Size(720, 30);
            lblFeedback.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblFeedback.Visible = false;

            // lblScoreMax
            lblScoreMax.Location = new System.Drawing.Point(30, 385);
            lblScoreMax.Name = "lblScoreMax";
            lblScoreMax.Size = new System.Drawing.Size(720, 25);
            lblScoreMax.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            lblScoreMax.ForeColor = System.Drawing.Color.Gray;
            lblScoreMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // btnValider
            btnValider.Location = new System.Drawing.Point(250, 425);
            btnValider.Name = "btnValider";
            btnValider.Size = new System.Drawing.Size(120, 45);
            btnValider.Text = "Valider";
            btnValider.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnValider.BackColor = System.Drawing.Color.SteelBlue;
            btnValider.ForeColor = System.Drawing.Color.White;
            btnValider.Enabled = false;
            btnValider.Click += new System.EventHandler(btnValider_Click);

            // btnSuivant
            btnSuivant.Location = new System.Drawing.Point(390, 425);
            btnSuivant.Name = "btnSuivant";
            btnSuivant.Size = new System.Drawing.Size(120, 45);
            btnSuivant.Text = "Suivant >";
            btnSuivant.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnSuivant.BackColor = System.Drawing.Color.SeaGreen;
            btnSuivant.ForeColor = System.Drawing.Color.White;
            btnSuivant.Enabled = false;
            btnSuivant.Click += new System.EventHandler(btnSuivant_Click);

            // Form
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(784, 490);
            Controls.Add(lblTitreQuestionnaire);
            Controls.Add(lblNumeroQuestion);
            Controls.Add(lblLibelleQuestion);
            Controls.Add(pnlReponses);
            Controls.Add(lblFeedback);
            Controls.Add(lblScoreMax);
            Controls.Add(btnValider);
            Controls.Add(btnSuivant);
            Name = "QuestionnaireDetail";
            Text = "Répondre au questionnaire";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitreQuestionnaire;
        private System.Windows.Forms.Label lblNumeroQuestion;
        private System.Windows.Forms.Label lblLibelleQuestion;
        private System.Windows.Forms.Panel pnlReponses;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Label lblScoreMax;
    }
}