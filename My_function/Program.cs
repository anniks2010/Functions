using System;

namespace My_function
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your favorate color?");
            string color = Console.ReadLine();

            KnowMe(name,color);
            
            //KnowMe("Anu","blue");
            
        }
        public static void KnowMe(string name, string color)
        {
            Console.WriteLine($"Hello, {name}. Your favorate color is {color}.");
        }
    }
}
