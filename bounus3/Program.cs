using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bounus3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\t\t\twelcome to the Guess a Number Game!");
            Console.ResetColor();

            Console.WriteLine("to start the Game I would like to have your Name please?");
            string name = Console.ReadLine();
            Console.WriteLine($"OK...\n{name.ToUpper()}, I'm thinking of a number between 1 and 100 !!!\ntry to geuss it ");
            int numgeuss = 0;


            while (true)
            {
                numgeuss++;

                bool outInt = int.TryParse(Console.ReadLine(), out int input);
                Random random = new Random();
                int x = random.Next(1, 5);
                if (outInt)
                {

                    if (input == x)
                    {
                        Console.WriteLine($"{name}, well done");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"you have geuss it in {numgeuss} tries");
                        Console.Beep(120, 5000);
                        Console.ReadKey();
                        break;
                    }
                    else if (input > x)
                    {
                        Console.WriteLine($"{name}, your number is little high");
                    }
                    else if (input < x)
                    {
                        Console.WriteLine($"{name}, your number is little low");

                    }
                    else
                    {
                        Console.WriteLine("sorry try again ");
                        Console.Clear();
                    }
                }
                else
                {
                    Console.WriteLine("please use an intger number!!");
                    continue;
                }
            }
        }
    }
}
