/**
    Write a program that given two arrays of strings
    returns a new array with the elements of both
    concatenated.

    For example:
    Given: array1=["Hello","World"], array2=["Hola","Mundo","FIME"]
    Returns: ["Hello","World","Hola","Mundo","FIME"]

    Given: array1=[], array2=["Hola","FIME"]
    Returns: ["Hola","FIME"]

    Given: array1=["Hello","World"], array2=null
    Returns: ["Hello","World"]

    Given: array1=["Hello","World"], array2=null
    Returns: ["Hello","World"]

    Given: array1=[], array2=null
    Returns: []

    Method signature:     arrayConcatenation(string[] array1, string[] array2)
    Return value:         string[]
    Access modifier:      public static
 */

using System;

namespace Ex11
{
    public class Program
    {
        public static bool ENABLED = false;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }

        public static string[] arrayConcatenation(string[] array1, string[] array2) {
            return new string[0];
        }

    }
}
