using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    internal class CustomStack
    {
        private int[] s;
        private int tracker;
        private int[] newStack;
        
        public CustomStack()
        {
            s = new int[5] { 0, 0, 0, 0, 0 };
            tracker = -1;
        }

        public void Push(int val)
        {
            tracker = tracker + 1;
            s[tracker] = val;
            Console.WriteLine($"{val} is pushed in stack");
        }

        public void Pop()
        {
            tracker = tracker - 1;
            Console.WriteLine($"{s[tracker]} is popped from stack");
        }
        public int Peek()
        {
             int x= s[tracker];
             return x;   
        }

        public bool isEmpty()
        {
            if(tracker == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddElement(int[] arr )
        {
            int n = arr.Length;
            int finalTracker = tracker+1+n;
            newStack = new int[finalTracker];
            int j = 0;
            for(int i=0;i<finalTracker; i++)
            {
                if(i<=tracker)
                {
                    newStack[i] = s[i];
                }
                else
                {
                    newStack[i] = arr[j];
                    j++;
                }
            }
            tracker = finalTracker-1;

        }
        public void Display()
        {
            for(int i=0; i<tracker; i++)
            {
                Console.WriteLine(s[i]);
            }
        }

    }
}
