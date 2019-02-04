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
    public partial class CreateAccountV : UserControl
    {
        private MainForm mainForm;

        public CreateAccountV(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            mainForm.ChangeView(new RoomActionV(mainForm));
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            mainForm.BackView();
        }
    }
}
