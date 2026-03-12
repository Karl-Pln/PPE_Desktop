using Org.BouncyCastle.Asn1.Crmf;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace StadiumCompany.Vues
{
    partial class ConnexionForm
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
            txtLogin = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            btnConnexion = new System.Windows.Forms.Button();
            btnToInscription = new System.Windows.Forms.Button();
            SuspendLayout();

            // label1 - Login
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(218, 57);
            label1.Name = "label1";
            label1.TabIndex = 0;
            label1.Text = "Login";

            // label2 - Password
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(199, 135);
            label2.Name = "label2";
            label2.TabIndex = 1;
            label2.Text = "Password";

            // txtLogin
            txtLogin.Location = new System.Drawing.Point(325, 57);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new System.Drawing.Size(149, 31);
            txtLogin.TabIndex = 2;

            // txtPassword
            txtPassword.Location = new System.Drawing.Point(325, 129);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(149, 31);
            txtPassword.TabIndex = 3;

            // btnConnexion
            btnConnexion.Location = new System.Drawing.Point(325, 226);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new System.Drawing.Size(132, 53);
            btnConnexion.TabIndex = 4;
            btnConnexion.Text = "Connexion";
            btnConnexion.UseVisualStyleBackColor = true;
            btnConnexion.Click += new System.EventHandler(btnConnexion_Click);

            // btnToInscription
            btnToInscription.Location = new System.Drawing.Point(668, 377);
            btnToInscription.Name = "btnToInscription";
            btnToInscription.Size = new System.Drawing.Size(113, 50);
            btnToInscription.TabIndex = 5;
            btnToInscription.Text = "S'inscrire";
            btnToInscription.UseVisualStyleBackColor = true;
            btnToInscription.Click += new System.EventHandler(btnToInscription_Click);

            // ConnexionForm
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnToInscription);
            Controls.Add(btnConnexion);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ConnexionForm";
            Text = "Connexion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Button btnToInscription;
    }
}