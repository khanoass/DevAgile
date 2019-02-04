//  ETML
//  Auteur : Martin Moulin
//  Date : 04.02.2019
//  Description : Contrôleur d'authentification et création de compte

using Prototype_Login.Models;

namespace Prototype_Login.Controllers
{
    /// <summary>
    /// Contrôleur d'authentification et création de compte
    /// </summary>
    public class AuthenticationController
    {
        /// <summary>
        /// Connecteur à la base de donnéess
        /// </summary>
        private DataBaseConnector connector;

        /// <summary>
        /// Constructeur
        /// </summary>
        public AuthenticationController()
        {
            //Construction du connecteur à la base de données
            connector = new DataBaseConnector("db_pictionnary", "172.16.30.244", "pictionnary", ".Etml-");
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
            object result = connector.FindPassword(username);

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
            //TODO Vérifier la disponibilité du username

            //Création du compte
            return connector.CreateAccount(username, Hasher.Hash(password));
        }
    }
}
