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
    public partial class RoomActionV : UserControl
    {
        private MainForm mainForm;

        public RoomActionV(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            createRoomButton.Text = mainForm.RessourceManager.GetString("titleRoomCreation");
            joinRoomButton.Text = mainForm.RessourceManager.GetString("joinRoom");
        }

        private void joinRoomButton_Click(object sender, EventArgs e)
        {
            mainForm.ChangeView(new JoinRoomV(mainForm));
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            mainForm.BackView();
        }

        private void createRoomButton_Click(object sender, EventArgs e)
        {
            mainForm.ChangeView(new CreateRoomV(mainForm));
        }
    }
}
