using System;

namespace RemoveMiddleChar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a string:");
            string strString = Console.ReadLine();

            Console.Write("Please enter a character to remove:");
            string strChar = Console.ReadLine();

            string strNewString = strString.Replace(strChar, "");
            Console.WriteLine("After: {0}", strNewString);

            Console.WriteLine();
            Console.Read();
        }
    }
}
