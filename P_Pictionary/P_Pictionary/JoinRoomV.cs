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
    public partial class JoinRoomV : UserControl
    {
        private MainForm mainForm;

        public JoinRoomV(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            linkLogOut.Text = mainForm.RessourceManager.GetString("logOut");
            titleLabel.Text = mainForm.RessourceManager.GetString("joinRoom");
            roomIPLabel.Text = mainForm.RessourceManager.GetString("roomIP");
            roomPasswordLabel.Text = mainForm.RessourceManager.GetString("roomPassword");
            roomLoginButton.Text = mainForm.RessourceManager.GetString("logIn");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            mainForm.BackView();
        }

        private void roomLoginButton_Click(object sender, EventArgs e)
        {
            //TODO : Authentification IP Room et Mot de passe
            mainForm.ChangeView(new GameV(mainForm));
        }
    }
}
