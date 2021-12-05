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

            //testAlgorithm();
            //testDataStructure();



        }

        public static void testDataStructure()
        {
            int[] a = new int[] { 3, 5, 2, 4, 6, 23, 5, 7, 5 };
            TreeNode A = new TreeNode("A");
            TreeNode B = new TreeNode("B");
            TreeNode C = new TreeNode("C");
            TreeNode D = new TreeNode("D");
            TreeNode E = new TreeNode("E");
            TreeNode F = new TreeNode("F");
            TreeNode G = new TreeNode("G");
            TreeNode H = new TreeNode("H");
            TreeNode I = new TreeNode("I");
            TreeNode J = new TreeNode("J");
            A.ChildL = B; A.ChildR = C;
            B.ChildL = D; B.ChildR = E;
            E.ChildL = H;
            C.ChildL = F; C.ChildR = G;
            F.ChildR = I;
            G.ChildR = J;
            TreeNode.Traversal(A, Order.preOrder);
            Console.WriteLine();
            TreeNode.Traversal(A, Order.inOrder);





        }
        public static void testAlgorithm()
        {
            Random random = new Random();
            int[] arr = new int[10];
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                arr[i] = random.Next(1, 100);
            }

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            RadixSort.Start(arr);
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

        }


    }
}
