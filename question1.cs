using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class question1
    {
        static int len;
        static void DiaplayArray(int[] arr)
        {
            Console.Write("Forward Array: ");
            for (int i = 0; i < len; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Backward Array: ");
            for (int i = len - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            Console.WriteLine("Enter the No.of Elements");
            try
            {
                len = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Elements");
                for (int i = 0; i < len; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }

                DiaplayArray(arr);
            }
            catch
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
