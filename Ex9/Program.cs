/**
    Write a program that tells wheter a number is prime
    or not.

    A prime number is a positive integer that has exactly
    two positive integer factors, 1 and itself. 

    Another way of saying this is that a prime number is a
    positive integer that is not the product of two smaller positive integers.

    For example:
    Given: number = 2
    Returns: true

    Given: number = 15
    Returns: false

    Given: number = -1 (or any negative)
    Returns: false

    Method signature:     isPrime(int number)
    Return value:         bool
    Access modifier:      public static
 */

using System;

namespace Ex9
{
    public class Program
    {
        public static bool ENABLED = true;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }

        public static bool isPrime(int number) {
            bool state=false;
            int residuo=0;
            int cont_sub=0;
            if(number<=0){
                //No se modifica el estado de falso
            }
            //Cuando el number es valido
            else{
                //Operaciones
                for(int i=1;i<=number;i++){
                    residuo=number%i;
                    //Revisando residuo 0 para revisar submultiplo
                    if(residuo==0){
                        cont_sub+=1;
                    }
                }//Fin del for
                //Comprobamos que solo sean dos submultiplos
                if(cont_sub==2){
                    state=true;
                }
            }//Fin del else
            return state;
        }
    }
}
