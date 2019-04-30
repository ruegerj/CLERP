using CLERP.Business.Security.Hashing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CLERP.DataAccess.Security.Hashing
{
    public class Sha512Hasher : IPasswordHasher
    {
        /// <summary>
        /// Hashes a plain password with a random salt
        /// </summary>
        /// <param name="plainPassword">plain password from employee</param>
        /// <returns>Hash including generated salt</returns>
        public IHashedPassword HashPassword(string plainPassword)
        {
            return HashPasswordWithSalt(plainPassword, String.Empty);
        }

        /// <summary>
        /// Compares a plain password with a hashed one
        /// </summary>
        /// <param name="plainPassword">Plain password</param>
        /// <param name="hashedPassword">Hash as Base64String</param>
        /// <param name="salt">Salt as Base64String</param>
        /// <returns>hashes match?</returns>
        public bool PasswordMatches(string plainPassword, string hashedPassword, string salt)
        {
            var tempHash = HashPasswordWithSalt(plainPassword, salt);

            return String.Equals(tempHash.HashBase64, hashedPassword);
        }

        /// <summary>
        /// Hashes a plain password with a defined salt or when empty generates a new salt
        /// Is private because every salt should be generated randomly
        /// </summary>
        /// <param name="plainPassword">plain password as string</param>
        /// <param name="salt">Salt as Base64-String which should be added to the hash, leave empty when a new random hash should be generated</param>
        /// <returns></returns>
        private HashedPassword HashPasswordWithSalt(string plainPassword, string salt)
        {            
            byte[] saltBytes = String.IsNullOrEmpty(salt) ? GenerateSalt() : Convert.FromBase64String(salt);
            byte[] plainPasswordBytes = Encoding.UTF8.GetBytes(plainPassword);

            byte[] passwordWithSaltBytes = CombineByteArrays(plainPasswordBytes, saltBytes);

            using (var sha512Algorythm = SHA512.Create())
            {
                byte[] hashBytes = sha512Algorythm.ComputeHash(passwordWithSaltBytes);

                return new HashedPassword(Convert.ToBase64String(hashBytes), Convert.ToBase64String(saltBytes));
            }
        }


        /// <summary>
        /// Generates a salt value using <see cref="RNGCryptoServiceProvider"/>
        /// </summary>
        /// <param name="size">Size the generated salt should have (Default = 64) in bytes</param>
        /// <returns>Random salt as byte array</returns>
        private byte[] GenerateSalt(int size = 64)
        {
            byte[] saltBytes = new byte[size];

            using (var cryptoRNG = RNGCryptoServiceProvider.Create())
            {
                cryptoRNG.GetBytes(saltBytes, 0, size);
            }

            return saltBytes;
        }

        private byte[] CombineByteArrays(byte[] array1, byte[] array2)
        {
            byte[] result = new byte[array1.Length + array2.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                result[i] = array1[i];
            }

            for (int i = 0; i < array2.Length; i++)
            {
                result[array1.Length + i] = array2[i];
            }

            return result;
        }
    }
}
