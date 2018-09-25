using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GodSharp.Encryption;

namespace TheConfigurator
{
    public static class Config
    {
        
        //public static bool LoadConfiguration(List<T> configurationCollection)
        //{
        //    return false;
        //}

        public static string Encrpyt(string unEncryptedString)
        {
            var result = TripleDES.Encrypt(unEncryptedString,string.Empty);

            return result;
        }

        public static string Decrypt(string encryptedString)
        {
            return TripleDES.Decrypt(encryptedString,string.Empty);
        }



    }
}
