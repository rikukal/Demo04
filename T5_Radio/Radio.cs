using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5_Radio
{
    class Radio
    {
        //field variables (tässä annetaan PRIVAATISTI olion ominaisuuksille RAJA-ARVOT

            private readonly maxVolume = 9;
            private readonly minVolume = 0;
            private int Volume;

            private readonly maxFrequency = 26000;
            private readonly minFrequency = 2000.0;
            private double Frequency;
            


        // property variables puretaan raja-arvot tarvittaessa get - set - mallin avulla , muutoin get-set- tavallisesti

        public int Volume
        {
            get
            {
                return volume; 
            }
            set
            {
                if (value > 9)
                {
                    Console.WriteLine("Volume cannot be that loud - set to maxium volume");
                        volume = 9; 
                }
                if else (value < 0)
                {
                    Console.WriteLine("Volume cannot be that low - set to minium volume ");
                    volume = 0;
                }
                else
                {
                    volume = value;
                }

            }

        public double Frequency
        {
            get
            {
                return frequency;
            }
            set
            {
                if (value < 2000.0)
                {
                    Console.WriteLine("Frequncy has to be in 2000.0 - 26000.0 - set to minium limit");
                    frequency = 2000.0;
                }
                if else (value > 26000.0)
                {
                    Console.WriteLine("Frequncy has to be in 2000.0 - 26000.0 - set to maxium limit");
                    frequency = 26000.0;
                }
                else
                {
                   frequency = value;
                }
            }

        public bool IsOn { get; set; }

    }
}
