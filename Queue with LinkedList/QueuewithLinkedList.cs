using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_with_LinkedList
{

    class Node
    {
        public Node next,prev;
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

            q.Delete();

            Console.WriteLine("----------------");
            q.Print();
            Console.ReadLine();
        }

        public void Add(int d)
        {
            Node tmp = new Node{data = d};
            tmp.next = head;
            head = tmp;

            if (head.next != null)
                head.prev = tmp;

            if (head.next == null)
                tail = head;
      
        }

        public void Delete()
        {
            Node lastnode = tail;
            lastnode = lastnode.prev;
            tail = lastnode;        
        }

        public void Print()
        {
            Node tmp = tail;
            while (tmp != null)
            {
                Console.WriteLine(tmp.data);
                tmp = tmp.prev;
            }
        }
    }
}
