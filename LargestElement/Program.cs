using System;

namespace LargestElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int nMax = 0;
            int[] nArray = new int[6] { 3, 88, 22, 10, 77, 5 };

            for (i = 0; i < nArray.Length; i++)
            {
                nArray[i] = nArray[i];
            }

            nMax = nArray[0];
            for (i = 1; i < nArray.Length; i++)
            { 
                if (nMax < nArray[i])
                    nMax = nArray[i];
        }
             Console.WriteLine("The largest element in this array is: {0}", nMax);
             Console.Read();
        }
    }
  }
 
 