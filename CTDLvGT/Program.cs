using System;
using System.Collections;
using System.Collections.Generic;
using static Data_Structure.myBinaryTree;
using static Algorithm.Sort;
namespace CTDLvGT
{
    class Program
    {
        public static void Main()
        {
            Random random = new Random();
            int[] a = new int[10];
            for (int i = 0; i <= a.Length - 1; i++)
            {
                a[i] = random.Next(1, 100);
            }
            foreach (var item in a)
            {
                Console.Write(item + " ");
            }
            MergeSort.Start(a);
            Console.WriteLine();
            foreach (var item in a)
            {
                Console.Write(item + " ");
            }

        }

    }
}
