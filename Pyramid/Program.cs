using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            //outer rows - total will be 5
            //columns total will be 9
            Console.WriteLine();
            int rows = 0;
            int spaces = 0;
            int stars = 1;
            for (rows = 0; rows <= 5; rows++)
            {
                for (spaces = 5; spaces > rows; spaces--)
                {
                    Console.Write(" ");
                }
                for (stars = 1; stars < (spaces + rows); stars++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}