using System;
using System.Collections.Generic;
using System.Text;

namespace functionalProgramming2
{
    internal class simpleIntrest
    {
        float p, r, t, si;

        internal void AcceptSI()
        {
            Console.Write("Enter Principal Amount: ");
            p = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter Rate of Interest: ");
            r = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter Time (in years): ");
            t = Convert.ToSingle(Console.ReadLine());
        }

        internal void Calculate()
        {
            si = (p * r * t) / 100;
            Console.WriteLine("Simple Interest = " + si);
        }
    }
}
