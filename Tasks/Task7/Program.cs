using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int j = 0; j <= 10; j++)
                {
                    for(int k = 0; k <= j; k++)
                    {
                        Console.Write('#');
                    }
                    Console.WriteLine();
                }

            Console.WriteLine();

            for (int j = 10; j >= 0; j--)
            {
                for (int k = 0; k <= j; k++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            for (int j = 0; j <= 10; j++)
            {
                for (int k = 0; k <= j; k++)
                {
                    Console.Write(' ');
                }
                for (int k = 10; k >= j; k--)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int j = 0; j <= 10; j++)
            {
                for (int k = 10; k >= j; k--)
                {
                    Console.Write(' ');
                }
                for (int k = 0; k <= j; k++)
                {
                    Console.Write('#');
                }

                Console.WriteLine();
            }


        }
    }
}
