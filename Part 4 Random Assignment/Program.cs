using System;

namespace Part_4_Random_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            //Part One: Random Integers
            Console.WriteLine("Pick two numbers in a range and I");
            Console.WriteLine("will show you five random numbers in that range:");
            string inputOne = Console.ReadLine();
            string inputTwo = Console.ReadLine();
            int one = Convert.ToInt32(inputOne);
            int two = Convert.ToInt32(inputTwo);
            two = (two - 1);
            int numberOne = generator.Next(one, two);
            int numberTwo = generator.Next(one, two);
            int numberThree = generator.Next(one, two);
            int numberFour = generator.Next(one, two);
            int numberFive = generator.Next(one, two);
            Console.WriteLine("The random numbers are:");
            Console.Write($"{numberOne}  {numberTwo}  {numberThree}  {numberFour}  {numberFive}");
            Console.WriteLine("");
            Console.WriteLine("");

            //Part Two: Dice Roller
            Console.WriteLine("Okay now lets roll some dice...");
            Console.WriteLine("Press Enter to roll dice one:");
            Console.ReadLine();
            Console.WriteLine("   _______");
            Console.WriteLine("  /\\ o o o\\ ");
            Console.WriteLine(" /o \\ o o o\\ ");
            Console.WriteLine("(    )------)");
            Console.WriteLine(" \\ o/  o   /");
            Console.WriteLine("  \\/______/ ");
            Console.WriteLine("");
            int rollOne = generator.Next(1, 6);
            Console.WriteLine($"Dice One:     {rollOne}");
            Console.WriteLine("Press Enter to roll dice two:");
            Console.ReadLine();
            Console.WriteLine("   _______");
            Console.WriteLine("  /\\ o  o \\ ");
            Console.WriteLine(" /o \\ o  o \\ ");
            Console.WriteLine("(    )------)");
            Console.WriteLine(" \\ o/ o o o/");
            Console.WriteLine("  \\/______/ ");
            Console.WriteLine("");
            int rollTwo = generator.Next(1, 6);
            Console.WriteLine($"Dice Two:     {rollTwo}");
            Console.WriteLine("");

            //Part Three: Random Decimal Numbers
            Console.WriteLine("Now lets find some random decimal numbers...");
            Console.ReadLine();
            double randOne = generator.NextDouble();
            double randTwo = generator.NextDouble();
            double randThree = generator.NextDouble();
            int ranOne = generator.Next(one, two);
            int ranTwo = generator.Next(one, two);
            int ranThree = generator.Next(one, two);
            Console.WriteLine("The three random decimal numbers are:");
            Console.WriteLine($"{randOne:N3} + {ranOne:N3}  {randTwo:N3} + {ranTwo:N3}  {randThree:N3} + {ranThree:N3}");
            Console.WriteLine("");
            
        }
    }
}