using System;
using System.Security.Cryptography;
using System.Text;

namespace Szyfrator
{
    public class Password
    {
        private static string pwd = "";
        private static SHA256 sha256Hash = SHA256.Create();

        public static bool checkPassword(string pass, string hash)
        {
            return VerifyHash(sha256Hash, pass, hash);
        }

        public static bool checkPassword(string pass)
        {
            return VerifyHash(sha256Hash, pass, pwd);
        }

        public static void setHash(string pass)
        {
            pwd = GetHash(sha256Hash, pass);
        }

        public static string getPassword()
        {
            return pwd;
        }

        public static bool setPassword(string pass)
        {
            pwd = pass;
            return true;
        }
        public int id
        {
            get;
            set;
        }
        
        public string name
        {
            get;
            set;
        }

        public string login
        {
            get;
            set;
        }

        public string password
        {
            get;
            set;
        }

        public string email
        {
            get;
            set;
        }

        public string notes
        {
            get;
            set;
        }

        private static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            var sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        // Verify a hash against a string.
        private static bool VerifyHash(HashAlgorithm hashAlgorithm, string input, string hash)
        {
            // Hash the input.
            var hashOfInput = GetHash(hashAlgorithm, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            return comparer.Compare(hashOfInput, hash) == 0;
        }

    }
}