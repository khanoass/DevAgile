namespace P_Pictionary
{
    partial class GameV
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
            this.btnReady = new System.Windows.Forms.Button();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnCreateChangeRoom = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnSizeLarge = new System.Windows.Forms.Button();
            this.btnSizeMedium = new System.Windows.Forms.Button();
            this.btnSizeSmall = new System.Windows.Forms.Button();
            this.lblCurrentPlayer = new System.Windows.Forms.Label();
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.btnSendText = new System.Windows.Forms.Button();
            this.txbChat = new System.Windows.Forms.TextBox();
            this.pnlChat = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.pnlDrawArea = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnReady
            // 
            this.btnReady.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReady.Location = new System.Drawing.Point(16, 466);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(75, 40);
            this.btnReady.TabIndex = 79;
            this.btnReady.Text = "Prêt";
            this.btnReady.UseVisualStyleBackColor = true;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(291, 480);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(94, 13);
            this.lblSize.TabIndex = 78;
            this.lblSize.Text = "Taille du pinceau :";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(105, 480);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(49, 13);
            this.lblColor.TabIndex = 77;
            this.lblColor.Text = "Couleur :";
            // 
            // btnCreateChangeRoom
            // 
            this.btnCreateChangeRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateChangeRoom.Location = new System.Drawing.Point(529, 6);
            this.btnCreateChangeRoom.Name = "btnCreateChangeRoom";
            this.btnCreateChangeRoom.Size = new System.Drawing.Size(168, 23);
            this.btnCreateChangeRoom.TabIndex = 76;
            this.btnCreateChangeRoom.Text = "Créer / Changer de salle";
            this.btnCreateChangeRoom.UseVisualStyleBackColor = true;
            this.btnCreateChangeRoom.Click += new System.EventHandler(this.btnCreateChangeRoom_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Location = new System.Drawing.Point(529, 38);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(168, 23);
            this.btnQuit.TabIndex = 75;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnSizeLarge
            // 
            this.btnSizeLarge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSizeLarge.Location = new System.Drawing.Point(483, 466);
            this.btnSizeLarge.Name = "btnSizeLarge";
            this.btnSizeLarge.Size = new System.Drawing.Size(40, 40);
            this.btnSizeLarge.TabIndex = 74;
            this.btnSizeLarge.Text = "L";
            this.btnSizeLarge.UseVisualStyleBackColor = true;
            // 
            // btnSizeMedium
            // 
            this.btnSizeMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSizeMedium.Location = new System.Drawing.Point(437, 466);
            this.btnSizeMedium.Name = "btnSizeMedium";
            this.btnSizeMedium.Size = new System.Drawing.Size(40, 40);
            this.btnSizeMedium.TabIndex = 73;
            this.btnSizeMedium.Text = "M";
            this.btnSizeMedium.UseVisualStyleBackColor = true;
            // 
            // btnSizeSmall
            // 
            this.btnSizeSmall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSizeSmall.Location = new System.Drawing.Point(391, 466);
            this.btnSizeSmall.Name = "btnSizeSmall";
            this.btnSizeSmall.Size = new System.Drawing.Size(40, 40);
            this.btnSizeSmall.TabIndex = 72;
            this.btnSizeSmall.Text = "S";
            this.btnSizeSmall.UseVisualStyleBackColor = true;
            // 
            // lblCurrentPlayer
            // 
            this.lblCurrentPlayer.AutoSize = true;
            this.lblCurrentPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPlayer.Location = new System.Drawing.Point(12, 24);
            this.lblCurrentPlayer.Name = "lblCurrentPlayer";
            this.lblCurrentPlayer.Size = new System.Drawing.Size(79, 20);
            this.lblCurrentPlayer.TabIndex = 71;
            this.lblCurrentPlayer.Text = "Joueur 1";
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.BackColor = System.Drawing.Color.Black;
            this.btnChooseColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseColor.Location = new System.Drawing.Point(161, 466);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(40, 40);
            this.btnChooseColor.TabIndex = 70;
            this.btnChooseColor.UseVisualStyleBackColor = false;
            // 
            // btnSendText
            // 
            this.btnSendText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendText.Location = new System.Drawing.Point(660, 466);
            this.btnSendText.Name = "btnSendText";
            this.btnSendText.Size = new System.Drawing.Size(40, 40);
            this.btnSendText.TabIndex = 69;
            this.btnSendText.Text = "OK";
            this.btnSendText.UseVisualStyleBackColor = true;
            // 
            // txbChat
            // 
            this.txbChat.Location = new System.Drawing.Point(529, 466);
            this.txbChat.Multiline = true;
            this.txbChat.Name = "txbChat";
            this.txbChat.Size = new System.Drawing.Size(125, 40);
            this.txbChat.TabIndex = 68;
            // 
            // pnlChat
            // 
            this.pnlChat.BackColor = System.Drawing.Color.White;
            this.pnlChat.Location = new System.Drawing.Point(529, 67);
            this.pnlChat.Name = "pnlChat";
            this.pnlChat.Size = new System.Drawing.Size(168, 393);
            this.pnlChat.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Joueur 3 : 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Joueur 2 : 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Joueur 1 : 0";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(240, 38);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(121, 20);
            this.lblWord.TabIndex = 63;
            this.lblWord.Text = "Mot à dessiner :";
            // 
            // pnlDrawArea
            // 
            this.pnlDrawArea.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pnlDrawArea.Location = new System.Drawing.Point(108, 67);
            this.pnlDrawArea.Name = "pnlDrawArea";
            this.pnlDrawArea.Size = new System.Drawing.Size(415, 393);
            this.pnlDrawArea.TabIndex = 62;
            // 
            // GameV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReady);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.btnCreateChangeRoom);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnSizeLarge);
            this.Controls.Add(this.btnSizeMedium);
            this.Controls.Add(this.btnSizeSmall);
            this.Controls.Add(this.lblCurrentPlayer);
            this.Controls.Add(this.btnChooseColor);
            this.Controls.Add(this.btnSendText);
            this.Controls.Add(this.txbChat);
            this.Controls.Add(this.pnlChat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.pnlDrawArea);
            this.Name = "GameV";
            this.Size = new System.Drawing.Size(709, 517);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Button btnCreateChangeRoom;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnSizeLarge;
        private System.Windows.Forms.Button btnSizeMedium;
        private System.Windows.Forms.Button btnSizeSmall;
        private System.Windows.Forms.Label lblCurrentPlayer;
        private System.Windows.Forms.Button btnChooseColor;
        private System.Windows.Forms.Button btnSendText;
        private System.Windows.Forms.TextBox txbChat;
        private System.Windows.Forms.Panel pnlChat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Panel pnlDrawArea;
    }
}
