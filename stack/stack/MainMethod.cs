using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    internal class MainMethod
    {
        public static void Main()
        {
            CustomStack stack = new CustomStack();
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            stack.Push(8);
            stack.Push(9);
            int x=stack.Peek();
            Console.WriteLine($"{x} is top element");
            stack.Pop();
            Console.WriteLine("enter number to be pushed in stack");
            int n =Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            //for(int i=0;i<n;i++)
            //{
              //  int y = Convert.ToInt32(Console.ReadLine());
               // arr[i] = y; 
           // }
            stack.AddElement(arr);
            stack.Display();
            Console.WriteLine("queue");
            Queue queue = new Queue();
            queue.Push(5);  
        }
        
    }
}
