using System;

namespace Mask_Sensitive_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell us a secret!");
            var secret = Console.ReadLine();

            var tellMe = secret.Length - 4;
            var lastFour = secret.Remove(0, tellMe);
            var mask = secret.Remove(tellMe);
            var changeLetters = new System.Text.StringBuilder();

            for (var i = 0; i < mask.Length; i++)
            {
                changeLetters.Append("$");
            }
            Console.WriteLine(changeLetters + lastFour);
        }
    }
}
