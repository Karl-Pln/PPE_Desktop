namespace StadiumCompany.Vues
{
    partial class InscriptionForm
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
            btnInscription = new System.Windows.Forms.Button();
            txtPrenom = new System.Windows.Forms.TextBox();
            txtNom = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            MDP = new System.Windows.Forms.Label();
            Nom = new System.Windows.Forms.Label();
            txtLogin = new System.Windows.Forms.TextBox();
            btnToConnexion = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            SuspendLayout();

            // btnInscription
            btnInscription.Location = new System.Drawing.Point(286, 269);
            btnInscription.Name = "btnInscription";
            btnInscription.Size = new System.Drawing.Size(132, 44);
            btnInscription.TabIndex = 0;
            btnInscription.Text = "Inscription";
            btnInscription.UseVisualStyleBackColor = true;
            btnInscription.Click += new System.EventHandler(btnInscription_Click);

            // txtPrenom
            txtPrenom.Location = new System.Drawing.Point(386, 46);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new System.Drawing.Size(174, 31);
            txtPrenom.TabIndex = 1;

            // txtNom
            txtNom.Location = new System.Drawing.Point(386, 95);
            txtNom.Name = "txtNom";
            txtNom.Size = new System.Drawing.Size(174, 31);
            txtNom.TabIndex = 2;

            // label1 - Login
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(242, 151);
            label1.Name = "label1";
            label1.TabIndex = 3;
            label1.Text = "Login";

            // MDP
            MDP.AutoSize = true;
            MDP.Location = new System.Drawing.Point(201, 203);
            MDP.Name = "MDP";
            MDP.TabIndex = 4;
            MDP.Text = "Mot de passe";

            // Nom
            Nom.AutoSize = true;
            Nom.Location = new System.Drawing.Point(246, 101);
            Nom.Name = "Nom";
            Nom.TabIndex = 5;
            Nom.Text = "Nom";

            // txtLogin
            txtLogin.Location = new System.Drawing.Point(386, 145);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new System.Drawing.Size(174, 31);
            txtLogin.TabIndex = 6;

            // btnToConnexion
            btnToConnexion.Location = new System.Drawing.Point(646, 394);
            btnToConnexion.Name = "btnToConnexion";
            btnToConnexion.Size = new System.Drawing.Size(142, 44);
            btnToConnexion.TabIndex = 7;
            btnToConnexion.Text = "Se connecter";
            btnToConnexion.UseVisualStyleBackColor = true;
            btnToConnexion.Click += new System.EventHandler(btnToConnexion_Click);

            // label2 - Prénom
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(235, 52);
            label2.Name = "label2";
            label2.TabIndex = 8;
            label2.Text = "Prénom";

            // txtPassword
            txtPassword.Location = new System.Drawing.Point(386, 203);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(174, 31);
            txtPassword.TabIndex = 9;

            // InscriptionForm
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
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

        private System.Windows.Forms.Button btnInscription;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MDP;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnToConnexion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
    }
}