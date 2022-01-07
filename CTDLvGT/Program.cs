using System;
using System.Collections;
using System.Collections.Generic;
using static Data_Structure.MyBinaryTree;
namespace CTDLvGT
{
    class Program
    {
        public static void Main()
        {

            // testAlgorithm();
            testDataStructure();



        }

        public static void testDataStructure()
        {
            BSTNode A = new BSTNode(6);
            A.insertNode(4);
            A.insertNode(2);
            A.insertNode(5);
            A.insertNode(7);
            A.insertNode(1);
            A.insertNode(8);
            A.searchNode(5).setData("Test");

            Console.WriteLine();
            A.inOrder();
            Console.WriteLine(A.searchNode(5).Data);





        }
        public static void testAlgorithm()
        {
            Random random = new Random();
            int[] arr = new int[100];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 10;
            }

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            //Algorithm.BinarySearch.Start(arr, 21);

            for (int i = 0; i < arr.Length; i++)
            {
                Algorithm.BinarySearch.Start(arr, i);

            }


        }


    }
}
