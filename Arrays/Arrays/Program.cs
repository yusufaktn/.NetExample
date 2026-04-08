using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] students = new string[3];
            students[0] = "A";
            students[1] = "B";
            students[2] = "C";




             foreach (var student in students)
            {

                Console.WriteLine(student);
            }


            Console.WriteLine();
            Console.ReadLine();





        }
    }
}
