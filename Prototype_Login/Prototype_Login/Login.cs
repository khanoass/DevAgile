using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Prototype_Login
{
    public partial class Login : Form
    {
        MySqlConnection pictionnary = new MySqlConnection("database=db_pictionnary; server=172.16.30.244; user id=root; pwd=root");
        MySqlCommand cmd;

        public Login()
        {

            InitializeComponent();
            cmd = pictionnary.CreateCommand();

        }

        private void btnValidation_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {

        }
    }
}
