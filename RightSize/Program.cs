using System;
using System.ComponentModel.DataAnnotations;

namespace RightSize
{
    public class Program
    {
        private static void Main(string[] args)
        {
            foreach (string i in args)
            {

                if (i.Length >= 8)
                {
                    Console.WriteLine("[EARLY STOP]");
                    break;
                }

                if (i.Length > 3)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
