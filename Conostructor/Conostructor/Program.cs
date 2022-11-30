using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conostructor
{

    class Box
    {
        public int l;
        public int w;
        public int h;
        public Box()
        {
            l = 10; w = 10; h = 10;

        }
        public Box (int length,int wigth,int hight)
            {
            this.l = length;
            this.w = wigth;
            this.h = hight;
            }
        public int getArea()
        {
            return l * w * h;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Box ob = new Box();
            Console.WriteLine(ob.getArea());
            Console.WriteLine("\n");
            Box ob1= new Box(20,20,20);
            Console.WriteLine(ob1.getArea());
            Console.ReadLine();
        }
    }
}
