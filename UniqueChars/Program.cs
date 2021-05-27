using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class UniqueCharacters
{
    public bool CheckUnique(string strInput)
    {
        string strOne = "";
        string strTwo = "";
        for (int i = 0; i < strInput.Length; i++)
        {
            strOne = strInput.Substring(i, 1);
            for (int j = 0; j < strInput.Length; j++)
            {
                strTwo = strInput.Substring(j, 1);
                if ((strOne == strTwo) && (i != j))
                    return false;
            }
        }
        return true;
    }
    static void Main(string[] args)
    {
        UniqueCharacters strChars = new UniqueCharacters();

        bool b = strChars.CheckUnique("abcdefghijklmnopqrstuvwxyz");
       // bool b = strChars.CheckUnique("The quick brown fox jumps over the lazy dog.");
        Console.WriteLine(b);
        Console.ReadKey();
    }
}