﻿namespace P_Pictionary
{
    partial class CreateAccountV
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.titleLabel.Location = new System.Drawing.Point(33, 47);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(174, 26);
            this.titleLabel.TabIndex = 34;
            this.titleLabel.Text = "Créer un compte";
            // 
            // createButton
            // 
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.createButton.Location = new System.Drawing.Point(70, 234);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(101, 23);
            this.createButton.TabIndex = 33;
            this.createButton.Text = "Créer";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Location = new System.Drawing.Point(45, 178);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(148, 20);
            this.passwordTextBox.TabIndex = 32;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTextBox.Location = new System.Drawing.Point(45, 113);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(148, 20);
            this.usernameTextBox.TabIndex = 31;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passwordLabel.Location = new System.Drawing.Point(63, 151);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(113, 20);
            this.passwordLabel.TabIndex = 30;
            this.passwordLabel.Text = "Mot de passe :";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usernameLabel.Location = new System.Drawing.Point(82, 87);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(71, 20);
            this.usernameLabel.TabIndex = 29;
            this.usernameLabel.Text = "Pseudo :";
            // 
            // backButton
            // 
            this.backButton.Image = global::P_Pictionary.Properties.Resources.left_arrow;
            this.backButton.Location = new System.Drawing.Point(10, 10);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(30, 30);
            this.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backButton.TabIndex = 35;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // CreateAccountV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Name = "CreateAccountV";
            this.Size = new System.Drawing.Size(241, 309);
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
    }
}
