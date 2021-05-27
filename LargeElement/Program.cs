using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LargeElement
{
    class Program
    {
        static void Main()
        {
            int i = 0;
            int large = 0;

            int[] arr = new int[] { 3, 8, 22, 10, 77, 5 };

           Console.WriteLine("Enter array elements : ");
           for (i = 0; i < arr.Length; i++)
            {
              //Console.Write("Element[" + (i + 1) + "]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            large = arr[0];
            //loop to compare value of large with other elements
            for (i = 1; i < arr.Length; i++)
            {
                //if large is smaller than other element
                //assig that element to the large
                if (large < arr[i])
                    large = arr[i];
            }
            Console.WriteLine("Largest element in array : " + large);
            Console.Read();
        }
    }
}
