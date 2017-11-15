/**
    Write a program that program that given two numbers
    number1, number2 and an string representing an operator
    ("*", "-", "/" and "^"), it applies the operation
    and returns the result.
    If anything goes wrong it should return 0.0.
    For example:
    1) using number1 = 5, number2 = 10 and op = "*" will return 50
    2) using number1 = 100, number2 = 20 and op = " - " will return 80
    And so forth...
    
    Method signature:     Calculate(double number1, double number2, string op)
    Return value:         doible
    Access modifier:      public static
 */

using System;
namespace Ex6
{
    public class Program
    {
        public static bool ENABLED = true;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static double Calculate(double number1, double number2, string op) {
            double salida=0.0; 
             switch (op)
             {
                 case "^": 
                 
                     salida= Math.Pow(number1,number2);
                     break;
                case "-": 
                    salida= number1-number2;
                    break;
                 case "*": 
                    salida= number1*number2;
                    break;
                 case "/": 
                    salida= number1/number2;
                    break;
                
                 default:
                 break;
             }
            return salida;
        }
    }
}
