//  ETML
//  Auteur : Martin Moulin
//  Date : 28.01.2019
//  Description : Hâcheur de chaîne de caractères

using System.Text;
using System.Security.Cryptography;

namespace Prototype_Login
{
    /// <summary>
    /// Hâcheur (source: https://stackoverflow.com/questions/3984138/hash-string-in-c-sharp)
    /// </summary>
    class Hasher
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
            StringBuilder sb = new StringBuilder();

            //Conversion du tableau de bytes en string
            foreach (byte b in result)
            {
                sb.Append(b.ToString("X2"));
            }

            return sb.ToString();
        }
    }
}
