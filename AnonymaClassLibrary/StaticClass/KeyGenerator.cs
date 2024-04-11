using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymaClassLibrary.StaticClass
{
    public static class KeyGenerator
    {
        public static string GenerateKey()
        {
            const int length = 30;
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            Random random = new Random();

            char[] randomChars = new char[length];
            for (int i = 0; i < length; i++)
                randomChars[i] = chars[random.Next(chars.Length)];
            return new string(randomChars);
        }
    }
}
