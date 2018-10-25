using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_Node
{
    class LinkedList
    {
        public Node head;
        public int count;

        public LinkedList()
        {
            this.head = null;
            this.count = 0;
        }

        public void insertData(string data)
        {
            Node tmp = new Node();
            
        }
        

        static void Main(string[] args)
        {
            
        }
    }

    class Node {
        public string data;
        public Node next;
        public Node(string d)
        {
            data = d;
            next = null;
        }
    }
}
