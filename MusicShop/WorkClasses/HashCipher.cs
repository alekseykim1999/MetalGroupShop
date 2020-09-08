using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.WorkClasses
{
    public class HashCipher
    {
        HashAlgorithm algorithm = new MD5CryptoServiceProvider();
        //MD5
        public string HashFunction(string _data)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(_data);

            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);

            return BitConverter.ToString(hashedBytes);
        }
    }
}
