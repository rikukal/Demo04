using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esim
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a car object
            Car car = new Car();
            car.Speed = 100000;
            car.Height = 5.0;
            Console.WriteLine("Speed is {0} and Height {1}", car.Speed, car.Height);
        }
    }
}
