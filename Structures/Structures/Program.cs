using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    internal class Program
    {
        struct Learn
        {
            public string Name;
            public int id;
            public string subject;
            public string department;
        }
        public class structure
        {

            static void Main(string[] args)
            {
                Learn learn;
                Learn learn2;
                learn.subject = "C# with net";
                learn.Name = "Plabon";
                learn.id = 193014055;
                learn.department = "computer science";

                learn2.Name = "Rahmun";
                learn2.subject = "C# with .net";
                learn2.department = "Computer Science";
                learn2.id = 193014056;

                Console.WriteLine("Name : {0}", learn.Name);
                Console.WriteLine("Subject :{0}", learn.subject);
                Console.WriteLine("Department : {0}", learn.department);
                Console.WriteLine("Student Id : {0}",learn.id);

                Console.WriteLine("\n");

                Console.WriteLine("Name : {0}", learn2.Name);
                Console.WriteLine("Subject :{0}", learn2.subject);
                Console.WriteLine("Department : {0}", learn2.department);
                Console.WriteLine("Student Id : {0}", learn2.id);


                Console.ReadLine();


            }
        }
    }
}
