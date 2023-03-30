using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();// hello
            string reverse = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverse += str[i];
            }
            Console.WriteLine(reverse);
            if (str == reverse)
            {
                Console.WriteLine("number is palindrome");
            }
            else
            {
                Console.WriteLine("number is not palindrome");
            }

        }
    }
}
