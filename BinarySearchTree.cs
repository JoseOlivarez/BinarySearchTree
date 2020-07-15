using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BinarySearchTree
{
    class TreeNode
    {
        public TreeNode left, right;

        public int item;
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            else
            {
                int left_Depth = MaxDepth(root.left);
                int right_Depth = MaxDepth(root.right);
                if (left_Depth > right_Depth)
                {
                    return (left_Depth + 1);
                }
                else return (right_Depth + 1);
            }
        }
    

    public void Preorder(TreeNode root)
        {
            if (root != null)
            {
                Console.WriteLine(root.item + " ");
                Preorder(root.left);
                Preorder(root.right); 
            }

        }
        public void printLevelOrder(TreeNode root)
        {

        }

      

        public void printPostOrder(TreeNode root)
        {
            if (root != null)
            {
                printPostOrder(root.left);
                printPostOrder(root.right);
                Console.WriteLine(root.item + " ");
            }

        }
        public void Inorder(TreeNode root)
        {
            {
                if (root != null)
                {
                    Inorder(root.left);

                    Console.WriteLine(root.item + " ");
                    Inorder(root.right);
                }
            }
        }
    }
  
    class Tree
    {
     
        public TreeNode Insert(TreeNode t_root, int t)
        {
            if (t_root == null)
            {
                t_root = new TreeNode();
                t_root.item = t;
            }
            else if (t < t_root.item)
            {
                t_root.left = Insert(t_root.left, t);
            }
            else
            {
                t_root.right = Insert(t_root.right, t);
            }

            return t_root;
        }



        public void Traverse(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            Traverse(root.left);
            Traverse(root.right);
        }

    }

}