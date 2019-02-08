//  ETML
//  Auteur : Martin Moulin
//  Date : 28.01.2019
//  Description : Hâcheur de chaîne de caractères

using System.Text;
using System.Security.Cryptography;

namespace P_Pictionary
{
    /// <summary>
    /// Hâcheur (source: https://stackoverflow.com/questions/3984138/hash-string-in-c-sharp)
    /// </summary>
    public static class Hasher
    {
        /// <summary>
        /// Hâche un string et retourne un tableau de bytes
        /// </summary>
        /// <param name="input">string</param>
        /// <returns>byte[]</returns>
        private static byte[] GetHash(string input)
        {
            HashAlgorithm hashAlgorithmSHA256 = SHA256.Create();
            return hashAlgorithmSHA256.ComputeHash(Encoding.UTF8.GetBytes(input));
        }

        /// <summary>
        /// Hâche un string
        /// </summary>
        /// <param name="inputString">string</param>
        /// <returns>string</returns>
        public static string Hash(string inputString)
        {
            //Hachage du string
            byte[] result = GetHash(inputString);

            //Constructeur de string
            StringBuilder stringBuilder = new StringBuilder();

            //Conversion du tableau de bytes en string
            foreach (byte part in result)
            {
                stringBuilder.Append(part.ToString("X2"));
            }

            return stringBuilder.ToString();
        }
    }
}
