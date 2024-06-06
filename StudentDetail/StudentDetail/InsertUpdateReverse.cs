using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetail
{
    internal class InsertUpdateReverse
    {
         public static void main()
        {
            Console.WriteLine("Enter the size of array");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = Insert(size);
            Console.WriteLine("Enter the value whech need to be insert with corresponding index");
            int value = Convert.ToInt32(Console.ReadLine());
            int index = Convert.ToInt32(Console.ReadLine());
            Update(arr, value, index);
            Reverse(arr);

         }

        public static int[] Insert(int n)
        {
            int[] arr = new int[n];
            Console.WriteLine("Enter value to be inserted in array");
            for(int i=0;i<n;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());   
            }
            return arr;
        }
        public static void Update(int[] arr , int value , int index)
        {
            for (int i=0;i<arr.Length; i++)
            {
                if (i==index)
                {
                    arr[i] = value; break;
                }
            }
            Console.WriteLine("Updated array");
            foreach (int i in arr)
            {
                Console.Write(i);
            }
            Console.WriteLine("\n");
        }
        public static void Reverse(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
            Console.WriteLine("Reversed array");
            foreach (int i in arr)
            {
                Console.Write(i);
            }
        }
    }
}
