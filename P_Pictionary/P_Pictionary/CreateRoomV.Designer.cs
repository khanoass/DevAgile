namespace P_Pictionary
{
    partial class CreateRoomV
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
            this.createRoomButton = new System.Windows.Forms.Button();
            this.privateRoomCheckBox = new System.Windows.Forms.CheckBox();
            this.roomPasswordLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.roomPasswordTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            this.SuspendLayout();
            // 
            // createRoomButton
            // 
            this.createRoomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createRoomButton.Location = new System.Drawing.Point(54, 156);
            this.createRoomButton.Name = "createRoomButton";
            this.createRoomButton.Size = new System.Drawing.Size(119, 23);
            this.createRoomButton.TabIndex = 38;
            this.createRoomButton.Text = "Créer";
            this.createRoomButton.UseVisualStyleBackColor = true;
            this.createRoomButton.Click += new System.EventHandler(this.createRoomButton_Click);
            // 
            // privateRoomCheckBox
            // 
            this.privateRoomCheckBox.AutoSize = true;
            this.privateRoomCheckBox.Location = new System.Drawing.Point(28, 63);
            this.privateRoomCheckBox.Name = "privateRoomCheckBox";
            this.privateRoomCheckBox.Size = new System.Drawing.Size(180, 17);
            this.privateRoomCheckBox.TabIndex = 33;
            this.privateRoomCheckBox.Text = "Salle privée (avec mot de passe)";
            this.privateRoomCheckBox.UseVisualStyleBackColor = true;
            this.privateRoomCheckBox.CheckedChanged += new System.EventHandler(this.privateRoomCheckBox_CheckedChanged);
            // 
            // roomPasswordLabel
            // 
            this.roomPasswordLabel.AutoSize = true;
            this.roomPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomPasswordLabel.Location = new System.Drawing.Point(35, 99);
            this.roomPasswordLabel.Name = "roomPasswordLabel";
            this.roomPasswordLabel.Size = new System.Drawing.Size(161, 16);
            this.roomPasswordLabel.TabIndex = 32;
            this.roomPasswordLabel.Text = "Mot de passe de la salle :";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(56, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(115, 20);
            this.titleLabel.TabIndex = 31;
            this.titleLabel.Text = "Créer une salle";
            // 
            // roomPasswordTextBox
            // 
            this.roomPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomPasswordTextBox.Location = new System.Drawing.Point(54, 118);
            this.roomPasswordTextBox.Name = "roomPasswordTextBox";
            this.roomPasswordTextBox.Size = new System.Drawing.Size(119, 20);
            this.roomPasswordTextBox.TabIndex = 30;
            // 
            // backButton
            // 
            this.backButton.Image = global::P_Pictionary.Properties.Resources.left_arrow;
            this.backButton.Location = new System.Drawing.Point(10, 10);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(30, 30);
            this.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backButton.TabIndex = 43;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // CreateRoomV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.createRoomButton);
            this.Controls.Add(this.privateRoomCheckBox);
            this.Controls.Add(this.roomPasswordLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.roomPasswordTextBox);
            this.Name = "CreateRoomV";
            this.Size = new System.Drawing.Size(223, 203);
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.Button createRoomButton;
        private System.Windows.Forms.CheckBox privateRoomCheckBox;
        private System.Windows.Forms.Label roomPasswordLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox roomPasswordTextBox;
    }
}
