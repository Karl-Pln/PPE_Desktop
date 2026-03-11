namespace PPE_StadiumCompany
{
    partial class AjouterFormulaire
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            groupBox1 = new GroupBox();
            button1 = new Button();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            textBox2 = new TextBox();
            comboBox2 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(164, 25);
            label1.TabIndex = 0;
            label1.Text = "Nom du formulaire";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(469, 18);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 1;
            label2.Text = "catégorie";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(214, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 31);
            textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(613, 15);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(175, 33);
            comboBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 103);
            label3.Name = "label3";
            label3.Size = new Size(185, 25);
            label3.TabIndex = 4;
            label3.Text = "Nombre de questions";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(214, 97);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(105, 31);
            numericUpDown1.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(12, 150);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(394, 182);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Details de la question ";
            // 
            // button1
            // 
            button1.Location = new Point(73, 360);
            button1.Name = "button1";
            button1.Size = new Size(153, 67);
            button1.TabIndex = 7;
            button1.Text = "Ajouter la question";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(469, 97);
            label4.Name = "label4";
            label4.Size = new Size(201, 25);
            label4.TabIndex = 8;
            label4.Text = "questions du formulaire";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(455, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(272, 221);
            dataGridView1.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(507, 363);
            button2.Name = "button2";
            button2.Size = new Size(176, 64);
            button2.TabIndex = 10;
            button2.Text = "Ajouter Questionnaire";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(170, 37);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 11;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(170, 92);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 43);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 11;
            label5.Text = "Intitulé";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 92);
            label6.Name = "label6";
            label6.Size = new Size(141, 25);
            label6.TabIndex = 11;
            label6.Text = "type de réponse";
            // 
            // AjouterFormulaire
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Text = "AjouterFormulaire";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private GroupBox groupBox1;
        private Button button1;
        private TextBox textBox2;
        private Label label4;
        private DataGridView dataGridView1;
        private Button button2;
        private Label label6;
        private Label label5;
        private ComboBox comboBox2;
    }
}