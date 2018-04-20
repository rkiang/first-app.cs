using System;

namespace firstapp.cs
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Hello World!");
    //    }
    //}
    namespace Loops
    {
        class Program
        {
            static void Main(string[] args)
            {
                string yourName;
                Console.WriteLine("What is your name?");

                yourName = Console.ReadLine();

                Console.WriteLine("Hello {0}", yourName);

                Console.WriteLine("How many years of coding have you done?");

                int yrsXP = Convert.ToInt32(Console.ReadLine());

                if (yrsXP > 10)
                {
                    Console.WriteLine("Wow you must be an expert!");
                }
                else if (yrsXP > 2)
                {
                    Console.WriteLine("Good, I can learn from you.");
                }
                else
                {
                    Console.WriteLine("I'm probably at your level.");
                }
            }
        }
    }
}