using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CryptoTool.Crypto
{
    public class DesCipher : CipherBase
    {
        private readonly byte[] _key;
        private readonly byte[] _iv;

        public DesCipher()
        {
            using var des = DES.Create();
            _key = des.Key;  
            _iv = des.IV;    
        }

        public override string Name => "DES";

        public override string Encrypt(string plainText)
        {
            using var des = DES.Create();
            des.Key = _key;
            des.IV = _iv;

            using var encryptor = des.CreateEncryptor();
            byte[] inputBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] encrypted = encryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);

            return Convert.ToBase64String(encrypted);
        }

        public override string Decrypt(string cipherText)
        {
            using var des = DES.Create();
            des.Key = _key;
            des.IV = _iv;

            using var decryptor = des.CreateDecryptor();
            byte[] inputBytes = Convert.FromBase64String(cipherText);
            byte[] decrypted = decryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);

            return Encoding.UTF8.GetString(decrypted);
        }
    }
}
