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
            radio.Volume = 0;
            radio.Frequency = 10000;
            radio.IsOn = true;
            Console.WriteLine¨("\n Radio Information: \nIsOn: {0} \nVolume: {1} \nFrequency: {2}"), radio.IsOn,radio.Volume,radio.Frequency;
        }
    }
}
