using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesExample
{
    internal class Program
    {
        private string myName = "ULAB";
        private int myAge = 0;
        public string Name
        {
            get { return myName; }
            set { myName = value; }
        }
        public int Age
        {
            get { return myAge; }
            set { myAge = value; }
        }
        public string PRINT()
        { 
            return "Name = " + Name + ", Age = " + Age;
        }
    private static void Main(string[] args)
        {
            Console.WriteLine("Simple Properties");
            Program p = new Program();
            Console.WriteLine("Person details - {0}", p.PRINT());
            p.Name = "Joe";
            p.Age = 99;
            Console.WriteLine("Person details - {0}", p.PRINT());
            p.Age += 1;
            Console.WriteLine("Person details - {0}", p.PRINT());
            Console.Read();
        }
    }
}
