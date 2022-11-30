using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program
    {
        protected double length;
        protected double width;
        protected double GetArea()
        { 
            return length * width; 
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
static void Main(string[] args)
        {
            {
                Program r = new Program();
                Console.Write("Enter Length: ");
                double len = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Width: ");
                double wid = Convert.ToDouble(Console.ReadLine());
                r.length = len;
                r.width = wid;
                r.Display();
                Console.ReadLine();
            }
        }
    }
}
