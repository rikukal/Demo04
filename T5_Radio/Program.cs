using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5_Radio
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a radio object
            Radio radio = new Radio();
            radio.Volume = -5;
            radio.Frequency = 0;
            radio.IsOn = true;
            Console.WriteLine("Radio Information:");
            Console.WriteLine("IsOn:" + radio.IsOn);
            Console.WriteLine("Volume:" +radio.Volume);
            Console.WriteLine("Frequency: " + radio.Frequency);
        }
    }
}
