/**
    Write a program that given the length of the 3 sides
    of a triangle, it calculates the area.
    Remember that side lenghts of zero and negatives are not valid.
    In the case of an error or bad parameter values
    -1 should be returned.
    Method signature:     triangleArea(double a, double b, double c)
    Return value:         double
    Access modifier:      public static
 */

using System;
namespace Ex3
{
    public class Program
    {
        public static bool ENABLED = true;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static double triangleArea(double a, double b, double c) {
            double operation3=0;
            if(a!=0 && a>0){
                if(b!=0 && b>0){
                    if(c!=0 && c>0){
                        operation3=(a+b+c)/2;
                    }
                    else{
                        operation3=-1;
                    }
                }
                else{
                    operation3=-1;
                }
            }
            else{
                operation3=-1;
            }
            return operation3;
        }
    }
}
