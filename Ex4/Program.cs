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

            if(a>b && a>c){
                return a;
            }
                if(b>a && b>c){
                return b;
            }
            return c;
            }
            return 0;
        }
    }
