using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_Hissi
{
    class Hissi
    {
        //field variables (tässä annetaan PRIVAATISTI olion ominaisuuksille RAJA-ARVOT

        private readonly int maxKerros = 5;
        private int kerros;
        

        // property variables kerrotaan arvot ja puretaan get - set - mallin avulla
        public int Kerros 
        {

            get
            {
                return kerros;
            }

            set // arvojen maksimi ja minimiarvojen määritelmät if, (if else) ja else lausekkeita ilmoitetaan set-mallilla
            {
                if (value < 0)
                {
                    Console.WriteLine("Et voi kulkea hissillä alemmas");
                        kerros = 1;
                }
                else if (value > 5)
                {
                    Console.WriteLine("Et voi kulkea hissillä ylemmäs");
                        kerros = 5;
                }
                else
                {
                    kerros = value;
                }
            }

        }

        
    }
}
