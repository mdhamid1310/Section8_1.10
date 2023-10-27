using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackLibrary;

namespace Section8_1._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            // Push elements onto the stack
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("Stack elements:");
            while (!stack.IsEmpty())
            {
                int element = stack.Pop();
                Console.WriteLine(element);
            }
            Console.ReadLine();
        }
    }
}
