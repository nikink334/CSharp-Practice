using System;
using System.Collections.Generic;
using System.Text;

namespace functionalProgramming2
{
    internal class airthmeticOperation
    {
        int a, b, c;

        internal void accept()
        {
            Console.WriteLine("Enter First Number : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number : ");
            b = Convert.ToInt32(Console.ReadLine());

        }

        internal void add()
        {
            c = a + b;
            Console.WriteLine(c);
        }

        internal void sub()
        {
            c = a - b;
            Console.WriteLine(c);
        }

        internal void multi()
        {
            c = a * b;
            Console.WriteLine(c);
        }

        internal void div()
        {
            c = a / b;
            Console.WriteLine(c);
        }

    }
}
