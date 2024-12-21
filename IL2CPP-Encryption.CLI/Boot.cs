using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL2CPP_Encryption.CLI
{
    internal class Boot
    {
        static void Main(string[] args)
        {
        RetryLabel:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Title = "Il2Cpp Encryptor - github.com/ZyloSG";
            Console.WriteLine("Welcome, " + Environment.UserName);
            Console.WriteLine("Enter your global-metadata's file path: ");
            string filePath = Console.ReadLine();
            byte[] fileBytes = File.ReadAllBytes(filePath);
            if (!File.Exists(filePath) || fileBytes == null)
            {
                Console.WriteLine("Invalid file path, please try again!");
                goto RetryLabel;
            }
            fileBytes[0] = Cryptography.GenerateByte();
            fileBytes[1] = Cryptography.GenerateByte();
            fileBytes[2] = Cryptography.GenerateByte();
            fileBytes[3] = Cryptography.GenerateByte();
            fileBytes[4] = Cryptography.GenerateLargeByte();
            File.WriteAllBytes(filePath.Replace(".dat", "_encrypted.dat"), fileBytes);
            Console.WriteLine("Done!");

           
        }
        


    }
}
