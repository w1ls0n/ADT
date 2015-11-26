using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ADT
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
            
            //Console.WriteLine(stack);

            //for (int i = 0; i < 10; i++)
            //{
            //    stack.push(5);
            //    Console.WriteLine(stack);
            //}
            
            
            //for (int i = 0; i < 10; i++)
            //{
            //    circularQ.add(6);
            //    Console.WriteLine(circularQ);
            //}
            //Console.ReadLine();
        }

        static void menu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("_________________________________________________________________");
            Thread.Sleep(150);
            Console.WriteLine("                             MENU                                ");
            Thread.Sleep(150);
            Console.WriteLine("_________________________________________________________________");
            Thread.Sleep(150);
            Console.WriteLine("                         (1) STACK");
            Thread.Sleep(150);
            Console.WriteLine("                         (2) QUEUEUE");
            Thread.Sleep(150);
            Console.WriteLine("                         (3) ADD");
            Thread.Sleep(150);
            Console.WriteLine("                         (4) REMOVE");
            Thread.Sleep(150);
            Console.WriteLine("                         (5) DISPLAY");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: new Stack(10); break;
                case 2: new CircularQ(10); break;
                case 3:
                case 4:
                case 5: Console.WriteLine("{0} {1}",stack, Queue);
                default:
                    break;
            }


        }
    }
}
