using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Pictionary
{
    public partial class MainForm : Form
    {
        Stack<UserControl> history = new Stack<UserControl>();

        public MainForm()
        {
            InitializeComponent();
            LoginV loginV = new LoginV(this);
            ChangeView(loginV);
        }

        public void ChangeView(UserControl View)
        {
            this.Controls.Clear();
            this.Controls.Add(View);
            this.Width = View.Width + 16;
            this.Height = View.Height + 38;
            history.Push(View);
        }

        public void BackView()
        {
            history.Pop();
            ChangeView(history.Last());
        }
    }
}
