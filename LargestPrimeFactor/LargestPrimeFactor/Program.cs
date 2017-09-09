using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            for (long i = 2; i < 10000; i++)
            {
                if (600851475143 % i == 0)
                {
                    Console.WriteLine(i);
                    Console.ReadKey();
                }

            }



            }
        }
    }


