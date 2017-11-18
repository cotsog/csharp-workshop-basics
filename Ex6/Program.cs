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
            Calculate(2,2,null);
        }

        public static double Calculate(double number1, double number2, string op) {
            double resultado=0.0;
            if(op==null){
                //No cambiar el valor de resultado
            }
            else{
                string Operation=op.Trim();
                if(Operation=="*"){
                    resultado=number1*number2;
                }
                else if(Operation=="-"){
                    resultado=number1-number2;
                }
                else if(Operation=="/"){
                    if(number2==0){
                        resultado=0.0;
                    }
                    else{
                        resultado=number1/number2;
                    }
                }
                else if(Operation=="^"){
                    resultado=Math.Pow(number1,number2);
                }
                else if(Operation=="+"){
                    resultado=number1+number2;
                }
            }
            return resultado;
        }
    }
}
