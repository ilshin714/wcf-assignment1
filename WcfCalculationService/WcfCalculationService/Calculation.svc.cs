/*
 * Program : PROG-3170 Distributed Applications Development
 * Professor : Tapas Mandal
 * Title : Assignment1 
 * Author : Ilshin Ji 
 * Student Number : 8679480
 * History
 *          Created   : October 9 2022
 *          Modified  : October 10 2022
 */

using System;

namespace WcfCalculationService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Calculation" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Calculation.svc or Calculation.svc.cs at the Solution Explorer and start debugging.
    public class Calculation : ICalculation
    {
        // 1) Check if the int parater is prime numer. 
        public string IsPrimeNumber(int number)
        {
            int primeNumbercheck = 0;
            for (int i = 1; i <= number; i++)
            {
                if(number % i == 0)
                {
                    primeNumbercheck++;
                }
            }

            if (primeNumbercheck == 2)
            {
                return "Prime Number";
            }

            return "Not a Prime Number";
        }

        // 2) Print sum of all the digits of the int parameter
        public int SumDigits(string numberString)
        {
            int sumOfDigits = 0;
            for(int i = 0; i <numberString.Length; i++)
            {
                sumOfDigits += int.Parse(numberString[i].ToString());
            }

            return sumOfDigits;
        }

        // 3) Reverse the string paramter and return the result
        public string ReverseString(string word)
        {
            string reversedWord = "";
            for (int i = word.Length -1; i >= 0; i--)
            {
                reversedWord += word[i].ToString();
            }

            return reversedWord;
        }

        // 4) Print HTML tags to the string paramter and print the tag string
        public string PrintHTMLString(string tag, string text)
        {
            return $"<{tag}> {text} </{tag}>";
        }



        // 5) get sort type and an array of 5 numbers,
        // sort 5 numbers accordin to the sort type and return the array
        public int[] SortFiveNumbers(string sortType, int[] numbers)
        {
            if (sortType.Equals("1"))
            {
                Array.Sort(numbers);
            }
            else
            {
                Array.Sort(numbers);
                Array.Reverse(numbers);
            }

            return numbers;
        }


    }
}
