using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Binary_Tree
{
    class Node
    {
        public Node left;
        public Node right;
        public int data;

        public void Insert(int x)
        {
            if (x < data)
            {
                if (left == null)
                    left = new Node { data = x };
                else
                    left.Insert(x);
            }
            else
            {
                if (right == null)
                    right = new Node { data = x };
                else
                    right.Insert(x);
            }
        }

    }

    class SimpleBinaryTree
    {

        Node root;
        static void Main(string[] args)
        {
            SimpleBinaryTree s = new SimpleBinaryTree();
            s.Add(4);
            s.Add(3);
            s.Add(10);
            s.Add(9);
            s.Add(17);
            Console.WriteLine("Pre-Order Traversal");
            s.PreOrder();
            Console.WriteLine("InOrder Traversal");
            s.InOrder();
            Console.WriteLine("PostOrder Traversal");
            s.PostOrder();

            Console.Read();
                     
        }

        public void Add(int x)
        {

            if (root == null)
                root = new Node { data = x };
            else        
                root.Insert(x);
        }

        public void _inOrder(Node y)
        {
            if(y != null)
            {
                _inOrder(y.left);
                Console.WriteLine(y.data);
                _inOrder(y.right);
            }
        }

        public void InOrder()
        {
            _inOrder(root);
        }

        public void _PreOrder(Node y)
        {     
            if (y != null)
            {
                Console.WriteLine("{0}", y.data);
                _PreOrder(y.left);
                _PreOrder(y.right);
            }
        }
        public void PreOrder()
        {
            _PreOrder(root);
        }

        public void _postOrder(Node y)
        {
            if(y != null)
            {            
                _postOrder(y.left);
                _postOrder(y.right);
                Console.WriteLine(y.data);
            }
        }

        public void PostOrder()
        {
            _postOrder(root);
        }
        



    }
}
