/**
    Write a program that returns the first n prime
    numbers as comma separated values in a string.

    A prime number is a positive integer that has exactly
    two positive integer factors, 1 and itself. 

    Another way of saying this is that a prime number is a
    positive integer that is not the product of two smaller positive integers.
    For example:
    Given: n = 3
    Return: "2,3,5"

    Given: n = 0 (or any negative)
    Return: ""

    Given: n = 10
    Return: "2,3,5,7,11,13,17,19,23,29"

    Method signature:     findFirstPrimeNumbers(int n)
    Return value:         string
    Access modifier:      public static
 */

using System;

namespace Ex10
{
    public class Program
    {
        public static bool ENABLED = true;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }

        public static string findFirstPrimeNumbers(int n) {
            string prime_numbers="";
            string[] prime_list;
            int residuo=0;
            int cont_sub=0;
            int index_primels=0;
            //Verificamos que no pongan el valor de 0 en n
            if(n!=0){
                 //Generando el doble for anidado lol
                for(int i=1;i<=n;i++){
                    //Como si generaramos las tablas vamos a calcular numeros primos
                    for(int j=1;j<=i;j++){
                        residuo=i%j;
                         //Revisando residuo 0 para revisar submultiplo
                        if(residuo==0){
                            cont_sub+=1;
                        }
                    }//Fin del for que maneja j
                    //Comprobamos que solo sean dos submultiplos
                    if(cont_sub==2){
                        //Agregamos los valores que sean primos en su respectivo index
                        prime_list= new string[] {i.ToString()+","};
                        //index_primels++;
                    }
                    //Reiniciamos el valor de cont_sub para corroborar el otro numero
                    cont_sub=0;
                }//Fin del for que maneja i
                //Ahora borramos la ultima ,
                //index_primels--;//Ocupamos el valor anterior para borrar le la coma
                //[index_primels] prime_list.Replace(",","");//Reemplazamos la , por el espacio vacio
                //Ahora lo imprimimos
                foreach (var item in prime_list)
                {
                    return prime_list[item];
                }        
            }//Fin del IF
            else{
                //Cuando vale 0 no se modifica el string
            }
            return prime_numbers;
        }
    }
}
