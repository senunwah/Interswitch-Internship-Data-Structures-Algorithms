using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_with_LinkedLists
{
    class Node
    {
        public Node next, prev;
        public int data;
    }
    class StackL
    {
        Node head;
        Node tail;
        static void Main(string[] args)
        {
            StackL sl = new StackL();
            for (int i = 0; i < 50; i++)
            {
                sl.Add(i);
            }

            for (int i = 0; i < 10; i++)
            {
                sl.Delete();
            }

            sl.Print();

            Console.Read();

        }

        public void Add(int d)
        {
            Node tmp = new Node { data = d };
            tmp.next = head;
            if (head != null)
                head.prev = tmp;
            
                head = tmp;

            if (head.next == null)
                tail = head;          
        }

        public void Delete()
        {
            Node current = head;
            current = current.next;
            head = current;
        }

        public void Print()
        {
            Node tmp = tail;
            while(tmp != null & tmp != head.prev)
            {
                Console.WriteLine(tmp.data);
                tmp = tmp.prev;
            }
        }
    }
}
