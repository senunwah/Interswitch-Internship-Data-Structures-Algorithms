using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombineArrays
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 1, 2, 3, 4, 5 };
            int index = a.Length + b.Length;
            int[] combinedArray = new int[index];
            CombineArray(a, b, combinedArray);
            printArray(combinedArray);
        }

        public static void CombineArray (int[] a, int[] b, int[] combinedArray)
        {
            int Length;
            if (a.Length > b.Length)
                Length = a.Length;
            else
                Length = b.Length;
            
            for (int i = 0; i <= Length; i++)
            {
                
                if(i <= a.Length)
                {
                    combinedArray[i] = a[i];
                }
                else { }

                
            }
            



        }

        public static void printArray(int[] combinedArray)
        {
            for (int i = 0; i < combinedArray.Length; i++)
            {
                Console.Write("{0} ", combinedArray[i]);
            }

            Console.Read();

            
        }
    }
}
