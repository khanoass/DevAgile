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
    public partial class GameV : UserControl
    {
        private MainForm mainForm;

        public GameV(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            btnCreateChangeRoom.Text = mainForm.RessourceManager.GetString("createChangeRoom");
            btnQuit.Text = mainForm.RessourceManager.GetString("quit");
            lblWord.Text = mainForm.RessourceManager.GetString("wordToDraw");
            btnReady.Text = mainForm.RessourceManager.GetString("ready");
            lblColor.Text = mainForm.RessourceManager.GetString("color");
            lblSize.Text = mainForm.RessourceManager.GetString("size");
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCreateChangeRoom_Click(object sender, EventArgs e)
        {
            mainForm.ChangeView(new RoomActionV(mainForm));
        }

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            btnChooseColor.BackColor = colorDialog.Color;
        }

        private void GameV_Load(object sender, EventArgs e)
        {

        }
    }
}
