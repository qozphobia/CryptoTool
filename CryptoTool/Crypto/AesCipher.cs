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

        public override byte[] EncryptBytes(byte[] data)
        {
            using var aes = Aes.Create();
            aes.Key = _key;
            aes.IV = _iv;

            using var encryptor = aes.CreateEncryptor();
            return encryptor.TransformFinalBlock(data, 0, data.Length);
        }

        public override byte[] DecryptBytes(byte[] data)
        {
            using var aes = Aes.Create();
            aes.Key = _key;
            aes.IV = _iv;

            using var decryptor = aes.CreateDecryptor();
            return decryptor.TransformFinalBlock(data, 0, data.Length);
        }

        public override string Encrypt(string plainText)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] encrypted = EncryptBytes(inputBytes);
            return Convert.ToBase64String(encrypted);
        }

        public override string Decrypt(string cipherText)
        {
            byte[] inputBytes = Convert.FromBase64String(cipherText);
            byte[] decrypted = DecryptBytes(inputBytes);
            return Encoding.UTF8.GetString(decrypted);
        }
    }
}
