﻿using System;
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
            //stackAndQueue stack = new stackAndQueue();
            Queue qu = new Queue();
            qu.Enqueue(56);
            qu.Enqueue(30);
            qu.Enqueue(70);
            Console.WriteLine();
            qu.Dequeue();
            qu.Display();
            qu.Dequeue();
            qu.Display();
            qu.Dequeue();
            qu.Display();
            Console.ReadLine();
        }
    }
}
