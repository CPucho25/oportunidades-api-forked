//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;


using System;
using System.Security.Cryptography;

using Microsoft.AspNetCore.Cryptography.KeyDerivation;
namespace BF.Objeto.Password
{
    public class Encriptador
    {
        private string key = "eydigital";
        private byte[] salt;

        public Encriptador()
        {
            this.salt = new byte[128 / 8];
        }

        public string HashPaswword(string password)
        {
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            return Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8)) + Convert.ToBase64String(salt);
        }
        public bool CompararPasswords(string password, string bd_password)
        {
            byte[] saltbd = Convert.FromBase64String(bd_password.Substring(44, 24));
            string passbd = bd_password.Substring(0, 44);

            string hash = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: saltbd,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));
            if (passbd == hash)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

