﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Pictionary
{
    public partial class CreateRoomV : UserControl
    {
        private MainForm mainForm;

        public CreateRoomV(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            mainForm.BackView();
        }

        private void privateRoomCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (privateRoomCheckBox.Checked)
            {
                roomPasswordLabel.Visible = false;
                roomPasswordTextBox.Visible = false;
            }
            else
            {
                roomPasswordLabel.Visible = true;
                roomPasswordTextBox.Visible = true;
            }
        }

        private void createRoomButton_Click(object sender, EventArgs e)
        {
            mainForm.ChangeView(new GameV(mainForm));
        }
    }
}