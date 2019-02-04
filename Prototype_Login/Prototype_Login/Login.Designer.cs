namespace Prototype_Login
{
    partial class Login
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
            this.txbLoginUserName = new System.Windows.Forms.TextBox();
            this.txbLoginPassword = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnValidation = new System.Windows.Forms.Button();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbLoginUserName
            // 
            this.txbLoginUserName.Location = new System.Drawing.Point(338, 173);
            this.txbLoginUserName.Name = "txbLoginUserName";
            this.txbLoginUserName.Size = new System.Drawing.Size(100, 20);
            this.txbLoginUserName.TabIndex = 0;
            this.txbLoginUserName.TextChanged += new System.EventHandler(this.TextChanged_txbLoginUserName);
            // 
            // txbLoginPassword
            // 
            this.txbLoginPassword.Location = new System.Drawing.Point(338, 249);
            this.txbLoginPassword.Name = "txbLoginPassword";
            this.txbLoginPassword.Size = new System.Drawing.Size(100, 20);
            this.txbLoginPassword.TabIndex = 1;
            this.txbLoginPassword.TextChanged += new System.EventHandler(this.TextChanged_txbLoginPassword);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(205, 176);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "User Name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(205, 249);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // btnValidation
            // 
            this.btnValidation.Enabled = false;
            this.btnValidation.Location = new System.Drawing.Point(514, 244);
            this.btnValidation.Name = "btnValidation";
            this.btnValidation.Size = new System.Drawing.Size(75, 23);
            this.btnValidation.TabIndex = 4;
            this.btnValidation.Text = "Valider";
            this.btnValidation.UseVisualStyleBackColor = true;
            this.btnValidation.Click += new System.EventHandler(this.Click_btnValidation);
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.Location = new System.Drawing.Point(514, 169);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(97, 23);
            this.buttonCreateAccount.TabIndex = 5;
            this.buttonCreateAccount.Text = "Créer un compte";
            this.buttonCreateAccount.UseVisualStyleBackColor = true;
            this.buttonCreateAccount.Click += new System.EventHandler(this.Click_buttonCreateAccount);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCreateAccount);
            this.Controls.Add(this.btnValidation);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txbLoginPassword);
            this.Controls.Add(this.txbLoginUserName);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbLoginUserName;
        private System.Windows.Forms.TextBox txbLoginPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnValidation;
        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.Button button1;
    }
}