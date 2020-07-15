using BinarySearchTree;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using ConsoleApp5;
using BFS;
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] containerArray = new int[7];
            containerArray[0] = 8; containerArray[1] = 2; containerArray[2] = 21; containerArray[3] = 1;
            containerArray[4] = 5; containerArray[5] = 13; containerArray[6] = 3;

            
            TreeNode TreeNode_Instance = new TreeNode();
            Tree tree_instance = new Tree();
           for(int i = 0;  i < containerArray.Length; i++)
            {
                tree_instance.Insert(TreeNode_Instance, containerArray[i]);

            }


            Console.WriteLine("Enter a number between one and 5");
            int   userName = Convert.ToInt32(Console.ReadLine());
            TreeNode objectInstance = new TreeNode();
            c_BFS objectInstance_BFS = new c_BFS();
       //     objectInstance.printPostOrder(TreeNode_Instance);
         Console.WriteLine("print" + objectInstance_BFS.bfs_traversal(TreeNode_Instance));
        }
    }
}
