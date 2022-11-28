using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_HW36
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rand = new Random();

            void PrintArray(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }

            void FillArray(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rand.Next(-100, 100);
                }

            }

            void Sum(int[] arr)
            {
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {                    
                    if (i % 2 != 0)
                    {
                        sum += arr[i]; 
                    }
                }
                Console.WriteLine($"\nСумма элементов с нечетными индексами: {sum}");
            }

            FillArray(array);
            PrintArray(array);
            Sum(array);
        }
    }
}
