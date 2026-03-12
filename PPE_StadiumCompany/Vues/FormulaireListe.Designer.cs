namespace StadiumCompany.Vues
{
    partial class FormulaireListe
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            questionnaires = new System.Windows.Forms.DataGridView();
            ajouterQuestionnaire = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            Modif_NomQuestionnaire = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)questionnaires).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();

            // questionnaires
            questionnaires.Location = new System.Drawing.Point(2, 3);
            questionnaires.Name = "questionnaires";
            questionnaires.RowHeadersWidth = 62;
            questionnaires.Size = new System.Drawing.Size(584, 304);
            questionnaires.TabIndex = 0;
            questionnaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            // ajouterQuestionnaire
            ajouterQuestionnaire.Location = new System.Drawing.Point(651, 31);
            ajouterQuestionnaire.Name = "ajouterQuestionnaire";
            ajouterQuestionnaire.Size = new System.Drawing.Size(120, 59);
            ajouterQuestionnaire.TabIndex = 1;
            ajouterQuestionnaire.Text = "Nouveau";
            ajouterQuestionnaire.UseVisualStyleBackColor = true;
            ajouterQuestionnaire.Click += new System.EventHandler(ajouterQuestionnaire_Click);

            // button1 - Modifier (ouvre groupBox)
            button1.Location = new System.Drawing.Point(825, 31);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(111, 59);
            button1.TabIndex = 2;
            button1.Text = "Modifier";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(button1_Click);

            // label1 (vide, réservé)
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 36);
            label1.Name = "label1";
            label1.TabIndex = 0;

            // label2
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(42, 32);
            label2.Name = "label2";
            label2.TabIndex = 1;
            label2.Text = "Nom questionnaire";

            // Modif_NomQuestionnaire
            Modif_NomQuestionnaire.Location = new System.Drawing.Point(56, 73);
            Modif_NomQuestionnaire.Name = "Modif_NomQuestionnaire";
            Modif_NomQuestionnaire.Size = new System.Drawing.Size(150, 31);
            Modif_NomQuestionnaire.TabIndex = 2;

            // button2 - Supprimer
            button2.Location = new System.Drawing.Point(152, 155);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(112, 34);
            button2.TabIndex = 3;
            button2.Text = "Supprimer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(button2_Click);

            // button3 - Modifier (dans groupBox)
            button3.Location = new System.Drawing.Point(23, 155);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(112, 34);
            button3.TabIndex = 4;
            button3.Text = "Modifier";
            button3.UseVisualStyleBackColor = true;
            button3.Click += new System.EventHandler(button3_Click);

            // groupBox1
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(Modif_NomQuestionnaire);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(666, 138);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(270, 205);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Détails modification";

            // FormulaireListe
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(978, 450);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(ajouterQuestionnaire);
            Controls.Add(questionnaires);
            Name = "FormulaireListe";
            Text = "Liste des questionnaires";
            ((System.ComponentModel.ISupportInitialize)questionnaires).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView questionnaires;
        private System.Windows.Forms.Button ajouterQuestionnaire;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Modif_NomQuestionnaire;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}