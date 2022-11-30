using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[]n=new int[5];
            for(i = 0; i < 5; i++)
            {
                n[i] = i + 100;
            }
            for(j = 0; j < 5; j++)
            {
                Console.WriteLine("array index[{0}]={1}",j,n[j]);
         
           }
            Console.ReadLine();
        }
    }
}
