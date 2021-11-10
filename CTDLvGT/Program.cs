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
            int[] a = new int[] { 2, 4, 5, 3, 1, 8, 9, 6, 7 };
            MergeSort.Start(a);
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
            // TreeNode node1 = new TreeNode(1);
            // TreeNode node3 = new TreeNode(3);
            // TreeNode node5 = new TreeNode(5);
            // TreeNode node7 = new TreeNode(7);
            // TreeNode node2 = new TreeNode(2, node1, node3);
            // TreeNode node6 = new TreeNode(6, node5, node7);
            // TreeNode node4 = new TreeNode(4, node2, node6);
            // TreeNode.Empty(node6);
            // TreeNode.inOrder(node4);
            // Console.WriteLine(node2.isChildR(node3));
            // Console.WriteLine(TreeNode.depthNode(node2));
            // Console.WriteLine(TreeNode.Count(node4));
        }

    }
}
