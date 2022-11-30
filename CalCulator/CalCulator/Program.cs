using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char op;
            double num, num1;
            Console.WriteLine("Enter the operator (+, - , * , /)");
            op = Console.ReadLine()[0];
            Console.WriteLine("Enter Numbers One By One:");
            num=Convert.ToDouble(Console.ReadLine());
            num1 = Convert.ToDouble(Console.ReadLine());
            switch(op)
            {
                case '+':
                    Console.WriteLine("{0}+{1}={2}", num, num1, (num + num1));
                    break;
                case '-':
                    Console.WriteLine("{0}-{1}={2}", num, num1, (num - num1));
                    break;
                case '*':
                    Console.WriteLine("{0}*{1}={2}", num, num1, (num * num1));
                    break;
                case '/':
                    if(num1==0.0)
                    Console.WriteLine("Divide by zero:");
                    else
                    Console.WriteLine("{0}/{1}={2}", num, num1, (num / num1));
                    break;
                default:
                    Console.WriteLine("{0} is an invalide",op);
                    break;
            }

            Console.ReadLine();
        }
    }
}
