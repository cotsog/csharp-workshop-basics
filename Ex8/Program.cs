/**
    Write a program quite similar to the previous one.
    Given one integer number n
    returns the sum of all numbers from 1 to n.
    For example, given n = 5 it returns: 1+2+3+4+5 = 15
    Also consider when n is negative.
    For example, given n = -5 it returns: -1-2-3-4-5 = -15

    Method signature:     sum2N(int n)
    Return value:         int
    Access modifier:      public static
 */

using System;

namespace Ex8
{
    public class Program
    {
        public static bool ENABLED = true;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static int sum2NWithNegatives(int n) {
            int sumados=0;
                if(n>0){
                    //Realizamos un contador para sumar los valores de n
                    for(int i=1;i<=n;i++){
                        sumados+=i;
                    }
                }//Fin del IF n>0
                else if(n<0){
                    //Realizamos un contador para sumar los valores de n
                    for(int i=-1;i>=n;i--){
                        sumados-=i;
                    }
                }//Fin del IF n<0
            return sumados;
        }//Fin sum2NWithNegatives
    }
}
