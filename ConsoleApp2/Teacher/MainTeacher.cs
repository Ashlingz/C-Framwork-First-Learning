using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class MainTeacher
    {
        static void Maina()
        {
            
            List<Teacher> teachers = new List<Teacher>();
        BACK:
            int num = SubTeacher.Menu();
            switch (num)
            {
                case 1:
                    SubTeacher.AddTeacher(teachers);
                    break;
                case 2:
                    SubTeacher.ShowAllTeach(teachers);
                    break;
                case 3:
                    SubTeacher.RemoveTechByID(teachers);
                    break;
                case 4:
                    SubTeacher.EditTeachbyID(teachers);
                    break;
                case 5:
                    Environment.Exit(0);
                    break;

            }
            Console.WriteLine("Press any key to Continue");
            Console.ReadKey();
            Console.Clear();
            goto BACK;
        }
    }
}
