using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IL2CPP_Encryption.CLI
{
    public class Cryptography
    {
        public static byte GenerateByte()
        {
            byte randomByte;
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                byte[] buffer = new byte[1];
                rng.GetBytes(buffer);
                randomByte = buffer[0];
            }

            return randomByte;
        }

        public static byte GenerateLargeByte()
        {
            byte randomByte;
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                do
                {
                    byte[] buffer = new byte[1];
                    rng.GetBytes(buffer);
                    randomByte = buffer[0];

                } while (randomByte < 100 || randomByte > 255);
            }

            return randomByte;
        }
    }
}
