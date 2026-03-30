namespace StadiumCompany.Vues
{
    partial class FormulaireListe
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
            questionnaires = new DataGridView();
            ajouterQuestionnaire = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            Modif_NomQuestionnaire = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnSignalements = new Button();
            btnDeconnexion = new Button();
            ((System.ComponentModel.ISupportInitialize)questionnaires).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // questionnaires
            // 
            questionnaires.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            questionnaires.Location = new Point(2, 3);
            questionnaires.Name = "questionnaires";
            questionnaires.RowHeadersWidth = 62;
            questionnaires.Size = new Size(584, 304);
            questionnaires.TabIndex = 0;
            // 
            // ajouterQuestionnaire
            // 
            ajouterQuestionnaire.BackColor = Color.FromArgb(214, 214, 214);
            ajouterQuestionnaire.ForeColor = Color.Black;
            ajouterQuestionnaire.FlatStyle = FlatStyle.Flat;
            ajouterQuestionnaire.FlatAppearance.BorderSize = 0;
            ajouterQuestionnaire.Location = new Point(651, 31);
            ajouterQuestionnaire.Name = "ajouterQuestionnaire";
            ajouterQuestionnaire.Size = new Size(120, 50);
            ajouterQuestionnaire.TabIndex = 1;
            ajouterQuestionnaire.Text = "Nouveau";
            ajouterQuestionnaire.UseVisualStyleBackColor = true;
            ajouterQuestionnaire.Click += ajouterQuestionnaire_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(214, 214, 214);
            button1.ForeColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.Location = new Point(785, 31);
            button1.Name = "button1";
            button1.Size = new Size(100, 50);
            button1.TabIndex = 2;
            button1.Text = "Modifier";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(214, 214, 214);
            button2.ForeColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button2.Location = new Point(152, 155);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 3;
            button2.Text = "Supprimer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(214, 214, 214);
            button3.ForeColor = Color.Black;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
            button3.Location = new Point(23, 155);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 4;
            button3.Text = "Modifier";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(Modif_NomQuestionnaire);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(651, 138);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(270, 205);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Détails modification";
            // 
            // Modif_NomQuestionnaire
            // 
            Modif_NomQuestionnaire.Location = new Point(56, 73);
            Modif_NomQuestionnaire.Name = "Modif_NomQuestionnaire";
            Modif_NomQuestionnaire.Size = new Size(150, 31);
            Modif_NomQuestionnaire.TabIndex = 2;
            Modif_NomQuestionnaire.Font = new Font("Segoe UI", 10);
            Modif_NomQuestionnaire.BackColor = Color.WhiteSmoke;
            Modif_NomQuestionnaire.BorderStyle = BorderStyle.FixedSingle;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 32);
            label2.Name = "label2";
            label2.Size = new Size(164, 25);
            label2.TabIndex = 1;
            label2.Text = "Nom questionnaire";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 0;
            // 
            // btnSignalements
            // 
            btnSignalements.BackColor = Color.FromArgb(214, 214, 214);
            btnSignalements.ForeColor = Color.Black;
            btnSignalements.FlatStyle = FlatStyle.Flat;
            btnSignalements.FlatAppearance.BorderSize = 0;
            btnSignalements.Location = new Point(707, 367);
            btnSignalements.Name = "btnSignalements";
            btnSignalements.Size = new Size(150, 45);
            btnSignalements.TabIndex = 5;
            btnSignalements.Text = "Signalements";
            btnSignalements.UseVisualStyleBackColor = false;
            btnSignalements.Visible = false;
            btnSignalements.Click += btnSignalements_Click;
            // 
            // btnDeconnexion
            // 
            btnDeconnexion.BackColor = Color.FromArgb(214, 214, 214);
            btnDeconnexion.ForeColor = Color.Black;
            btnDeconnexion.FlatStyle = FlatStyle.Flat;
            btnDeconnexion.FlatAppearance.BorderSize = 0;
            btnDeconnexion.Location = new Point(148, 367);
            btnDeconnexion.Name = "btnDeconnexion";
            btnDeconnexion.Size = new Size(130, 45);
            btnDeconnexion.TabIndex = 6;
            btnDeconnexion.Text = "Déconnexion";
            btnDeconnexion.UseVisualStyleBackColor = false;
            btnDeconnexion.Click += btnDeconnexion_Click;
            // 
            // FormulaireListe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 450);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(ajouterQuestionnaire);
            Controls.Add(questionnaires);
            Controls.Add(btnSignalements);
            Controls.Add(btnDeconnexion);
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
        private System.Windows.Forms.Button btnSignalements;
        private System.Windows.Forms.Button btnDeconnexion;
    }
}