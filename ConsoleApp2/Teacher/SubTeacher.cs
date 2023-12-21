using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class SubTeacher
    {

        public static void AddTeacher(List<Teacher> teachers)
        {
            int n;
            Console.Write("Enter Number to Add =");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Teacher teacher = new Teacher();
                teacher.InputTeach();
                teachers.Add(teacher);
                Console.WriteLine("______________________________");

            }

        }

        public static void ShowAllTeach(List<Teacher> teachers)
        {
            Console.WriteLine("ID\tName\tAge\tSubject\tSalary");
            foreach(Teacher teacher in teachers)
            {
                Console.WriteLine(teacher);
            }
        }

        public static void RemoveTechByID(List<Teacher> teachers)
        {
            int id;
            Console.Write("Enter ID to Remove = ");
            id = int.Parse(Console.ReadLine());

            foreach(Teacher teacher in teachers.ToList())
            {
                if (teacher.id == id)
                {
                    teachers.Remove(teacher);
                    Console.WriteLine($"{id:000}Has Been Removed");
                }
                else
                {
                    Console.WriteLine("ID Not Found");
            
                }

            }



        }

        public static void EditTeachbyID(List<Teacher> teachers)
        {
            int id;
            Console.Write("Enter ID to Edit =");
            id = int.Parse(Console.ReadLine());

            foreach (Teacher teacher in teachers.ToList())
            {
                if(teacher.id == id)

                {
                    Console.WriteLine($"ID = {id:000}");
                    Console.Write("Enter Name        = ");
                    string newna = Console.ReadLine();
                    Console.Write("Enter Age         = ");
                    int newag = int.Parse(Console.ReadLine());
                    Console.Write("Enter Subject     = ");
                    string newsub = Console.ReadLine();
                    Console.Write("Enter Salary      = ");
                    double newsa = double.Parse(Console.ReadLine());

                    
                    teacher.name = newna;
                    teacher.age = newag;
                    teacher.subject = newsub;
                    teacher.salary = newsa;
                }
                else
                {
                    Console.WriteLine("ID Not Found");
                  
                }
            }

        }


        public static int Menu()
        {
            Console.WriteLine("Press 1 to Add Info");
            Console.WriteLine("Press 2 to Show Info");
            Console.WriteLine("Press 3 to Remove");
            Console.WriteLine("Press 4 to Edit");
            Console.WriteLine("Press 5 to Exit");

            int num;
            do
            {
                Console.Write("Please Press The Menu Number to Access =");
                num = int.Parse(Console.ReadLine());

            } while (!(num >= 1 && num <= 5));
            return num;


        }






    }
}


