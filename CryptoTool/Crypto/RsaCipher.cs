using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CryptoTool.Crypto
{
    public class RsaCipher : CipherBase
    {
        private readonly RSA _rsa;

        public RsaCipher()
        {
            _rsa = RSA.Create(2048);
        }

        public override string Name => "RSA";

        public override string Encrypt(string plainText)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(plainText);

            byte[] encrypted = _rsa.Encrypt(inputBytes, RSAEncryptionPadding.OaepSHA256);

            return Convert.ToBase64String(encrypted);
        }

        public override string Decrypt(string cipherText)
        {
            byte[] inputBytes = Convert.FromBase64String(cipherText);
            byte[] decrypted = _rsa.Decrypt(inputBytes, RSAEncryptionPadding.OaepSHA256);

            return Encoding.UTF8.GetString(decrypted);
        }
    }
}
