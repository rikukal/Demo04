using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_Hissi
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an elevator object
            Hissi hissi = new Hissi();
            hissi.Kerros = -1;       // Tämä arvo näkyy tulosteessa - olettaen, että se on raja-arvojen sisällä -- muutoin tulosteksti asettaa lähimmän raja-arvon
            Console.WriteLine("Olet kerroksessa {0}",hissi.Kerros); // tulostettuun tekstiin arvo pitää ilmaista muotoa: luokan olion nimi(hissi[pienellä].Ominaisuus (Kerros[ISOLLA ALKUKIRJAIMELLA]) 
        }
    }
}
