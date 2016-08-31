using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Grand Circus!");
            Console.WriteLine("Do you want to Roll the Dice?");
            Console.WriteLine("yes/no");
            bool stopProgram = false;
            if (!stopProgram)
            {
                string Great = Console.ReadLine();
            }
            Console.WriteLine("Great");

            string answer = "yes";
            while (answer == "yes")
            {
                Console.WriteLine("Time to Roll the Dice");
                Console.WriteLine("Rollem");
                Console.WriteLine("Haa");
                Random generator = new Random();
                int number = generator.Next(7);
                Console.WriteLine(number);
                Random generator2 = new Random();
                int number2 = generator.Next(7);
                Console.WriteLine(number2);
                Console.WriteLine("Do you want to roll again?");
                Console.WriteLine("yes/no");
                answer = Console.ReadLine();
            }

        }
    }
}
