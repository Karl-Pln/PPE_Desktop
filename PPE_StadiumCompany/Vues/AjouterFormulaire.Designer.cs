namespace StadiumCompany.Vues
{
    partial class AjouterFormulaire
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            comboBox2 = new System.Windows.Forms.ComboBox();
            textBox2 = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();

            // label1 - Nom du formulaire
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 23);
            label1.Name = "label1";
            label1.TabIndex = 0;
            label1.Text = "Nom du formulaire";
            label1.Click += new System.EventHandler(label1_Click);

            // label2 - Catégorie
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(469, 18);
            label2.Name = "label2";
            label2.TabIndex = 1;
            label2.Text = "Catégorie";

            // textBox1 - Nom questionnaire
            textBox1.Location = new System.Drawing.Point(214, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(166, 31);
            textBox1.TabIndex = 2;

            // comboBox1 - Thème
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(613, 15);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(175, 33);
            comboBox1.TabIndex = 3;

            // label3 - Nombre de questions
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 103);
            label3.Name = "label3";
            label3.TabIndex = 4;
            label3.Text = "Nombre de questions";

            // numericUpDown1
            numericUpDown1.Location = new System.Drawing.Point(214, 97);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(105, 31);
            numericUpDown1.TabIndex = 5;
            numericUpDown1.ReadOnly = true;

            // label5 - Intitulé
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(15, 43);
            label5.Name = "label5";
            label5.TabIndex = 11;
            label5.Text = "Intitulé";

            // label6 - Type de réponse
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(0, 92);
            label6.Name = "label6";
            label6.TabIndex = 12;
            label6.Text = "Type de réponse";

            // comboBox2 - Type réponse
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new System.Drawing.Point(170, 92);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(182, 33);
            comboBox2.TabIndex = 13;

            // textBox2 - Intitulé question
            textBox2.Location = new System.Drawing.Point(170, 37);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(150, 31);
            textBox2.TabIndex = 14;

            // groupBox1 - Détails question
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new System.Drawing.Point(12, 150);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(394, 182);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Détails de la question";

            // button1 - Ajouter la question
            button1.Location = new System.Drawing.Point(73, 360);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(153, 67);
            button1.TabIndex = 7;
            button1.Text = "Ajouter la question";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(button1_Click);

            // label4 - Questions du formulaire
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(469, 97);
            label4.Name = "label4";
            label4.TabIndex = 8;
            label4.Text = "Questions du formulaire";

            // dataGridView1
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(455, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new System.Drawing.Size(272, 221);
            dataGridView1.TabIndex = 9;

            // button2 - Ajouter Questionnaire
            button2.Location = new System.Drawing.Point(507, 363);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(176, 64);
            button2.TabIndex = 10;
            button2.Text = "Ajouter Questionnaire";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(button2_Click);

            // AjouterFormulaire
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AjouterFormulaire";
            Text = "Ajouter un questionnaire";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox2;
    }
}