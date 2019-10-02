using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
   public  class TriangleSolver
    {
        public static string Analyze(int x, int y, int z)
        {
            if (x + y <= z || x + z <= y || y + z <= x)
            {
                return "It is not a valid triangle";
            }
            else
            {
                if (x == y && y == z)
                {
                    return "This is an equilateral triangle";
                }
                else if (x == y || x == z || y == z)
                {
                    return "This is an isosceles triangle";
                }
                else
                {
                    return "This is a scalene triangle";
                }
               // return "It is a valid";
            }
        }
    }
}
