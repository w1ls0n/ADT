using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADT
{
    class Stack
    {
        private int size;
        private int[] items;
        private int head;

        //constructor
        public Stack(int size)
        {
            this.size = size;
            this.items = new int[size];
            this.head = head;
        }

        public void push(int newVal)
        {
            if (head == size)
            {
                Console.WriteLine("FULL");
            }
            else
            {
                items[head++] = newVal;
            }
        }

        public int pop()
        {
            if (head == 0)
            {
                Console.WriteLine("EMPTY");
                return -1;
            }
            else
            {
                return items[--head];
            }
           
        }

        public override String ToString()
        {
            StringBuilder details = new StringBuilder();
            details.Append("STACK CONTAINS: ");
            foreach (int item in items)
            {
                details.Append(item.ToString());
            }
            return details.ToString();
        }
    }
}
