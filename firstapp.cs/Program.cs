﻿using System;

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
            }
        }
    }
}