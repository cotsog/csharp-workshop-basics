/**
    Write a program that given 3 numbers it returns the largest.
    Method signature:     largerNumber(int a, int b, int c)
    Return value:         int
    Access modifier:      public static
 */

using System;
namespace Ex4
{
    public class Program
    {
        public static bool ENABLED = true;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int largerNumber(int a, int b, int c) {
            int salida; 
            if(a>b&&a>c)
            {
                 salida = a;
            }
            else
            {
                if(b>a&&b>c)
                {
                 salida=b;
                 }
                 else
                 {
                     salida=c; 
                 }
            }
           return salida;
        }
    }
}
