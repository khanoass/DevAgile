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
    public partial class LoginV : UserControl
    {
        private MainForm mainForm;

        public LoginV(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void loginGuestLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainForm.ChangeView(new RoomActionV(mainForm));
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            mainForm.ChangeView(new RoomActionV(mainForm));
        }

        private void CreateAccountLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainForm.ChangeView(new CreateAccountV(mainForm));
        }
    }
}
