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
                sl.Delete(i);
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

        public bool Delete(int n)
        {
            Node current = head;
            Node previous = head;
            
            while (current != null)
            {
                if (current.data == n)
                {
                    previous.next = current.next;
                    return true;
                }
                else
                {
                    previous = current;
                    current = current.next;
                }
            }
            return false;
        }

        public void Print()
        {
            Node tmp = head;
            while(tmp != null)
            {
                Console.WriteLine(tmp.data);
                tmp = tmp.next;
            }
        }
    }
}
