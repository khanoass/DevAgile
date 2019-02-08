using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P_Pictionary.Controllers;

namespace P_Pictionary
{
    /// <summary>
    /// Page de création de compte
    /// </summary>
    public partial class CreateAccountV : UserControl
    { 
        private MainForm mainForm;

        public CreateAccountV(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        /// <summary>
        /// Création d'un compte
        /// </summary>
        private void createButton_Click(object sender, EventArgs e)
        {
            //Vérification des authenifiants
            if (mainForm.AuthController.Sign_in(usernameTextBox.Text, passwordTextBox.Text))
            {
                mainForm.ChangeView(new RoomActionV(mainForm));
            }
            else
            {
                MessageBox.Show("Erreur d'authentification");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            mainForm.BackView();
        }
    }
}
