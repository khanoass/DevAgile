﻿namespace P_Pictionary
{
    partial class JoinRoomV
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
            this.backButton = new System.Windows.Forms.PictureBox();
            this.roomPasswordTextBox = new System.Windows.Forms.TextBox();
            this.roomPasswordLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.roomLoginButton = new System.Windows.Forms.Button();
            this.roomIPTextBox = new System.Windows.Forms.TextBox();
            this.roomIPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Image = global::P_Pictionary.Properties.Resources.left_arrow;
            this.backButton.Location = new System.Drawing.Point(10, 10);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(30, 30);
            this.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backButton.TabIndex = 31;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // roomPasswordTextBox
            // 
            this.roomPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomPasswordTextBox.Location = new System.Drawing.Point(46, 190);
            this.roomPasswordTextBox.Name = "roomPasswordTextBox";
            this.roomPasswordTextBox.Size = new System.Drawing.Size(148, 20);
            this.roomPasswordTextBox.TabIndex = 30;
            // 
            // roomPasswordLabel
            // 
            this.roomPasswordLabel.AutoSize = true;
            this.roomPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomPasswordLabel.Location = new System.Drawing.Point(66, 161);
            this.roomPasswordLabel.Name = "roomPasswordLabel";
            this.roomPasswordLabel.Size = new System.Drawing.Size(113, 16);
            this.roomPasswordLabel.TabIndex = 29;
            this.roomPasswordLabel.Text = "Room password :";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(73, 28);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(91, 20);
            this.titleLabel.TabIndex = 28;
            this.titleLabel.Text = "Join a room";
            // 
            // roomLoginButton
            // 
            this.roomLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomLoginButton.Location = new System.Drawing.Point(70, 234);
            this.roomLoginButton.Name = "roomLoginButton";
            this.roomLoginButton.Size = new System.Drawing.Size(101, 23);
            this.roomLoginButton.TabIndex = 27;
            this.roomLoginButton.Text = "Login";
            this.roomLoginButton.UseVisualStyleBackColor = true;
            this.roomLoginButton.Click += new System.EventHandler(this.roomLoginButton_Click);
            // 
            // roomIPTextBox
            // 
            this.roomIPTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomIPTextBox.Location = new System.Drawing.Point(46, 115);
            this.roomIPTextBox.Name = "roomIPTextBox";
            this.roomIPTextBox.Size = new System.Drawing.Size(148, 20);
            this.roomIPTextBox.TabIndex = 26;
            // 
            // roomIPLabel
            // 
            this.roomIPLabel.AutoSize = true;
            this.roomIPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomIPLabel.Location = new System.Drawing.Point(87, 84);
            this.roomIPLabel.Name = "roomIPLabel";
            this.roomIPLabel.Size = new System.Drawing.Size(66, 16);
            this.roomIPLabel.TabIndex = 25;
            this.roomIPLabel.Text = "Room IP :";
            // 
            // JoinRoomV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.roomPasswordTextBox);
            this.Controls.Add(this.roomPasswordLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.roomLoginButton);
            this.Controls.Add(this.roomIPTextBox);
            this.Controls.Add(this.roomIPLabel);
            this.Name = "JoinRoomV";
            this.Size = new System.Drawing.Size(241, 309);
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.TextBox roomPasswordTextBox;
        private System.Windows.Forms.Label roomPasswordLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button roomLoginButton;
        private System.Windows.Forms.TextBox roomIPTextBox;
        private System.Windows.Forms.Label roomIPLabel;
    }
}
