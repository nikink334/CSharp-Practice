using System;
using System.Collections.Generic;
using System.Text;

namespace functionalProgramming2
{
    internal class rectangle
    {
        int l, b, area, perimeter;

        internal void acceptRect()
        {
            Console.WriteLine("Enter Length: ");
            l = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Breadth: ");
            b = Convert.ToInt32(Console.ReadLine());

        }

        internal void areaRect()
        {
            area = l * b;
            Console.WriteLine(area);
        }

        internal void perimeterReact()
        {
            perimeter = 2 * (l + b);
            Console.WriteLine(perimeter);
        }
    }
}
