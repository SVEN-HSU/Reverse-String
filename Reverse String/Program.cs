//https://leetcode.com/problems/reverse-string/
//accepted :)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(reverseString("12345"));
            Console.Read();
        }

        public static string reverseString(string s)
        {
            if (s == null)
            {
                return null;
            }

            if (s.Length == 0)
            {
                return "";
            }

            return new string(s.Reverse().ToArray());
        }
    }
}
