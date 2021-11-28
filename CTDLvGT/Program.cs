using System;
using System.Collections;
using System.Collections.Generic;
using static Data_Structure.MyBinaryTree;
using static Algorithm.Sort;
namespace CTDLvGT
{
    class Program
    {
        public static void Main()
        {
            testAlgorithm();
            //testDataStructure();



        }
        public static void testDataStructure()
        {
            int[] a = new int[] { 3, 5, 2, 4, 6, 23, 5, 7, 5 };
            TreeNode root = new TreeNode();
            root = TreeNode.toCompleTree(a, root, 0);
            TreeNode.Traversal(root, Order.preOrder);



        }
        public static void testAlgorithm()
        {
            Random random = new Random();
            int[] arr = new int[10];
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                arr[i] = random.Next(1, 10);
            }

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            HeapSort.Start(arr);
            Console.WriteLine();
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

        }


    }
}
