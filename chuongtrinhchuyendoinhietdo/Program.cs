using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuongtrinhchuyendoinhietdo
{
    internal class Program
    {
        public static double Fahrenheit { get; private set; }

        static void Main(string[] args)
        {
            double F, C;
            int choice;

            do
            {
                Console.WriteLine("Menu: ");
                Console.WriteLine("1. F to C.");
                Console.WriteLine("2. C to F.");
                Console.WriteLine("0.Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter fahrenheit: ");
                        F = double.Parse(Console.ReadLine());
                        Console.WriteLine("Fahrenheit to Celsius: " + FToC(F));
                        break;
                    case 2:
                        Console.Write("Enter celsius: ");
                        C = double.Parse(Console.ReadLine());
                        Console.WriteLine("Fahrenheit to Celsius: " + CToF(C));
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            } while (choice != 0);
            Console.WriteLine();
        }
        public static double FToC(double Fahrenheit)
        {
            double celsius = (0.5 / 9) * Fahrenheit - 32;
            return celsius;
        }
        public static double CToF(double celsius)
        {
            double fahrenheit = (9.0 / 5) * celsius + 32;
            return fahrenheit;
        }
    }
}
