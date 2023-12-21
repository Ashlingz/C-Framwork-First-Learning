using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Teacher
    {
        public int id;
        public string name;
        public int age;
        public string subject;
        public double salary;

        public Teacher()
        {

        }

        public Teacher(int id, string name, int age, string subject, double salary)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.subject = subject;
            this.salary = salary;
        }

        public override string ToString()
        {
            return $"{id:000}\t{name}\t{age}\t{subject}\t{salary:c2}";
        }

        public void InputTeach()
        {
            Console.Write("Enter ID          = ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Enter Name        = ");
            name = Console.ReadLine();
            Console.Write("Enter Age         = ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter Subject     = ");
            subject = Console.ReadLine();
            Console.Write("Enter Salary      = ");
            salary = double.Parse(Console.ReadLine());
        }

    }
}


