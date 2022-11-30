using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace InputfromUser
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double C= Convert.ToDouble(Console.ReadLine());
            double a= Convert.ToDouble(Console.ReadLine());
            int r = Convert.ToInt32(C)+ Convert.ToInt32(a);
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }
}

