using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // create one student object
            Student student = new Student("Kirsi","Kernel","Piippukatu 2","K8989");
            Console.WriteLine("Student = " + student.ToString());
            student.StudentMethod();
            student.PersonMethod();

            Teacher teacher = new Teacher("Teppo", "Terävä", "Kielokuja 2", "D566");
            Console.WriteLine("Teacher = " + teacher.ToString());
            teacher.TeacherMethod();
            teacher.PersonMethod();
            
            // mahdollista olion ottaa aliluokan kutsu
            // Person person = new Teacher

        }
    }
}
