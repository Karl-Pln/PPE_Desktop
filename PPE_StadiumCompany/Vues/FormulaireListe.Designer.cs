namespace PPE_StadiumCompany
{
    partial class FormulaireListe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            questionnaires = new DataGridView();
            ajouterQuestionnaire = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            Modif_NomQuestionnaire = new TextBox();
            button3 = new Button();
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
            ajouterQuestionnaire.Location = new Point(651, 31);
            ajouterQuestionnaire.Name = "ajouterQuestionnaire";
            ajouterQuestionnaire.Size = new Size(120, 59);
            ajouterQuestionnaire.TabIndex = 1;
            ajouterQuestionnaire.Text = "Nouveau";
            ajouterQuestionnaire.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(825, 31);
            button1.Name = "button1";
            button1.Size = new Size(111, 59);
            button1.TabIndex = 2;
            button1.Text = "Modifier";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(Modif_NomQuestionnaire);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(666, 138);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(270, 205);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "détails modification";
            // 
            // button2
            // 
            button2.Location = new Point(152, 155);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 4;
            button2.Text = "Supprimer";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 0;
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
            // Modif_NomQuestionnaire
            // 
            Modif_NomQuestionnaire.Location = new Point(56, 73);
            Modif_NomQuestionnaire.Name = "Modif_NomQuestionnaire";
            Modif_NomQuestionnaire.Size = new Size(150, 31);
            Modif_NomQuestionnaire.TabIndex = 2;
            // 
            // button3
            // 
            button3.Location = new Point(23, 155);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 4;
            button3.Text = "Modifier";
            button3.UseVisualStyleBackColor = true;
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
            Name = "FormulaireListe";
            Text = "FormulaireListe";
            ((System.ComponentModel.ISupportInitialize)questionnaires).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView questionnaires;
        private Button ajouterQuestionnaire;
        private Button button1;
        private GroupBox groupBox1;
        private TextBox Modif_NomQuestionnaire;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button3;
    }
}