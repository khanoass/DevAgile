namespace P_Pictionary
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
            this.linkLogOut = new System.Windows.Forms.LinkLabel();
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
<<<<<<< HEAD
            this.roomPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomPasswordLabel.Location = new System.Drawing.Point(31, 153);
            this.roomPasswordLabel.Name = "roomPasswordLabel";
            this.roomPasswordLabel.Size = new System.Drawing.Size(191, 32);
=======
            this.roomPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.roomPasswordLabel.Location = new System.Drawing.Point(57, 161);
            this.roomPasswordLabel.Name = "roomPasswordLabel";
            this.roomPasswordLabel.Size = new System.Drawing.Size(132, 20);
>>>>>>> 864ea6decc4b343fc0f7608032eb424195bb69d3
            this.roomPasswordLabel.TabIndex = 29;
            this.roomPasswordLabel.Text = "Mot de passe de la salle :\r\n(Uniquement pour salle privée)";
            this.roomPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
<<<<<<< HEAD
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(48, 28);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(144, 20);
=======
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.titleLabel.Location = new System.Drawing.Point(55, 36);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(126, 26);
>>>>>>> 864ea6decc4b343fc0f7608032eb424195bb69d3
            this.titleLabel.TabIndex = 28;
            this.titleLabel.Text = "Rejoindre une salle";
            // 
            // roomLoginButton
            // 
            this.roomLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
<<<<<<< HEAD
            this.roomLoginButton.Location = new System.Drawing.Point(72, 234);
=======
            this.roomLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.roomLoginButton.Location = new System.Drawing.Point(70, 234);
>>>>>>> 864ea6decc4b343fc0f7608032eb424195bb69d3
            this.roomLoginButton.Name = "roomLoginButton";
            this.roomLoginButton.Size = new System.Drawing.Size(101, 23);
            this.roomLoginButton.TabIndex = 27;
            this.roomLoginButton.Text = "Se connecter";
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
<<<<<<< HEAD
            this.roomIPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomIPLabel.Location = new System.Drawing.Point(76, 84);
            this.roomIPLabel.Name = "roomIPLabel";
            this.roomIPLabel.Size = new System.Drawing.Size(91, 16);
=======
            this.roomIPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.roomIPLabel.Location = new System.Drawing.Point(81, 84);
            this.roomIPLabel.Name = "roomIPLabel";
            this.roomIPLabel.Size = new System.Drawing.Size(79, 20);
>>>>>>> 864ea6decc4b343fc0f7608032eb424195bb69d3
            this.roomIPLabel.TabIndex = 25;
            this.roomIPLabel.Text = "IP de la salle :";
            // 
            // linkLogOut
            // 
            this.linkLogOut.AutoSize = true;
            this.linkLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkLogOut.Location = new System.Drawing.Point(182, 10);
            this.linkLogOut.Name = "linkLogOut";
            this.linkLogOut.Size = new System.Drawing.Size(56, 17);
            this.linkLogOut.TabIndex = 32;
            this.linkLogOut.TabStop = true;
            this.linkLogOut.Text = "Log out";
            // 
            // JoinRoomV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLogOut);
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
        private System.Windows.Forms.LinkLabel linkLogOut;
    }
}
