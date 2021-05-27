using System;
public class TestingApp
{
    public static void Main()
    {
        int[] nArray = { 3, 8, 22, 10, 77, 5 };
        //int[] arr = new int[5] { 99, 95, 93, 89, 87 };

        int i, nMax, nMin;
        //int nLength = Convert.ToInt32(Console.ReadLine());
        int nLength = nArray.Length.GetHashCode();
        //int i, max, min, n;

        nMax = nArray[0];
        nMin = nArray[0];

        for (i = 1; i < nLength; i++)
        {
            if (nArray[i] > nMax)
            {
                nMax = nArray[i];
            }
            if (nArray[i] < nMin)
            {
                nMin = nArray[i];
            }
        }
    }
    //Console.WriteLine("The largest element in this array is: {0}", nMin);
}
                  // Console.WriteLine("The length of my array is: " + nLength);

           // Console.WriteLine();
           // Console.Read();

 