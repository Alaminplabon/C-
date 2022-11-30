using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 1, 5, 2, 1, 4, 7, 8, 9 };
            int[] temp = list;
            Console.WriteLine("Orginal array: ");
            foreach (int i in list)
            {
                Console.Write(i+ " ");
            }
            Console.WriteLine();
            Array.Reverse(temp);
            Console.Write("Reversed Array: ");
            foreach (int i in temp)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Array.Sort(list);
            Console.Write("Sorted Array: ");
            foreach (int i in list) 
            { 
                Console.Write(i + " ");
            }
            Console.WriteLine();







            Console.ReadLine();
        }
    }
}
