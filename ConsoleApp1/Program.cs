using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int counter = 0;

       for(int i =1; i<= 100; i++)
       {
           if (i% 3 ==0)
           {
           Console.WriteLine(i);
           counter++;
           }

       }

       Console.WriteLine($"Total {counter}");
       Console.ReadLine();*/

            //TASK 2
            /*Random rnd = new Random();
            int randomNumber = rnd.Next(1, 11);
            int counter = 0;
            bool gameOver = false;

            while (!gameOver)
            {
                Console.WriteLine($"Enter number between 1 to 10:");
                int userNumber = int.Parse(Console.ReadLine());


                if (userNumber == randomNumber)
                {
                    Console.WriteLine("You won!");
                    gameOver = true;
                }
                else
                {
                    Console.WriteLine("Try again!");
                    counter++;

                }

                if (counter == 4)
                {
                    Console.WriteLine($"You lost! Cpu number was {randomNumber}");
                }



            }

            Console.ReadLine();*/

            //Functions //DRY - Do not repeat yourself kui on vaja midagi korrata, siis selleks tehakse funktsioon.
            //esimene võimalus ilma funktsioonita:
            /*int a = 5;
            int b = 5;
            int c = a + b;
            Console.WriteLine($"Result without Main: {c}");
            Sum(a, b);
            Sum(10, 20);
            Hello();*/

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            GreetByName(name);
            GreetByName("Anu");
        }
        
        public static void Sum(int x, int y)
        {
            Console.WriteLine($"result: {x + y}");
        }

        public static void Hello()
        {
            Console.WriteLine("Hello");
        }

        public static void GreetByName(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}
