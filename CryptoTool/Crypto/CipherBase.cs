using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoTool.Crypto
{
    public abstract class CipherBase
    {
        public abstract string Name { get; }

        public abstract string Encrypt(string plainText);
        public abstract string Decrypt(string cipherText);
    }
}
