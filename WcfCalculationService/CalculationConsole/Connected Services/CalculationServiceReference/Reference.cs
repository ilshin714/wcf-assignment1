﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalculationConsole.CalculationServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalculationServiceReference.ICalculation")]
    public interface ICalculation {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculation/IsPrimeNumber", ReplyAction="http://tempuri.org/ICalculation/IsPrimeNumberResponse")]
        string IsPrimeNumber(int number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculation/IsPrimeNumber", ReplyAction="http://tempuri.org/ICalculation/IsPrimeNumberResponse")]
        System.Threading.Tasks.Task<string> IsPrimeNumberAsync(int number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculation/SumDigits", ReplyAction="http://tempuri.org/ICalculation/SumDigitsResponse")]
        int SumDigits(int number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculation/SumDigits", ReplyAction="http://tempuri.org/ICalculation/SumDigitsResponse")]
        System.Threading.Tasks.Task<int> SumDigitsAsync(int number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculation/ReverseString", ReplyAction="http://tempuri.org/ICalculation/ReverseStringResponse")]
        string ReverseString(string word);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculation/ReverseString", ReplyAction="http://tempuri.org/ICalculation/ReverseStringResponse")]
        System.Threading.Tasks.Task<string> ReverseStringAsync(string word);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculation/PrintHTMLString", ReplyAction="http://tempuri.org/ICalculation/PrintHTMLStringResponse")]
        void PrintHTMLString(string tag, string text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculation/PrintHTMLString", ReplyAction="http://tempuri.org/ICalculation/PrintHTMLStringResponse")]
        System.Threading.Tasks.Task PrintHTMLStringAsync(string tag, string text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculation/SortFiveNumbers", ReplyAction="http://tempuri.org/ICalculation/SortFiveNumbersResponse")]
        int[] SortFiveNumbers(int[] numbers);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculation/SortFiveNumbers", ReplyAction="http://tempuri.org/ICalculation/SortFiveNumbersResponse")]
        System.Threading.Tasks.Task<int[]> SortFiveNumbersAsync(int[] numbers);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculationChannel : CalculationConsole.CalculationServiceReference.ICalculation, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculationClient : System.ServiceModel.ClientBase<CalculationConsole.CalculationServiceReference.ICalculation>, CalculationConsole.CalculationServiceReference.ICalculation {
        
        public CalculationClient() {
        }
        
        public CalculationClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculationClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculationClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculationClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string IsPrimeNumber(int number) {
            return base.Channel.IsPrimeNumber(number);
        }
        
        public System.Threading.Tasks.Task<string> IsPrimeNumberAsync(int number) {
            return base.Channel.IsPrimeNumberAsync(number);
        }
        
        public int SumDigits(int number) {
            return base.Channel.SumDigits(number);
        }
        
        public System.Threading.Tasks.Task<int> SumDigitsAsync(int number) {
            return base.Channel.SumDigitsAsync(number);
        }
        
        public string ReverseString(string word) {
            return base.Channel.ReverseString(word);
        }
        
        public System.Threading.Tasks.Task<string> ReverseStringAsync(string word) {
            return base.Channel.ReverseStringAsync(word);
        }
        
        public void PrintHTMLString(string tag, string text) {
            base.Channel.PrintHTMLString(tag, text);
        }
        
        public System.Threading.Tasks.Task PrintHTMLStringAsync(string tag, string text) {
            return base.Channel.PrintHTMLStringAsync(tag, text);
        }
        
        public int[] SortFiveNumbers(int[] numbers) {
            return base.Channel.SortFiveNumbers(numbers);
        }
        
        public System.Threading.Tasks.Task<int[]> SortFiveNumbersAsync(int[] numbers) {
            return base.Channel.SortFiveNumbersAsync(numbers);
        }
    }
}
