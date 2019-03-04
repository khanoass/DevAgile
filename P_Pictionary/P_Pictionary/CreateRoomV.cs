using System;
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

        private void createRoomButton_Click(object sender, EventArgs e)
        {
            //Si Room privé coché
            if (privateRoomCheckBox.Checked)
            {
                //Vérification du pattern du mot de passe
                if (mainForm.AuthController.RegexPassword(roomPasswordTextBox.Text))
                {
                    mainForm.ChangeView(new GameV(mainForm));
                }
                else
                {
                    MessageBox.Show("Le mot de passe doit contenir au moins 1 majuscule, minuscule, chiffre, caractère spécial et être long de 8 caractères ou plus.");
                }
            }
            else
            {
                mainForm.ChangeView(new GameV(mainForm));
            }
        }

        private void privateRoomCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Activer la textBox pour le mot de passe si la checkBox est cochée
            if (privateRoomCheckBox.Checked)
            {
                roomPasswordTextBox.Enabled = true;
            }
            else
            {
                roomPasswordTextBox.Enabled = false;
            }
        }
    }
}
