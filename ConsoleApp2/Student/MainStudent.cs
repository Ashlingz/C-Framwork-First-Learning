using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
  internal class MainStudent
    {
        static void Mainx()
        {
            int n;
            Console.Write("Enter n =");
            n = int.Parse(Console.ReadLine());

            Student[] students = new Student[n];
            for(int i = 0; i< n; i++)
            {
                students[i] = new Student();
                students[i].Input();
                Console.WriteLine("_________________________________________________");
            }
            Console.WriteLine("ID\tName\tAge\tGender\tAddress\tSubject\tGPA");
            foreach(Student student in students)
            {
                Console.WriteLine(student);
            }
            Console.ReadKey();
        }
    }
}
