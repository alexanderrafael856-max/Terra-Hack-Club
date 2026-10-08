using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Nice to meet you, " + name + "!");

            Console.WriteLine($"Nice to meet you, {name}!");
            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            Console.WriteLine($"You are {age} years old.");

        }
    }
}    