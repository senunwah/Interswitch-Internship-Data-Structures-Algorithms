using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombineArrays
{
    class LockStep
    {
        
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 5,7,7,9,1,4,6,8,9 };
            int index = a.Length + b.Length;
            int[] combinedArray = new int[index];
            CombineArray(a, b, combinedArray);
            printArray(combinedArray);
            Console.Read();
        }

        public static void CombineArray (int[] a, int[] b, int[] combinedArray)
        {
            
            int IdxA = 0, IdxB = 0;
            for (int x = 0; x < combinedArray.Length;)
            {
                if (IdxA < a.Length)
                {
                    combinedArray[x] = a[IdxA];
                    x++; IdxA++;
                }

                if (IdxB < b.Length)
                {
                    combinedArray[x] = b[IdxB];
                    x++; IdxB++;
                }
            }

        }

        public static void printArray(int[] combinedArray)
        {
            for (int i = 0; i < combinedArray.Length; i++)
            {
                Console.Write(combinedArray[i]);
            }

           
            
        }
    }
}
