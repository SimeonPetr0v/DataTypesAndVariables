﻿namespace ConcatNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            string dr = Console.ReadLine();
            Console.WriteLine($"{name1}{dr}{name2}");
        }
    }
}