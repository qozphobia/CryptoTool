using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CryptoTool.Crypto
{
    public class Md5Hasher : HasherBase
    {
        public override string Name => "MD5";

        public override string ComputeHash(string input)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = MD5.HashData(inputBytes); 
            return Convert.ToHexString(hashBytes);
        }
    }
}
