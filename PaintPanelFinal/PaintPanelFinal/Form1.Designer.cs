namespace PaintPanelFinal
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSwitchGD = new System.Windows.Forms.Button();
            this.pnlDrawZone = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSwitchGD
            // 
            this.btnSwitchGD.Location = new System.Drawing.Point(35, 27);
            this.btnSwitchGD.Name = "btnSwitchGD";
            this.btnSwitchGD.Size = new System.Drawing.Size(113, 23);
            this.btnSwitchGD.TabIndex = 0;
            this.btnSwitchGD.Text = "Gommer";
            this.btnSwitchGD.UseVisualStyleBackColor = true;
            this.btnSwitchGD.Click += new System.EventHandler(this.btnSwitchGD_Click);
            // 
            // pnlDrawZone
            // 
            this.pnlDrawZone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDrawZone.Location = new System.Drawing.Point(35, 85);
            this.pnlDrawZone.Name = "pnlDrawZone";
            this.pnlDrawZone.Size = new System.Drawing.Size(1174, 564);
            this.pnlDrawZone.TabIndex = 1;
            this.pnlDrawZone.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDrawZone_Paint);
            this.pnlDrawZone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDrawZone_MouseDown);
            this.pnlDrawZone.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDrawZone_MouseMove);
            this.pnlDrawZone.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlDrawZone_MouseUp);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(445, 27);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Vider";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(672, 27);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 3;
            this.btnColor.Text = "Couleur";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(203, 30);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(76, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 661);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pnlDrawZone);
            this.Controls.Add(this.btnSwitchGD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSwitchGD;
        private System.Windows.Forms.Panel pnlDrawZone;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

