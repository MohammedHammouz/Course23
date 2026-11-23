using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine("Original array:");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            InsertionSort(arr);

            Console.WriteLine("\nSorted array:");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
        
        static void InsertionSort(int[] arr)
        {
            int key = 0;
            for(int i = 1; i < arr.Length; i++)
            {
                key = arr[i];
                int j = i - 1;
                while(j>=0 && key < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }
    }
}
