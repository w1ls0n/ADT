using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADT
{
    class CircularQ
    {
        private int size;
        private int[] queue;
        private int head;
        private int tail;
        private int countDracula;

        //constructor
        public CircularQ(int size)
        {
            size = size; // here
            queue = new int[size];
            head = 0;
            tail = 0;
        }

        public void add(int item)
        {
            Console.WriteLine("HEAD: {0} TAIL:{1} COUNT: {2}",head,tail,countDracula);
            if (countDracula == size)
            {
                Console.WriteLine("FULL");
            }
            else
            {
                queue[tail] = item;
                tail++;
                countDracula++;
                if (tail == size)
                {
                    tail = 0;
                }
            }
        }

        public int remove()
        {
            if (countDracula == 0)
            {
                Console.WriteLine("EMPTY");
                return -1;
            }
            else
            {
                int temp = queue[head];
                head++;
                countDracula--;
                if (head == size)
                {
                    head = 0;
                }
                return temp;
            }
        }

        public override string ToString()
        {
            StringBuilder details = new StringBuilder();
            details.Append("QUEUEUE CONTAINS: ");
            foreach (int item in queue)
            {
                details.Append(item.ToString());
            }
            return details.ToString();
        }
    }
}
