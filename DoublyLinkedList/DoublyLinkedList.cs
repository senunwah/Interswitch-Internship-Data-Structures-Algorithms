using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{

    class Node
    {
        public string data;
        public Node next;
        public Node prev;

        //public Node(string d)
        //{
        //    this.data = d;
        //}

        //public string addData { get { return data; } set { data = addData; } }
    }

    public class Linkedlist
    {
        private Node head;
        private Node tail;

        static void Main(string[] args)
        {
            Linkedlist ll = new Linkedlist();
            ll.Add("stephen");
            ll.Add("john");
            ll.Add("victor");

            ll.Print();

            Console.WriteLine("----------------");

            if (ll.Search("victor"))
                Console.WriteLine("True");
            else
                Console.WriteLine("false");

            Console.WriteLine("----------------");

            if (ll.Delete("victor"))
                Console.WriteLine("Record has been Deleted");
            else
                Console.WriteLine("Record has not been Deleted");

            Console.WriteLine("----------------");

            ll.Print();
            Console.Read();

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

        public void PrintReverse()
        {
            Node tmp = tail;
            while (tmp != null)
            {
                Console.WriteLine("{0}", tmp.data);
                tmp = tmp.prev;
            }


        }

        public void Add(string data)
        {
            Node tmp = new Node();
            tmp.data = data;
            tmp.next = head;
            head = tmp;

        }

        public void AddDoubly(string data)
        {
            
            Node temp = new Node();
            temp.data = data;
            temp.next = head;
            temp.prev = null;

            if (head != null)
            {
                head.prev = temp;
            }

            head = temp;

            if (head.next == null)
            {
                tail = head;
            }
        }

        public bool Delete(string val)
        {

            Node current = head;
            Node previous = head;

            while (current != null)
            {
                if (current.data == val)
                {
                    previous.next = current.next;
                    return true;
                }
                else
                {
                    previous = current.next;
                    current = current.next;
                }


            }

            return false;
        }

        public bool Search(string data)
        {
            Node current = head;
            while (current != null)
            {
                if (current.data == data)
                {
                    head = current.next;
                    return true;
                }

                current = current.next;
            }
            return false;
        }
    }
}
