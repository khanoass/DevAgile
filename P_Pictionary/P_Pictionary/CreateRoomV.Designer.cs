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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.InviteLabel = new System.Windows.Forms.Label();
            this.inviteTextBox = new System.Windows.Forms.TextBox();
            this.privateRoomCheckBox = new System.Windows.Forms.CheckBox();
            this.roomPasswordLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.roomPasswordTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // createRoomButton
            // 
            this.createRoomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createRoomButton.Location = new System.Drawing.Point(47, 354);
            this.createRoomButton.Name = "createRoomButton";
            this.createRoomButton.Size = new System.Drawing.Size(119, 23);
            this.createRoomButton.TabIndex = 38;
            this.createRoomButton.Text = "Create";
            this.createRoomButton.UseVisualStyleBackColor = true;
            this.createRoomButton.Click += new System.EventHandler(this.createRoomButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(80, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Player2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Player1";
            // 
            // InviteLabel
            // 
            this.InviteLabel.AutoSize = true;
            this.InviteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InviteLabel.Location = new System.Drawing.Point(54, 172);
            this.InviteLabel.Name = "InviteLabel";
            this.InviteLabel.Size = new System.Drawing.Size(108, 16);
            this.InviteLabel.TabIndex = 35;
            this.InviteLabel.Text = "Invite username :";
            // 
            // inviteTextBox
            // 
            this.inviteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inviteTextBox.Location = new System.Drawing.Point(47, 205);
            this.inviteTextBox.Name = "inviteTextBox";
            this.inviteTextBox.Size = new System.Drawing.Size(119, 20);
            this.inviteTextBox.TabIndex = 34;
            // 
            // privateRoomCheckBox
            // 
            this.privateRoomCheckBox.AutoSize = true;
            this.privateRoomCheckBox.Location = new System.Drawing.Point(34, 125);
            this.privateRoomCheckBox.Name = "privateRoomCheckBox";
            this.privateRoomCheckBox.Size = new System.Drawing.Size(158, 17);
            this.privateRoomCheckBox.TabIndex = 33;
            this.privateRoomCheckBox.Text = "Private room (invitation only)";
            this.privateRoomCheckBox.UseVisualStyleBackColor = true;
            this.privateRoomCheckBox.CheckedChanged += new System.EventHandler(this.privateRoomCheckBox_CheckedChanged);
            // 
            // roomPasswordLabel
            // 
            this.roomPasswordLabel.AutoSize = true;
            this.roomPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomPasswordLabel.Location = new System.Drawing.Point(51, 63);
            this.roomPasswordLabel.Name = "roomPasswordLabel";
            this.roomPasswordLabel.Size = new System.Drawing.Size(113, 16);
            this.roomPasswordLabel.TabIndex = 32;
            this.roomPasswordLabel.Text = "Room password :";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(56, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(110, 20);
            this.titleLabel.TabIndex = 31;
            this.titleLabel.Text = "Create a room";
            // 
            // roomPasswordTextBox
            // 
            this.roomPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomPasswordTextBox.Location = new System.Drawing.Point(47, 82);
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
            // pictureBox2
            // 
            this.pictureBox2.Image = global::P_Pictionary.Properties.Resources.cancel;
            this.pictureBox2.Location = new System.Drawing.Point(128, 272);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::P_Pictionary.Properties.Resources.cancel;
            this.pictureBox1.Location = new System.Drawing.Point(128, 246);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // CreateRoomV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.createRoomButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.InviteLabel);
            this.Controls.Add(this.inviteTextBox);
            this.Controls.Add(this.privateRoomCheckBox);
            this.Controls.Add(this.roomPasswordLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.roomPasswordTextBox);
            this.Name = "CreateRoomV";
            this.Size = new System.Drawing.Size(223, 398);
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button createRoomButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label InviteLabel;
        private System.Windows.Forms.TextBox inviteTextBox;
        private System.Windows.Forms.CheckBox privateRoomCheckBox;
        private System.Windows.Forms.Label roomPasswordLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox roomPasswordTextBox;
    }
}
