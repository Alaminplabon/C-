using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public enum Volume
    {
        Low, Medium, High
    }
    internal class Program
    {
        public class Enumswtch
        {
            static void Main(string[] args)
            {
                Volume vol = Volume.Low;
                switch (vol)
                {
                    case Volume.Low:
                        Console.WriteLine("The volume has been turned Down.");
                        break;
                    case Volume.Medium:
                        Console.WriteLine("The volume is in the middle.");
                        break;
                    case Volume.High:
                        Console.WriteLine("The volume has been turned up.");
                        break;

                }
                Console.ReadLine();
            }
        }
    }
}
