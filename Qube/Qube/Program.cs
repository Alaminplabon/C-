using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qube
{
    internal class Program
    {
        public static int qube(int num)
        {
            return num * num * num;
        }
        static void Main(string[] args)
        {
            int a= Convert.ToInt32(Console.ReadLine());
            int b;
            b=Program.qube(a);
            Console.WriteLine(b);
            Console.ReadLine();

        }
    }
}
