namespace PPE_StadiumCompany
{
    partial class InscriptionForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnInscription = new Button();
            txtPrenom = new TextBox();
            txtNom = new TextBox();
            label1 = new Label();
            MDP = new Label();
            Nom = new Label();
            txtLogin = new TextBox();
            btnToConnexion = new Button();
            label2 = new Label();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // btnInscription
            // 
            btnInscription.Location = new Point(286, 269);
            btnInscription.Name = "btnInscription";
            btnInscription.Size = new Size(132, 44);
            btnInscription.TabIndex = 0;
            btnInscription.Text = "Inscription ";
            btnInscription.UseVisualStyleBackColor = true;
            btnInscription.Click += btnInscription_Click;
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(386, 46);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(174, 31);
            txtPrenom.TabIndex = 1;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(386, 95);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(174, 31);
            txtNom.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(242, 151);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 3;
            label1.Text = "Login";
            // 
            // MDP
            // 
            MDP.AutoSize = true;
            MDP.Location = new Point(201, 203);
            MDP.Name = "MDP";
            MDP.Size = new Size(120, 25);
            MDP.TabIndex = 4;
            MDP.Text = "Mot de passe";
            // 
            // Nom
            // 
            Nom.AutoSize = true;
            Nom.Location = new Point(246, 101);
            Nom.Name = "Nom";
            Nom.Size = new Size(52, 25);
            Nom.TabIndex = 5;
            Nom.Text = "Nom";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(386, 145);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(174, 31);
            txtLogin.TabIndex = 6;
            // 
            // btnToConnexion
            // 
            btnToConnexion.Location = new Point(646, 394);
            btnToConnexion.Name = "btnToConnexion";
            btnToConnexion.Size = new Size(142, 44);
            btnToConnexion.TabIndex = 7;
            btnToConnexion.Text = "se connecter";
            btnToConnexion.UseVisualStyleBackColor = true;
            btnToConnexion.Click += btnToConnexion_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 52);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 8;
            label2.Text = "Prénom";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(386, 203);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(174, 31);
            txtPassword.TabIndex = 9;
            // 
            // InscriptionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(btnToConnexion);
            Controls.Add(txtLogin);
            Controls.Add(Nom);
            Controls.Add(MDP);
            Controls.Add(label1);
            Controls.Add(txtNom);
            Controls.Add(txtPrenom);
            Controls.Add(btnInscription);
            Name = "InscriptionForm";
            Text = "Inscription";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInscription;
        private TextBox txtPrenom;
        private TextBox txtNom;
        private Label label1;
        private Label MDP;
        private Label Nom;
        private TextBox txtLogin;
        private Button btnToConnexion;
        private Label label2;
        private TextBox txtPassword;
    }
}
