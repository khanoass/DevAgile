//  ETML
//  Auteur : Martin Moulin
//  Date : 04.02.2019
//  Description : Contrôleur d'authentification et création de compte

using P_Pictionary.Models;
using System.Text.RegularExpressions;

namespace P_Pictionary.Controllers
{
    /// <summary>
    /// Contrôleur d'authentification et création de compte
    /// </summary>
    public class AuthenticationController
    {
        /// <summary>
        /// Connecteur à la base de donnéess
        /// </summary>
        private DataBaseConnector model;

        /// <summary>
        /// Modèle pour les expressions régulières
        /// </summary>
        private CheckRegex checkRegex;

        /// <summary>
        /// Constructeur
        /// </summary>
        public AuthenticationController()
        {
            //Construction du connecteur à la base de données
            model = new DataBaseConnector("db_pictionnary", "172.16.30.244", "pictionnary", ".Etml-");
            //Modèle pour les expressions régulières
            checkRegex = new CheckRegex();
        }

        /// <summary>
        /// Initialise le contrôleur
        /// </summary>
        /// <returns>Booléen définissant si l'initialisation a réussi</returns>
        public bool Init()
        {
            return model.Connect();
        }

        /// <summary>
        /// Vérifie le pattern du nom d'utilisateur 
        /// </summary>
        /// <param name="username">Nom d'utilisateur</param>
        /// <returns>bool</returns>
        public bool RegexUsername(string username)
        {
            Match match = Regex.Match(username, checkRegex.checkUsername);

            if (match.Success)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        /// <summary>
        /// Vérifie le pattern du mot de passe
        /// </summary>
        /// <param name="password">Mot de passe</param>
        /// <returns>bool</returns>
        public bool RegexPassword(string password)
        {
            Match match = Regex.Match(password, checkRegex.checkPassword);

            if (match.Success)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        /// <summary>
        /// Vérifie le pattern de l'adresse IP
        /// </summary>
        /// <param name="roomIP">IP de la salle</param>
        /// <returns>bool</returns>
        public bool RegexRoomIP(string roomIP)
        {
            Match match = Regex.Match(roomIP, checkRegex.checkRoomIP);

            if (match.Success)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        /// <summary>
        /// Vérification des informations de login
        /// </summary>
        /// <param name="username">Nom d'utilisateur</param>
        /// <param name="password">Mot de passe</param>
        /// <returns>bool</returns>
        public bool Log_in(string username, string password)
        {
            //Exécution de la commande
            object result = model.FindPassword(username);

            //Vérification du mot de passe
            return (string)result == Hasher.Hash(password);
        }

        /// <summary>
        /// Création d'un compte
        /// </summary>
        /// <param name="username">Nom d'utilisateur</param>
        /// <param name="password">Mot de passe</param>
        /// <returns>bool définissant si la création du compte a réussi</returns>
        public bool Sign_in(string username, string password)
        {
            //Vérifie la disponibilité du username
            if (model.CheckUniquenessUsername(username))
            {
                //Création du compte
                return model.CreateAccount(username, Hasher.Hash(password));
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Création d'un compte invité
        /// </summary>
        /// <returns>bool définissant si la création a réussi</returns>
        public bool CreateGuestAccount()
        {
            //Création de l'username
            string username = "Guest" + model.GetNewGuestNumber();

            //Vérification que ce compte n'existe pas
            if (model.CheckUniquenessUsername(username))
            {
                return model.CreateAccount(username, "", true);
            }
            else
            {
                return false;
            }
        }
    }
}
