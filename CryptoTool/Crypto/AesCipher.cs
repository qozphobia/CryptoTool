using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CryptoTool.Crypto
{
    public class AesCipher : CipherBase
    {
        private readonly byte[] _key;
        private readonly byte[] _iv;

        public AesCipher()
        {
            using var aes = Aes.Create();
            _key = aes.Key;  
            _iv = aes.IV;    
        }

        public override string Name => "AES";

        public override string Encrypt(string plainText)
        {
            using var aes = Aes.Create();
            aes.Key = _key;
            aes.IV = _iv;

            using var encryptor = aes.CreateEncryptor();

            byte[] inputBytes = Encoding.UTF8.GetBytes(plainText);

            byte[] encrypted = encryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);

            return Convert.ToBase64String(encrypted);
        }

        public override string Decrypt(string cipherText)
        {
            using var aes = Aes.Create();
            aes.Key = _key;
            aes.IV = _iv;

            using var decryptor = aes.CreateDecryptor();

            byte[] inputBytes = Convert.FromBase64String(cipherText);
            byte[] decrypted = decryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);

            return Encoding.UTF8.GetString(decrypted);
        }
    }
}
