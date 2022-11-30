using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    internal class Program
    {
        double radius;
       public void setradius(int r)
        {
            radius = r;
        }
        double circumference(double PI=3.1416)
        {
           return 2 * 3.1416 * radius;
        }
        double getArea(double PI)
        {
            return 3.1416 * radius*radius;
        }

        static void Main(string[] args)
        {
            Program obj=new Program();
            obj.setradius(10);
            double pp= obj.circumference(obj.radius);
            double po= obj.getArea(obj.radius);
            Console.WriteLine("AREA : {0}",po);
            Console.WriteLine("circumference:  {0}",pp);
            Console.ReadLine();

        }
    }
}
