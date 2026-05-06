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

        public override byte[] EncryptBytes(byte[] data)
        {
            return _rsa.Encrypt(data, RSAEncryptionPadding.OaepSHA256);
        }

        public override byte[] DecryptBytes(byte[] data)
        {
            return _rsa.Decrypt(data, RSAEncryptionPadding.OaepSHA256);
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
