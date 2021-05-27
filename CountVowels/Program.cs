using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountVowels
{
    class Program
    {
        static void Main(string[] args)
        {
         var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

         Console.Write("Please enter your string here: ");
         string strPhrase = Console.ReadLine().ToLower();

         int total = strPhrase.Count(c => vowels.Contains(c));
         Console.WriteLine("Your total number of vowels is: {0}", total);

         Console.Read();
         }
     }
 }