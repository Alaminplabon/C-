using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixAddition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7,8,9} };
            int[,] b = new int[3, 3] { { 11, 22, 33 }, { 44, 55, 66 }, { 77, 88, 99 } };
            int[,] c = new int[3, 3];

            int x=a.GetUpperBound(0);
            int y=b.GetUpperBound(1);
            for(int i=0; i<=x; i++)
            {
                for( int j=0; j<=y; j++)
                {
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("new matrix ");
            for (int i = 0; i <= x; i++)
            {
                for (int j = 0; j <= y; j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine("\n");
            }
            for (int i = 0; i <= x; i++)
            {
                for (int j = 0; j <= y; j++)
                {
                    c[i,j] = a[i,j]+ b[i,j];
                }
            }
            Console.WriteLine("Addition");
            for (int i = 0; i <= x; i++)
            {
                for (int j = 0; j <= y; j++)
                {
                    Console.Write(c[i, j] + " ");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();

        }
    }
}
