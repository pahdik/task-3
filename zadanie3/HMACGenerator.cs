using System;
using System.Security.Cryptography;

namespace zadanie3
{
    class HMACGenerator
    {
        public byte[] key { get; set; }
        public HMACGenerator()
        {
            RandomNumberGenerator rand = RandomNumberGenerator.Create();
            key = new byte[32];
            rand.GetBytes(key);
        }
        public void showKey()
        {
            Console.WriteLine("HMAC key:\n"+BitConverter.ToString(key).Replace("-", "")+"\n\n");

        }
        public void generateHMAC(string str)
        {
            using (HMACSHA256 hmac = new HMACSHA256(key))
            {
                Console.WriteLine("HMAC:\n"+BitConverter.ToString(hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(str))).Replace("-", ""));
            }
        }

    }
}
