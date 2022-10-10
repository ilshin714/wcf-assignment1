using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfCalculationService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Calculation" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Calculation.svc or Calculation.svc.cs at the Solution Explorer and start debugging.
    public class Calculation : ICalculation
    {

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

        public void PrintHTMLString(string tag, string text)
        {
            throw new NotImplementedException();
        }

        public string ReverseString(string word)
        {
            return word;
        }

        public int[] SortFiveNumbers(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int SumDigits(int number)
        {
            throw new NotImplementedException();
        }
    }
}
