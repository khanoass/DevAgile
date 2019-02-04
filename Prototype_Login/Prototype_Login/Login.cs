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
using System.Text.RegularExpressions;

namespace Prototype_Login
{
    public partial class Login : Form
    {
        MySqlConnection pictionnary = new MySqlConnection("database=db_pictionnary; server=172.16.30.244; user id=pictionnary; pwd=.Etml-");
        MySqlCommand cmd;

        public Login()
        {

            InitializeComponent();
            cmd = pictionnary.CreateCommand();
            try
            {
                pictionnary.Open();
            }
            catch ( Exception erreur)
            {
                MessageBox.Show($"{erreur}\nConnexion a la base de donnée impossible");
            }


        }

        private void btnValidation_Click(object sender, EventArgs e)
        {

            cmd.CommandText = ($"SELECT usrName, usrPasswordHash from t_user WHERE usrName={txbLoginUserName.Text};");


        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {

        }

        private void txbLoginUserName_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txbLoginUserName.Text,""))
            {
                lblUserName.ForeColor = Color.Black;
                CheckTheMatch();
            }
            else
            {
                lblUserName.ForeColor = Color.Red;
            }
        }

        private void txbLoginPassword_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txbLoginPassword.Text, ""))
            {
                lblPassword.ForeColor = Color.Black;
                CheckTheMatch();
            }
            else
            {
                lblPassword.ForeColor = Color.Red;
            }
        }

        private void CheckTheMatch()
        {
            if(lblUserName.ForeColor == Color.Black && lblPassword.ForeColor == Color.Black)
            {
                btnValidation.Enabled = true;
            }
        }
    }
}
