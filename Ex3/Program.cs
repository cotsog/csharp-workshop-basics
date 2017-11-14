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
            if(a!=0 & a<0){
                if(b!=0 & b<0){
                    if(c!=0 & c<0){
                        double acuadrada=Math.Pow(a,2);
                        double bcuadrada=Math.Pow(b,2);
                        double ccuadrada=Math.Pow(c,2);
                        double acuarta=Math.Pow(a,4);
                        double bcuarta=Math.Pow(b,4);
                        double ccuarta=Math.Pow(c,4);
                        double operation1=Math.Pow((acuadrada+bcuadrada+ccuadrada),2);
                        double operation2=2*(acuarta+bcuarta+ccuarta);
                        operation3=(1/4)*(Math.Sqrt((operation1-operation2)));
                    }
                    else{
                        operation3=0;
                    }
                }
                else{
                    operation3=0;
                }
            }
            else{
                operation3=0;
            }
            return operation3;
        }
    }
}
