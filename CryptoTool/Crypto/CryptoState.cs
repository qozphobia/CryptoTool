using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoTool.Crypto
{
    public static class CryptoState
    {
        public static AesCipher Aes { get; } = new AesCipher();
        public static DesCipher Des { get; } = new DesCipher();
        public static RsaCipher Rsa { get; } = new RsaCipher();
        public static Sha256Hasher Sha256 { get; } = new Sha256Hasher();
        public static Md5Hasher Md5 { get; } = new Md5Hasher();
    }
}
