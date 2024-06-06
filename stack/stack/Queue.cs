using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    internal class Queue
    {
        private int[] queue ;
        int tracker;
        int index;
        public Queue()
        {
            queue = new int[5];
            tracker = 0;
            index = 0;
        }
        public void Push(int val)
        {
            queue[index] = val;
            index++;
            Console.WriteLine($"{val} is pushed in queue");
        }

        public void Pop()
        {
            Console.WriteLine($"{queue[tracker]} is popped from queue");
            tracker++; 
        }
        public int Peek()
        {
            int x = queue[tracker];
            return x;
        }

        public bool isEmpty()
        {
            if (tracker ==index)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
