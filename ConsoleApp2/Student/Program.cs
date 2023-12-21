using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    
        internal class Student
        {
            public int id;
            public string name;
            public int age;
            public string gender;
            public string address;
            public string subject;
            public double gpa;

            public Student()
            {

            }

            public Student(int id, string name, int age, string gender, string address, string subject, double gpa )
            {
                this.id = id;
                this.name = name;
                this.age = age;
                this.gender = gender;
                this.address = address;
                this.subject = subject;
                this.gpa = gpa;


            }

            public override string ToString()
            {
                return $"{id:000}\t{name}\t{age}\t{gender}" +
                    $"{address}\t{subject}\t{gpa:0.00}";
            }
            public void Input()
            {
                Console.Write("Enter ID       =");
                id = int.Parse(Console.ReadLine());
                Console.Write("Enter Name     =");
                name =Console.ReadLine();
                Console.Write("Enter Age      =");
                age = int.Parse(Console.ReadLine());
                Console.Write("Enter Gender   =");
                gender = Console.ReadLine();
                Console.Write("Enter Address  =");
                address = Console.ReadLine();
                Console.Write("Enter Subject  =");
                subject = Console.ReadLine();
                Console.Write("Enter GPA      =");
                gpa = double.Parse(Console.ReadLine());

            }

        }

     

    }

