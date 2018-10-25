using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class Node
    {
        public Node next;
        public string data;
    }
    class LinkedLists
    {
        private Node head;

        public static void Main (string[] args)
        {
            LinkedLists l = new LinkedLists();
            l.Add("Stephen");
            l.Add("John");
            l.Add("Victor");

            l.Print();
            if (l.Search("John"))
                Console.WriteLine("Value Found");
            else
                Console.WriteLine("Value Not Found");

            if (l.Delete("John"))
                Console.WriteLine("Value has been deleted");
            else
                Console.WriteLine("Deletion not successful");

            l.Print();

            Console.Read();
        }
        
        public void Add(string d)
        {
            Node tmp = new Node { data = d };
            tmp.next = head;
            head = tmp;
        }

        public void Print()
        {
            Node tmp = head;
            while (tmp != null)
            {
                Console.WriteLine(tmp.data);
                tmp = tmp.next;
            }
        }

        public bool Search(string value)
        {
            Node tmp = head;
            while (tmp != null)
            {
                if (tmp.data == value)
                {
                    head = tmp.next;
                    return true;
                }
                tmp = tmp.next;
            }
            return false;
        }

        public bool Delete(string value)
        {
            Node tmp = head;
            Node prev = head;
            while(tmp != null)
            {
                if (tmp.data == value)
                {
                    prev.next = tmp.next;
                    return true;
                }
                else
                {
                    prev = tmp.next;
                    tmp = tmp.next;
                }
            }
            return false;
        }
    }
}