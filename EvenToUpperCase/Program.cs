using System;
using System.Linq;

namespace EvenToUpperCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a word or a short phrase: ");
            string strPhrase = Console.ReadLine();

            int nLength = strPhrase.Length;
            string newPhrase = "";
            char[] nameChar = strPhrase.ToArray();

            for (int i = 0; i < nameChar.Count(); i++)
            {
                if ((i % 2) == 0)
                {
                    newPhrase += nameChar[i].ToString().ToLower();
                }
                else
                {
                    newPhrase += nameChar[i].ToString().ToUpper();
                }
            }
            Console.WriteLine("Your input is: " + strPhrase + ". Your output is: " + newPhrase);

            Console.ReadLine();
        }
    }
}