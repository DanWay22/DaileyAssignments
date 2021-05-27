using System;

namespace RemoveCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a string:");
            string strString = Console.ReadLine();
            
            int nLength = strString.Length.GetHashCode();
            int nMiddle = nLength / 2;
            
            string strNewString = strString.Remove(nMiddle, 1);
            Console.WriteLine("Your character has been removed: {0}", strNewString);

            Console.WriteLine();
            Console.Read();
        }
    }
}
