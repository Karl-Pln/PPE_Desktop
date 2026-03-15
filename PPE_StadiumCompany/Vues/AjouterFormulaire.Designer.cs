namespace StadiumCompany.Vues
{
    partial class AjouterFormulaire
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            groupBox1 = new GroupBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            comboBox2 = new ComboBox();
            pnlVraiFaux = new Panel();
            lblBonneReponse = new Label();
            rbVrai = new RadioButton();
            rbFaux = new RadioButton();
            pnlListeValeurs = new Panel();
            dgvReponses = new DataGridView();
            colReponseLibelle = new DataGridViewTextBoxColumn();
            colReponseCorrecte = new DataGridViewCheckBoxColumn();
            txtNouvelleReponse = new TextBox();
            btnAjouterReponse = new Button();
            button1 = new Button();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            btnSupprimerQuestion = new Button();
            btnNouvelleQuestion = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            pnlVraiFaux.SuspendLayout();
            pnlListeValeurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReponses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(190, 25);
            label1.TabIndex = 0;
            label1.Text = "Nom du questionnaire";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(549, 20);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 2;
            label2.Text = "Thème";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(200, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 31);
            textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(668, 15);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(175, 33);
            comboBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 70);
            label3.Name = "label3";
            label3.Size = new Size(185, 25);
            label3.TabIndex = 4;
            label3.Text = "Nombre de questions";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(200, 65);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.ReadOnly = true;
            numericUpDown1.Size = new Size(80, 31);
            numericUpDown1.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(pnlVraiFaux);
            groupBox1.Controls.Add(pnlListeValeurs);
            groupBox1.Location = new Point(12, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(455, 318);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Détails de la question";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 30);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 0;
            label5.Text = "Intitulé";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(100, 27);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(349, 31);
            textBox2.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 75);
            label6.Name = "label6";
            label6.Size = new Size(143, 25);
            label6.TabIndex = 2;
            label6.Text = "Type de réponse";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "VraiFaux", "ListeValeurs" });
            comboBox2.Location = new Point(210, 72);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(150, 33);
            comboBox2.TabIndex = 3;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // pnlVraiFaux
            // 
            pnlVraiFaux.Controls.Add(lblBonneReponse);
            pnlVraiFaux.Controls.Add(rbVrai);
            pnlVraiFaux.Controls.Add(rbFaux);
            pnlVraiFaux.Location = new Point(10, 115);
            pnlVraiFaux.Name = "pnlVraiFaux";
            pnlVraiFaux.Size = new Size(378, 30);
            pnlVraiFaux.TabIndex = 4;
            // 
            // lblBonneReponse
            // 
            lblBonneReponse.AutoSize = true;
            lblBonneReponse.Location = new Point(0, 5);
            lblBonneReponse.Name = "lblBonneReponse";
            lblBonneReponse.Size = new Size(140, 25);
            lblBonneReponse.TabIndex = 0;
            lblBonneReponse.Text = "Bonne réponse :";
            // 
            // rbVrai
            // 
            rbVrai.AutoSize = true;
            rbVrai.Location = new Point(146, 5);
            rbVrai.Name = "rbVrai";
            rbVrai.Size = new Size(66, 29);
            rbVrai.TabIndex = 1;
            rbVrai.Text = "Vrai";
            // 
            // rbFaux
            // 
            rbFaux.AutoSize = true;
            rbFaux.Location = new Point(238, 3);
            rbFaux.Name = "rbFaux";
            rbFaux.Size = new Size(72, 29);
            rbFaux.TabIndex = 2;
            rbFaux.Text = "Faux";
            // 
            // pnlListeValeurs
            // 
            pnlListeValeurs.Controls.Add(dgvReponses);
            pnlListeValeurs.Controls.Add(txtNouvelleReponse);
            pnlListeValeurs.Controls.Add(btnAjouterReponse);
            pnlListeValeurs.Location = new Point(10, 112);
            pnlListeValeurs.Name = "pnlListeValeurs";
            pnlListeValeurs.Size = new Size(414, 200);
            pnlListeValeurs.TabIndex = 5;
            pnlListeValeurs.Visible = false;
            // 
            // dgvReponses
            // 
            dgvReponses.AllowUserToAddRows = false;
            dgvReponses.ColumnHeadersHeight = 34;
            dgvReponses.Columns.AddRange(new DataGridViewColumn[] { colReponseLibelle, colReponseCorrecte });
            dgvReponses.Location = new Point(40, 29);
            dgvReponses.Name = "dgvReponses";
            dgvReponses.RowHeadersVisible = false;
            dgvReponses.RowHeadersWidth = 62;
            dgvReponses.Size = new Size(310, 120);
            dgvReponses.TabIndex = 0;
            // 
            // colReponseLibelle
            // 
            colReponseLibelle.HeaderText = "Réponse";
            colReponseLibelle.MinimumWidth = 8;
            colReponseLibelle.Name = "colReponseLibelle";
            colReponseLibelle.Width = 220;
            // 
            // colReponseCorrecte
            // 
            colReponseCorrecte.HeaderText = "Correcte ?";
            colReponseCorrecte.MinimumWidth = 8;
            colReponseCorrecte.Name = "colReponseCorrecte";
            colReponseCorrecte.Width = 70;
            // 
            // txtNouvelleReponse
            // 
            txtNouvelleReponse.Location = new Point(12, 155);
            txtNouvelleReponse.Name = "txtNouvelleReponse";
            txtNouvelleReponse.PlaceholderText = "Nouvelle réponse...";
            txtNouvelleReponse.Size = new Size(200, 31);
            txtNouvelleReponse.TabIndex = 1;
            // 
            // btnAjouterReponse
            // 
            btnAjouterReponse.Location = new Point(293, 155);
            btnAjouterReponse.Name = "btnAjouterReponse";
            btnAjouterReponse.Size = new Size(100, 31);
            btnAjouterReponse.TabIndex = 2;
            btnAjouterReponse.Text = "+ Ajouter";
            btnAjouterReponse.Click += btnAjouterReponse_Click;
            // 
            // button1
            // 
            button1.Location = new Point(22, 434);
            button1.Name = "button1";
            button1.Size = new Size(229, 50);
            button1.TabIndex = 7;
            button1.Text = "Ajouter la question";
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(620, 100);
            label4.Name = "label4";
            label4.Size = new Size(204, 25);
            label4.TabIndex = 8;
            label4.Text = "Questions du formulaire";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(563, 138);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 30;
            dataGridView1.Size = new Size(435, 290);
            dataGridView1.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(624, 448);
            button2.Name = "button2";
            button2.Size = new Size(230, 50);
            button2.TabIndex = 10;
            button2.Text = "Ajouter Questionnaire";
            button2.Click += button2_Click;
            // 
            // btnSupprimerQuestion
            // 
            btnSupprimerQuestion.Location = new Point(268, 434);
            btnSupprimerQuestion.Name = "btnSupprimerQuestion";
            btnSupprimerQuestion.Size = new Size(193, 50);
            btnSupprimerQuestion.TabIndex = 11;
            btnSupprimerQuestion.Text = "Supprimer question";
            btnSupprimerQuestion.UseVisualStyleBackColor = false;
            btnSupprimerQuestion.Click += btnSupprimerQuestion_Click;
            // 
            // btnNouvelleQuestion
            // 
            btnNouvelleQuestion.Location = new Point(299, 57);
            btnNouvelleQuestion.Name = "btnNouvelleQuestion";
            btnNouvelleQuestion.Size = new Size(182, 50);
            btnNouvelleQuestion.TabIndex = 12;
            btnNouvelleQuestion.Text = "Nouvelle question";
            btnNouvelleQuestion.UseVisualStyleBackColor = false;
            btnNouvelleQuestion.Click += btnNouvelleQuestion_Click;
            
            // 
            // AjouterFormulaire
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 510);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(numericUpDown1);
            Controls.Add(btnNouvelleQuestion);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(btnSupprimerQuestion);
            
            Name = "AjouterFormulaire";
            Text = "Ajouter un questionnaire";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pnlVraiFaux.ResumeLayout(false);
            pnlVraiFaux.PerformLayout();
            pnlListeValeurs.ResumeLayout(false);
            pnlListeValeurs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReponses).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel pnlVraiFaux;
        private System.Windows.Forms.RadioButton rbVrai;
        private System.Windows.Forms.RadioButton rbFaux;
        private System.Windows.Forms.Label lblBonneReponse;
        private System.Windows.Forms.Panel pnlListeValeurs;
        private System.Windows.Forms.DataGridView dgvReponses;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReponseLibelle;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colReponseCorrecte;
        private System.Windows.Forms.TextBox txtNouvelleReponse;
        private System.Windows.Forms.Button btnAjouterReponse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSupprimerQuestion;
        private System.Windows.Forms.Button btnNouvelleQuestion;
         
    }
}