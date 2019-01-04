using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Shaded_Area
{
    class Program
    {
        int[] Ax = { 2, 4 };
        int[] Ay = { 2, 6 };
        int[] Bx = { 3, 5 };
        int[] By = { 3, 4 };


        static void Main(string[] args)
        {

            Program p = new Program();
            Console.WriteLine("The Area is {0}", p.FindArea());
            Console.Read();

        }

        public int FindArea()
        {
            int Length = Math.Max(Ax[0], Bx[0]) - Math.Min(Ax[1], Bx[1]);
            int Breadth = Math.Max(Ay[0], By[0]) - Math.Min(Ay[1], By[1]);
            int Area = Length * Breadth;
            return Area;
        }

    }
}
