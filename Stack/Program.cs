using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Node{

        public int data;
        public Node next;

    }

    class Stack
    {
        int Top ;
        int[] ArrayList = new int[1000];

        Node head;

        //Using a Node


        //static void Main(string[] args)
        //{
           
        //    Stack stk = new Stack();
            
        //    stk.push(3);
        //    stk.push(6);
        //    stk.push(9);
        //    stk.push(7);
        //    //Print Items in the stack
        //    stk.print();
        //    Console.WriteLine("-----------");
        //    if (stk.pop(7) >= 0)
        //        Console.WriteLine("You have Successfully Removed an Item");
        //    else
        //        Console.WriteLine("There are no items in the stack");

        //    //Print Items in the stack           
        //    Console.WriteLine("-----------");
        //    stk.print();
        //    Console.Read();


        //}

        static void Main(string[] args)
        {

            Stack stk = new Stack();

            stk.NodePush(3);
            stk.NodePush(6);
            stk.NodePush(9);
            stk.NodePush(7);
            //Print Items in the stack
            stk.nodePrint();
            Console.WriteLine("-----------");
            if (stk.NodePop() >= 0)
                Console.WriteLine("You have Successfully Removed an Item");
            else
                Console.WriteLine("There are no items in the stack");

            //Print Items in the stack           
            Console.WriteLine("-----------");
            stk.nodePrint();
            Console.Read();


        }

        public void print()
        {
            for (int i = 0; i < Top; i++)
            {
                if (i <= Top)
                    Console.WriteLine(ArrayList[i]);       
            }           
        }

        public void nodePrint()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine("{0}", temp.data);
                temp = temp.next;
            }
        }

        public void push(int data)
        {
            if (Top < ArrayList.Length)
            {
                ArrayList[Top] = data;
                Top++;
            }              
            else
                Console.WriteLine("The Stack is full");          
        }

        public void NodePush(int data)
        {
            Node tmp = new Node();
            tmp.data = data;
            tmp.next = head;
            head = tmp;
            Top++;
        }

        public int pop()
        {
            if (Top >= 0)
            {
                Top--;
                return ArrayList[Top];
            }     
            else      
                return 0;
        }

        public int NodePop()
        {
            Node current = head;
            Node previous = current;
            head = head.next;
            return current.data;
        }
    }
}
