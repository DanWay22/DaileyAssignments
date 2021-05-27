using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string strRev;
            
            Console.Write("Please enter a world to determine if it is a palindrome: ");
            string strInput = Console.ReadLine();

            char[] ch = strInput.ToCharArray();
            Array.Reverse(ch);
            strRev = new string(ch);

            bool b = strInput.Equals(strRev, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                Console.WriteLine("" + strInput + " is a Palindrome!");
            }
            else
            {
                Console.WriteLine(" " + strInput + " is not a Palindrome!");
            }
            Console.Read();
        }
    }
}
