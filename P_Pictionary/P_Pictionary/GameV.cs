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
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCreateChangeRoom_Click(object sender, EventArgs e)
        {
            mainForm.ChangeView(new RoomActionV(mainForm));
        }
    }
}
