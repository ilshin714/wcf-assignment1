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

using System.ServiceModel;

namespace WcfCalculationService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalculation" in both code and config file together.
    [ServiceContract]
    public interface ICalculation
    {
        // 1) Check if the int parater is prime numer. 
        [OperationContract]
        string IsPrimeNumber(int number);

        // 2) Print sum of all the digits of the int parameter
        [OperationContract]
        int SumDigits(string number);

        // 3) Reverse the string paramter and return the result
        [OperationContract]
        string ReverseString(string word);

        // 4) Print HTML tags to the string paramter and print the tag string
        [OperationContract]
        string PrintHTMLString(string tag, string text);

        // 5) get sort type and an array of 5 numbers,
        // sort 5 numbers accordin to the sort type and return the array
        [OperationContract]
        int[] SortFiveNumbers(string orderType, int[] numbers);
    }
}
