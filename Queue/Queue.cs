using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Queue
    {
        int[] values = new int[20];
        int Top = 0;
        
        static void Main(string[] args)
        {
            Queue q = new Queue();
            //Add items to the queue for i no of times
            for (int i = 5; i < 99999; i++)
            {
                q.Enqueue(i);
            }
            q.Print();
            Console.WriteLine("-------------");
            //Remove items from the queue for i no of times
            for (int i = 0; i < 6; i++)
            {
                q.Dequeue();
            }
            Console.WriteLine("-------------");
            q.Print();            
            Console.Read();

        }

        public void Enqueue(int data)
        {
            if (Top < values.Length)
            {
                values[Top] = data;
                Top++;
            }
            else if (Top == values.Length )
            {
                Top--;
                for (int i = 0; i < Top; i++)
                {
                    values[i] = values[i + 1];
                    
                }
                values[Top] = data;
                Top++;
                
            }
            else
                Console.WriteLine("Queue is full");
        }

        public void Dequeue()
        {
            if (Top > 0)
            {
                for (int i = 0; i < Top - 1; i++)
                {          
                    values[i] = values[i + 1];                   
                }
                Console.WriteLine("Successfully removed at index[0] and rotated the rest of the queue to the top");
                Top--;
            }
            else
                Console.WriteLine("Queue is empty");          
        }

        public void Print()
        {
            for (int i = 0; i < Top; i++)
            {
                if (i <= Top)
                {
                    Console.WriteLine(values[i]);
                }
            }
        }
    }
}
