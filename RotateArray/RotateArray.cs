﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArray
{
    //Write a function rotate(ar[], d, n) that rotates arr[] of size n by d elements.

    class RotateArray
    {

        private void LeftRotate(int[] ar, int d, int n)
        {
            for (int i = 0; i < d; i++)
            {
                LeftRotatebyOne(ar, n);
            }
        }

        private void LeftRotatebyOne(int[] ar, int n)
        {
            int i, temp = ar[0];
            for (i = 0; i < n - 1; i++)
            {
                ar[i] = ar[i + 1];
            }
            ar[i] = temp;
        }

        private void PrintArray(int[] ar, int size)
        {
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine("{0}", ar[i]);
            }
        }

        static void Main(string[] args)
        {
            RotateArray ra = new RotateArray();

            int[] ar = {1,2,3,4,5,6,7 };
            ra.LeftRotate(ar, 2, 7);
            ra.PrintArray(ar, 7);

            Console.ReadLine();
        }
    }
}
