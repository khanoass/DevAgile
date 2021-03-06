﻿//  ETML
//  Auteur : Martin Moulin
//  Date : 04.02.2019
//  Description : Connecteur à la base de données

using MySql.Data.MySqlClient;
using System;

namespace P_Pictionary.Models
{
    /// <summary>
    /// Connecteur à la base de données
    /// </summary>
    public class DataBaseConnector
    {
        /// <summary>
        /// Connecteur à la base de données
        /// </summary>
        private MySqlConnection databaseConnection;

        /// <summary>
        /// Commande SQL
        /// </summary>
        private MySqlCommand sqlCommand;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="database">Nom de la base de donnée</param>
        /// <param name="serverIP">IP du serveur</param>
        /// <param name="username">Nom d'utilisateur de connexion</param>
        /// <param name="password">Mot de passe de l'utilisateur</param>
        public DataBaseConnector(string database, string serverIP, string username, string password)
        {
            //Définition des attributs de connexion et création de la commande
            databaseConnection = new MySqlConnection($"database={database}; server={serverIP}; user id={username}; pwd={password}");
            sqlCommand = databaseConnection.CreateCommand();
        }

        /// <summary>
        /// Tentative de connexion à la BD
        /// </summary>
        /// <returns>bool</returns>
        public bool Connect()
        {
            try
            {
                databaseConnection.Open();
            }
            catch
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Cherche le mot de passe pour un utilisateur
        /// </summary>
        /// <param name="username">Nom d'utilisateur</param>
        /// <returns>mot de passe (hâché)</returns>
        public object FindPassword(string username)
        {
            //Écriture de la commande
            sqlCommand.CommandText = $"SELECT usrPasswordHash FROM t_user WHERE usrName=\"{username}\";";

            //Exécution de la commande
            return sqlCommand.ExecuteScalar();
        }

        /// <summary>
        /// Création d'un compte
        /// </summary>
        /// <param name="username">Nom d'utilisateur</param>
        /// <param name="password">Mot de passe</param>
        /// <returns>bool définissant si la création du compte a réussi</returns>
        public bool CreateAccount(string username, string password, bool isGuest = false)
        {
            string strIsGuest = isGuest ? "TRUE" : "FALSE";

            //Écriture de la commande
            sqlCommand.CommandText = $"INSERT INTO t_user (usrName, usrPasswordHash, usrIsGuest) VALUES (\"{username}\", \"{password}\", {strIsGuest});";

            //Exécution de la commande
            return sqlCommand.ExecuteNonQuery() == 1;
        }

        /// <summary>
        /// Comptage du nombre de comptes guest
        /// </summary>
        /// <returns>nombre de comptes guest</returns>
        public int GetNewGuestNumber()
        {
            //Écriture de la commande
            sqlCommand.CommandText = $"SELECT COUNT(idUser) FROM t_user WHERE usrIsGuest = TRUE;";

            //Exécution de la commande
            object result = sqlCommand.ExecuteScalar();

            //renvoi du Résultat
            if(result is null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(result);
            }
        }

        /// <summary>
        /// Vérifie l'unicité du nom d'utilisateur
        /// </summary>
        /// <param name="username">Nom d'utilisateur</param>
        /// <returns>bool</returns>
        public bool CheckUniquenessUsername(string username)
        {
            //Écriture de la commande
            sqlCommand.CommandText = $"SELECT COUNT(idUser) FROM t_user WHERE usrName=\"{username}\";";

            //Exécution de la commande
            return (long)sqlCommand.ExecuteScalar() == 0;
        }
    }
}
