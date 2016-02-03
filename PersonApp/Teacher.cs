using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Teacher : Person
    {
        public string Room { get; set; }

        public Teacher()
        {
        }

        public Teacher(string firsname, string lastname, string address, string room)
            : base(firsname,lastname,address)
        {
            Room = room; 
        }

        public void TeacherMethod()
        {
            Console.WriteLine("Typing vert fast...");
        }
        public override string ToString()
        {
            return base.ToString() + " " + Room;
        }
    }
}
