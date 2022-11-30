using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1
{
    internal class Program
    {
        double myValue;
        public void setvalue(double p)
        {
            myValue= p;
        }
        double square()
        {
            return myValue*myValue;
        }
        double qube()
        {
            return myValue * myValue * myValue;
        }
        static void Main(string[] args)
        {
            Program obj= new Program();
            obj.myValue = 5;
           double pp= obj.square();
            double ppp=obj.qube();
            Console.WriteLine(pp);
            Console.WriteLine(ppp);
            Console.ReadLine();
        }
    }
}
