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
        public static bool ENABLED = false;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static int sum2NWithNegatives(int n) 
        {
            int sum=0;
            if(n>0)
            {
                for(int i=1;i<=n;i++)
                {
                    sum=sum+i;
                }
            }
            else
            {
                if(n<0)
                {
                    for(int j=-1;j<=n;j--)
                    {
                       sum= sum+j;
                    }
                }
                if(n==0)
                {
                    sum=0;
                }
            }
            return sum;
        }
        }
    }

