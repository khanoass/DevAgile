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
    /// <summary>
    /// Page de connexion à un compte
    /// </summary>
    public partial class LoginV : UserControl
    {
        private MainForm mainForm;

        public LoginV(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            TitleLabel.Text = mainForm.RessourceManager.GetString("logIn");
            usernameLabel.Text = mainForm.RessourceManager.GetString("username");
            passwordLabel.Text = mainForm.RessourceManager.GetString("password");
            loginButton.Text = mainForm.RessourceManager.GetString("logIn");
            loginGuestLabel.Text = mainForm.RessourceManager.GetString("logInAsGuest");
            CreateAccountLabel.Text = mainForm.RessourceManager.GetString("titleAccountCreation");
        }

        /// <summary>
        /// Création d'un compte invité
        /// </summary>
        private void loginGuestLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (mainForm.AuthController.CreateGuestAccount())
            {
                mainForm.ChangeView(new RoomActionV(mainForm));
            }
            else
            {
                MessageBox.Show("Erreur lors de la création d'un compte invité");
            }
        }

        /// <summary>
        /// Connexion à un compte
        /// </summary>
        private void loginButton_Click(object sender, EventArgs e)
        {
            //Vérification du pattern du nom d'utilisateur et du mot de passe
            if (mainForm.AuthController.RegexUsername(usernameTextBox.Text) && mainForm.AuthController.RegexPassword(passwordTextBox.Text))
            {
                if (mainForm.AuthController.Log_in(usernameTextBox.Text, passwordTextBox.Text))
                {
                    mainForm.ChangeView(new RoomActionV(mainForm));
                }
                else
                {
                    MessageBox.Show("Erreur d'authentification");
                }
            }
            else
            {
                MessageBox.Show("Erreur d'authentification");
            }
        }

        private void CreateAccountLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {            
            mainForm.ChangeView(new CreateAccountV(mainForm));
        }
    }
}
