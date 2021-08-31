using System;
using System.Collections.Generic;

namespace GenericStackdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Stack<string> mystack = new Stack<string>();
            mystack.Push("Sunday");
            mystack.Push("Monday");
            mystack.Push("Tuesday");
            mystack.Push("Wednesday");
            mystack.Push("Thursday");
            mystack.Push("Friday");
            mystack.Push("Saturday");
            print(mystack);
            Console.WriteLine("\nTop Item is : {0}", mystack.Peek());
            Console.WriteLine("\nRemoved Top Item of Stack : " + mystack.Pop());
            Console.WriteLine("\nNow Stack's Items are : ");
            print(mystack);
        }
        public static void print(Stack<string> sp)
        {
            foreach (string s in sp)
            {
                Console.Write(s.ToString() + " ");
            }
        }
    }
}
        