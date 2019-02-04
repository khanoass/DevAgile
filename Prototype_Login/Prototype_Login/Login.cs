//  ETML
//  Auteur : Noah Delgado
//  Date : 28.01.2019
//  Description : Authentification

using System;
using System.Drawing;
using System.Windows.Forms;
using Prototype_Login.Controllers;
using System.Text.RegularExpressions;

namespace Prototype_Login
{
    /// <summary>
    /// Page d'authentification
    /// </summary>
    public partial class Login : Form
    {
        AuthenticationController authController;

        /// <summary>
        /// Constructeur
        /// </summary>
        public Login()
        {
            authController = new AuthenticationController();

            //Initialisation de la vue
            InitializeComponent();

        }

        /// <summary>
        /// Connexion à un compte
        /// </summary>
        private void Click_btnValidation(object sender, EventArgs e)
        {
            if(authController.Log_in(txbLoginUserName.Text, txbLoginPassword.Text))
            {
                MessageBox.Show("Vous êtes connecté");
            }
            else
            {
                MessageBox.Show("Mauvais mdp");
            }
        }

        /// <summary>
        /// Création d'un compte
        /// </summary>
        private void Click_buttonCreateAccount(object sender, EventArgs e)
        {
            authController.Sign_in(txbLoginUserName.Text, txbLoginPassword.Text);
        }

        private void TextChanged_txbLoginUserName(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txbLoginUserName.Text, ""))
            {
                lblUserName.ForeColor = Color.Black;
                CheckTheMatch();
            }
            else
            {
                lblUserName.ForeColor = Color.Red;
            }
        }

        private void TextChanged_txbLoginPassword(object sender, EventArgs e)
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
            if (lblUserName.ForeColor == Color.Black && lblPassword.ForeColor == Color.Black)
            {
                btnValidation.Enabled = true;
            }
        }
    }
}
