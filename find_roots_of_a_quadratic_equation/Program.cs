/*
 *  C# Program to Find Roots of a Quadratic Equation
 */

using System;

namespace find_roots_of_a_quadratic_equation
{
    class Quadraticroots
    {
        double a, b, c;

        public void read()
        {
            Console.WriteLine(" \n To find the roots of a quadratic equation of the form a*x*x + b*x + c = 0");
            Console.Write("\n Enter value for a : ");
            a = double.Parse(Console.ReadLine());
            Console.Write("\n Enter value for b : ");
            b = double.Parse(Console.ReadLine());
            Console.Write("\n Enter value for c : ");
            c = double.Parse(Console.ReadLine());
        }

        public void Compute()
        {
            int m;
            double r1, r2, d1;
            d1 = b * b - 4 * a * c;
            if (a == 0)
                m = 1;
            else if (d1 > 0)
                m = 2;
            else if (d1 == 0)
                m = 3;
            else
                m = 4;
        }
    }
}