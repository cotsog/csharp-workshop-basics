/**
    Write a program that given a string it returns the same
    string but without any white space.
    For example: Given "Hello Joe Doe ".
    A null string value should return an empty string.
    It returns "HelloJoeDoe"
    Method signature:     SupressWhiteSpaces(string text)
    Return value:         string
    Access modifier:      public static
 */

using System;
namespace Ex5
{
    public class Program
    {
        public static bool ENABLED = true;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string SupressWhiteSpaces(string text) {          
            string Suprimir="";
            int i=0;
            int j=0;
            int borrar[15]=0;
            int mantener[15]=0;
             if(string.IsNullOrEmpty(text)){
                Suprimir="";
            }
            else{
                int lng=text.Lenght();
                for(i=0;i<lng;i++){
                    if(text[i]==" "){
                        borrar[i]=i;
                    }
                    else{
                        mantener[i]=i;
                    }
                }
            }

            for(j=0;j<lng;j++){
                if(mantener[j]!=0){
                    Suprimir+=mantener[j];
                }
            }
            return Suprimir;
        }
    }
}
