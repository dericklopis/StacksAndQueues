using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stacks and Queues Problem\n");
            stackAndQueue stack = new stackAndQueue();
            Queue qu = new Queue();
            qu.Enqueue(56);
            qu.Enqueue(30);
            qu.Enqueue(70);
            Console.WriteLine("\nThe Elements Are Present In The Queue");
            qu.Display();
            Console.ReadLine();
            //stack.Peek();
            //stack.Pop();
            //stack.Display();
            //stack.Peek();
            //stack.Pop();
            //stack.Display();
            //stack.Peek();
            //stack.Pop();
            //Console.WriteLine();
            //stack.Display();
        }
    }
}
