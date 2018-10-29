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
        private int[] array= new int[10];
        private int count;

        public static void Main(string[] args)
        {
            Stack s = new Stack();
            for (int i = 0; i < 100; i++)
                s.AddValue(i);

            for (int i = 0; i < 10; i++)
                s.DeleteFromArray();

            s.PrintArray();

            Console.Read();

        }
        private void AddValue(int n)
        {   
            if (count < array.Length)
            {
                array[count] = n;
                count++;
            }
            else if (count == array.Length)
            {
                AdjustArray();
                array[count] = n;
                count++;
            }
        }

        private void AdjustArray()
        {
            int[] temparray = new int[array.Length];
            for (int i = 0; i < array.Length; i++) 
                temparray[i] = array[i];

            array = new int[temparray.Length + temparray.Length];
            for (int i = 0; i < temparray.Length; i++)
                array[i] = temparray[i];
            
        }

        private void DeleteFromArray()
        {
            int[] temparray = new int[array.Length - 1];
            for (int i = 0; i < array.Length - 1; i++)
                temparray[i] = array[i];

            array = new int[temparray.Length];
            for (int i = 0; i < array.Length; i++)
                array[i] = temparray[i];

            count--;
        }

        private void PrintArray()
        {
            for (int i = 0; i < count; i++)
            {              
                Console.WriteLine(array[i]);          
            }
        }

    }
}
