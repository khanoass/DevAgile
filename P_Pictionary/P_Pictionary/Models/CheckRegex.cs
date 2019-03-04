//  ETML
//  Auteur : Leonel Saez
//  Date : 22.02.2019
//  Description : Modèle pour les expressions régulières

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Pictionary.Models
{
    public class CheckRegex
    {
        public string checkRoomIP { get; }
        public string checkUsername { get; }
        public string checkPassword { get;}
        
        public CheckRegex()
        {
            checkRoomIP = @"^(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9]?[0-9])\.(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9]?[0-9])\.(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9]?[0-9])\.(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9]?[0-9])$";
            
            // Ne peut contenir que des lettres, des chiffres, des séparateurs et des caractères spéciaux
            checkUsername = @"^[a-zA-Z0-9]+([+,.=()*_ -]?[a-zA-Z0-9])*$";
            
            // Doit contenir au moins 1 minuscule, majuscule, chiffre, caractère spécial, et avoir 8 caractères ou plus.
            checkPassword = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[+.,=()\-_!@#\$%\^&\*])(?=.{8,})$";
        }
    }
}
        