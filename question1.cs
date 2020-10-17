using System;
namespace Array
{    class Program
    {
        static void DisplayArray(string arr)
        {
            Console.Write("Array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();
            Console.Write("Reverse Array: ");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Enter the String");
            str = Console.ReadLine();
            DisplayArray(str);
        }
    }
}
// i have not used exception handling as it was not needed
