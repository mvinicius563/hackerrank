using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_cs._30DaysOfCode
{
    class BSTTraversal
    {
        class Node
        {
            public Node left, right;
            public int data;
            public Node(int data)
            {
                this.data = data;
                left = right = null;
            }
        }

        static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }

        public BSTTraversal()
        {

            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            Console.WriteLine("\nLevel order:");
            levelOrder(root);
            Console.WriteLine("\nIn order:");
            inOrder(root);
            Console.WriteLine("\nPre order:");
            preOrder(root);
            Console.WriteLine("\nPost order:");
            postOrder(root);
        }

        #region Traversal algorithms
        static void levelOrder(Node root)
        {
            Queue<Node> q = new Queue<Node>();
            if (root != null)
            {
                q.Enqueue(root);
                while (q.Any())
                {
                    var x = q.Dequeue();
                    Console.Write(x.data + " ");
                    if (x.left != null) { q.Enqueue(x.left); }
                    if (x.right != null) { q.Enqueue(x.right); }
                }
            }           
        }

        static void inOrder(Node root)
        {
            if (root == null) return;
            inOrder(root.left);
            Console.Write(root.data + " ");
            inOrder(root.right);
        }

        static void postOrder(Node root)
        {
            if (root == null) return;
            postOrder(root.left);
            postOrder(root.right);
            Console.Write(root.data + " ");
        }

        static void preOrder(Node root)
        {
            if (root == null) return;
            Console.Write(root.data + " ");
            preOrder(root.left);
            preOrder(root.right);            
        }
        #endregion

    }
}
