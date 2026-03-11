namespace PPE_StadiumCompany
{
    partial class ConnexionForm
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
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            btnConnexion = new Button();
            btnToInscription = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 57);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 135);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(325, 57);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(149, 31);
            txtLogin.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(325, 129);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(149, 31);
            txtPassword.TabIndex = 3;
            // 
            // btnConnexion
            // 
            btnConnexion.Location = new Point(325, 226);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(132, 53);
            btnConnexion.TabIndex = 4;
            btnConnexion.Text = "Connexion";
            btnConnexion.UseVisualStyleBackColor = true;
            btnConnexion.Click += btnConnexion_Click;
            // 
            // btnToInscription
            // 
            btnToInscription.Location = new Point(668, 377);
            btnToInscription.Name = "btnToInscription";
            btnToInscription.Size = new Size(113, 50);
            btnToInscription.TabIndex = 5;
            btnToInscription.Text = "s'inscrire";
            btnToInscription.UseVisualStyleBackColor = true;
            btnToInscription.Click += btnToInscription_Click;
            // 
            // ConnexionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnToInscription);
            Controls.Add(btnConnexion);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ConnexionForm";
            Text = "Login";
            Click += btnConnexion_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private Button btnConnexion;
        private Button btnToInscription;
    }
}