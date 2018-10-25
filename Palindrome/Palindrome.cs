using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Palindrome
    {
        private string value;
        static void Main(string[] args)
        {  
            Palindrome p = new Palindrome();
            p.value = "malayalam";
            if (p.CheckPalindrome(p.value))
                Console.WriteLine("{0} is a Palindrome", p.value);
            else
                Console.WriteLine("{0} is not a Palindrome", p.value);

            Console.Read();
        }

        public bool CheckPalindrome(string value)
        {
            char[] myArray = value.ToLower().ToArray<char>();
            int palcount = 0, end = myArray.Length - 1; 
            for(int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == myArray[end])
                {
                    palcount++;
                    end--;
                }   
            }

            if (palcount == myArray.Length)
                return true;
            else
                return false;

        }
    }
}
