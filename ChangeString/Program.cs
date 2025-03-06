using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Write something");

            string frase = Console.ReadLine();

            Console.WriteLine("Write a character");

            string x = Console.ReadLine();

            char character = char.Parse(x);

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == character)
                {
                    Console.Write("x");
                }
                else
                {
                    Console.Write(frase[i]);
                }

            }


        }
    }
}
