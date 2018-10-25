using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_with_LinkedList
{

    class Node
    {
        public Node next = new Node();
        public int data;
    }

    class QueuewithLinkedList
    {
        Node head;
        Node tail;
        static void Main(string[] args)
        {
            QueuewithLinkedList q = new QueuewithLinkedList();
            q.Add(1);
            q.Add(2);
            q.Add(3);
            q.Print();
            //q.Remove();
            Console.WriteLine("----------------");
            q.Print();
            Console.ReadLine();
        }

        public void Add(int data)
        {
            Node tmp = new Node
            {
                data = data
            };

            if (head == null)
                head = tmp;
            else if (head != null)
            {
                tail.next = tmp;
                tail = tmp;
            }
                
        }

        public int Remove()
        {
            Node tmp = head;
            if (tmp != null)
            {
                head = head.next;
                return tmp.data;
            }
            else
                return 0;
        }

        public void Print()
        {
            Node tmp = head;
            while (tmp != null)
            {
                Console.WriteLine("{0}", tmp.data);
                tmp = tmp.next;
            }
        }
    }
}
