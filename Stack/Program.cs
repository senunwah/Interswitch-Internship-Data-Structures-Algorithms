using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack
    {
        //using an arraylist
        private int[] array;


        public static void Main(string[] args)
        {
            Stack s = new Stack();
            for (int i = 0; i < 100; i++)
            {
                s.AddValue(i);
            }

            s.PrintArray();

            Console.Read();

        }
        private void AddValue(int n)
        {   

        }

        private void AdjustArray()
        {
           
        }

        private void PrintArray()
        {
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }

    }
}
