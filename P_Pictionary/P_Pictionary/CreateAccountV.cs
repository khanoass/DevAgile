﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P_Pictionary.Controllers;
using System.Resources;

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

            titleLabel.Text = mainForm.RessourceManager.GetString("titleAccountCreation");
            usernameLabel.Text = mainForm.RessourceManager.GetString("username");
            passwordLabel.Text = mainForm.RessourceManager.GetString("password");
            createButton.Text = mainForm.RessourceManager.GetString("create");
        }

        /// <summary>
        /// Création d'un compte
        /// </summary>
        private void createButton_Click(object sender, EventArgs e)
        {
            //Vérification du pattern du nom d'utilisateur et du mot de passe
            if (mainForm.AuthController.RegexUsername(usernameTextBox.Text) && mainForm.AuthController.RegexPassword(passwordTextBox.Text))
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
            else
            {
                MessageBox.Show("Le nom d'utlisateur ne peut contenir que des lettres, chiffres et séparateur\nLe mot de passe doit contenir au moins 1 majuscule, minuscule, chiffre, caractère spécial et être long de 8 caractères ou plus.");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            mainForm.BackView();
        }
    }
}
