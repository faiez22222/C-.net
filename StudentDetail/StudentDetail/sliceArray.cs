using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetail
{
    internal class sliceArray
    {
            public static void main()
            {
               int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
               Console.WriteLine("Enter first and last index between 1 and 10 ");
               int startIndex = Convert.ToInt32(Console.ReadLine());
               int lastIndex = Convert.ToInt32(Console.ReadLine());
               int[] sliceArray = GetArray(arr, startIndex, lastIndex);
                Console.WriteLine("Sliced array elements:");
                foreach (int num in sliceArray)
                {
                    Console.WriteLine(num);
                }


        }
            public static int[] GetArray(int[] arr , int startIndex  , int lastIndex)
        {
            int[] sliceArray = new int[lastIndex-startIndex+1];
            int j = 0;
            for(int i=0; i < arr.Length; i++)
            {
                if(i>=startIndex-1 && i<=lastIndex-1)
                    {
                        sliceArray[j] = arr[i];
                        j++;
                    }
            }
            return sliceArray;
        }
    }
}
