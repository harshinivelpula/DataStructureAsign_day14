using DataStructureAsign;
using System;
using System.Collections.Generic;

namespace DataStructueAsign
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello LinkedList!");
            SimpleLinkedList list = new SimpleLinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            Console.ReadKey();
            
        }
    }
}