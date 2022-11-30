using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Program
    {
        struct Learn
        {
            public string Name;
            public int id;
            public string subject;
            public string department;
            public double cgpa;
        }
            
            static void Main(string[] args)
            {
                Learn learn;
                Learn learn2;
                learn.subject = "C# with net";
                learn.Name = "Plabon";
                learn.id = 193014055;
                learn.department = "computer science";
                learn.cgpa = 3.15;

                learn2.Name = "Rahmun";
                learn2.subject = "C# with .net";
                learn2.department = "Computer Science";
                learn2.id = 193014056;
                learn2.cgpa = 3.25;

                Console.WriteLine("Name : {0}", learn.Name);
                Console.WriteLine("Subject :{0}", learn.subject);
                Console.WriteLine("Department : {0}", learn.department);
                Console.WriteLine("Student Id : {0}", learn.id);
                Console.WriteLine("Student CGPA : {0}",learn.cgpa);

                Console.WriteLine("\n");

                Console.WriteLine("Name : {0}", learn2.Name);
                Console.WriteLine("Subject :{0}", learn2.subject);
                Console.WriteLine("Department : {0}", learn2.department);
                Console.WriteLine("Student Id : {0}", learn2.id);
                Console.WriteLine("Student CGPA : {0}", learn2.cgpa);
                Console.WriteLine("\n");
                double avg = (learn.cgpa + learn2.cgpa) / 2;
                Console.WriteLine("Avarage CGPA :  {0} ",avg);
                Console.ReadLine();


            }
    }
}
