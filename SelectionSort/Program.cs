using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    internal class Program
    {
        static void SelectionSortAsc(int[] arr)
        {
            int MinIndex = 0;
            for(int i = 0; i < arr.Length - 1; i++)
            {
                MinIndex = i;
                for(int j = i+1; j < arr.Length; j++)
                {
                    if (arr[MinIndex] > arr[j])
                    {
                        MinIndex = j;
                    }
                }
                int temp = arr[MinIndex];
                arr[MinIndex] = arr[i];
                arr[i] = temp;
            }
        }
        static void SelectionSortDesc(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int MaxIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[MaxIndex] < arr[j])
                    {
                        MaxIndex = j;
                    }
                }
                int temp = arr[MaxIndex];
                arr[MaxIndex] = arr[i];
                arr[i] = temp;
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 0 };
            Console.WriteLine("Original array:");
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
            SelectionSortAsc(arr);
            Console.WriteLine("\nSorted array ASC:");
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
            SelectionSortDesc(arr);
            Console.WriteLine("\nSorted array DESC:");
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
        }
    }
}
