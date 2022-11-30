using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int i, j, k;
                for (j = 2; j <= 25; j++)
                {
                    k = 0;
                    for (i = 2; i <= j / 2; i++)
                    {
                        if (j % i == 0)
                        {
                            k = 1;
                            break;
                        }
                    }
                    if (k == 0)
                        Console.WriteLine("{0} is prime", j);
                }
                Console.ReadLine();
            }
        }
        }
}
