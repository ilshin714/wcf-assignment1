using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CalculationConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Import and declare the wcf service
            CalculationServiceReference.CalculationClient client = new CalculationServiceReference.CalculationClient();

            bool result = false;
            while(result == false)
            {
                Console.Write("Type a numer to check if it is a prime number: ");
                string numberString = Console.ReadLine();
                result = int.TryParse(numberString, out int numberInt);
                if (result == true)
                {
                    Console.WriteLine(client.IsPrimeNumber(numberInt));
                }
                else
                {
                    Console.WriteLine("number is not correct");
                }
            }
           

            Console.ReadLine();
        }
    }
}
