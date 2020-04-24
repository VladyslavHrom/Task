using System;

namespace Correction
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            int length = sentence.Length;

            for (int i = 0; i < length; i++)
            {
                sentence = sentence.Replace("  ", " ");

            }
            Console.WriteLine($"{sentence}");
            Console.ReadLine();
        }
    }
}
