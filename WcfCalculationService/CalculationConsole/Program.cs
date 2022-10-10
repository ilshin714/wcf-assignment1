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
        // Import and declare the wcf service
        static CalculationServiceReference.CalculationClient client = new CalculationServiceReference.CalculationClient();

        static void Main(string[] args)
        {
            Console.WriteLine("Ilshin Ji PROG-3170 Assignment1");

            string selection = SelectOption();

            while (!selection.Equals("6"))
            {
                Console.WriteLine();
                switch (selection)
                {
                    case "1":
                        ComputePrimeNumber();
                        break;
                    case "2":
                        ComputeSumofDigits();
                        break;
                    case "3":
                        ComputeWordReverse();
                        break;
                    case "4":
                        ComputeTagGenereation();
                        break;
                    case "5":
                        Compute5NumberSort();
                        break;
                    default:
                        break;
                }
                Console.WriteLine();
                Console.WriteLine();
                selection = SelectOption();
                
            }
            Console.WriteLine("Bye Bye");
            Console.ReadLine();
        }

        static string SelectOption()
        {
            Console.WriteLine("Please type one of choice numbers below:");
            Console.WriteLine("1. Prime Number");
            Console.WriteLine("2. Sum of Digits");
            Console.WriteLine("3. Reverse a String");
            Console.WriteLine("4. Print HTML Tags");
            Console.WriteLine("5. Sort 5 Numbers");
            Console.WriteLine("6. Exit");
            Console.Write("Your number: ");
            return Console.ReadLine();
        }

        static void ComputePrimeNumber()
        {
            bool result = false;
            while (result == false)
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
        }

        static void ComputeSumofDigits()
        {
            bool result = false;
            while (result == false)
            {
                Console.Write("Type a numer to get the sum of each digit: ");
                string numberString = Console.ReadLine();
                result = int.TryParse(numberString, out int numberInt);
                if (result == true)
                {
                    Console.WriteLine($"The sum of digits is {client.SumDigits(numberString)}");
                }
                else
                {
                    Console.WriteLine("number is not correct");
                }
            }
        }

        static void ComputeWordReverse()
        {
            bool result = false;
            while (result == false)
            {
                Console.Write("Type a word to get reversed string: ");
                string word = Console.ReadLine();

                if (!string.IsNullOrEmpty(word))
                {
                    Console.WriteLine($"The reversed word {word} is {client.ReverseString(word)}");
                    result = true;
                }
            }
        }

        static void ComputeTagGenereation()
        {
            bool result = false;
            while (result == false)
            {
                Console.Write("Type a tag type to write HTML ex.) h1, p, div, etc.: ");
                string tag = Console.ReadLine();

                if (!string.IsNullOrEmpty(tag))
                {
                    Console.Write("Type a text to write HTML: ");
                    string text = Console.ReadLine();

                    if (!string.IsNullOrEmpty(text))
                    {
                        Console.WriteLine(client.PrintHTMLString(tag, text));
                        result = true;
                    }
                    else
                    {
                        Console.WriteLine("text is null or empty");
                    }
                }
                else
                {
                    Console.WriteLine("tag type string is null or empty");
                }
            }
        }

        static void Compute5NumberSort()
        {
            bool result = false;
            while (result == false)
            {
                Console.Write("Type the first number to sort : ");
                string numString = Console.ReadLine();
                bool checkResult = int.TryParse(numString, out int firstNum);
                int[] numberArray = new int[5];
                if (checkResult == true)
                {
                    numberArray[0] = firstNum;

                    Console.Write("Type the second number to sort : ");
                    numString = Console.ReadLine();
                    checkResult = int.TryParse(numString, out int secondNum);
                    if (checkResult == true)
                    {
                        numberArray[1] = secondNum;

                        Console.Write("Type the second number to sort : ");
                        numString = Console.ReadLine();
                        checkResult = int.TryParse(numString, out int thirdNum);
                        if (checkResult == true)
                        {
                            numberArray[2] = thirdNum;

                            Console.Write("Type the third number to sort : ");
                            numString = Console.ReadLine();
                            checkResult = int.TryParse(numString, out int fourthNum);
                            if (checkResult == true)
                            {
                                numberArray[3] = fourthNum;

                                Console.Write("Type the fourth number to sort : ");
                                numString = Console.ReadLine();
                                checkResult = int.TryParse(numString, out int fifthNum);
                                if (checkResult == true)
                                {
                                    numberArray[4] = fifthNum;

                                    Console.Write("Type the fourth number to sort : ");

                                    Console.Write("Type 1 to ascending order, 2 to descending order : ");
                                    string order = Console.ReadLine();
                                    if (order.Equals("1") == false || order.Equals("2") == false)
                                    {
                                        numberArray = client.SortFiveNumbers(order, numberArray);
                                        Console.Write("Sorted Numbers are ");
                                        Console.Write("[{0}]", string.Join(", ", numberArray));
                                        result = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("order is not correct");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("number is not correct");
                                }
                            }
                            else
                            {
                                Console.WriteLine("number is not correct");
                            }
                        }
                        else
                        {
                            Console.WriteLine("number is not correct");
                        }
                    }
                    else
                    {
                        Console.WriteLine("number is not correct");
                    }
                }
                else
                {
                    Console.WriteLine("number is not correct");
                }

            }
        }
    }
}
