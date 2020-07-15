using BinarySearchTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace BFS
{
    class c_BFS
    {
        public int bfs_traversal(TreeNode root)
        {
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                root = q.Dequeue();
                Console.WriteLine(root.item + " ");
                if (root.left != null)
                    q.Enqueue(root.left);
                if (root.right != null)
                    q.Enqueue(root.right);
                
                
            }
            return 1;
        }
    }
}
