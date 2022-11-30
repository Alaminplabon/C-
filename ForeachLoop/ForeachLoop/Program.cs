using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number=new int[10];

            //for (int i=0; i<=number.Length; i++)
            //{
            //    number[i]=Convert.ToInt32(Console.ReadLine());
            //}
            number[0] = 10;
            number[1] = 100;
            number[2] = 12;
            number[5] = 55;
            foreach(int i in number)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

    }
}
