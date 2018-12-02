using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektC1
{
    public class telewizory
    {
        public telewizory(string cena, string przekątna, string waga)
        {
            Cena = cena ?? throw new ArgumentException(nameof(cena));
            Przekątna = przekątna ?? throw new ArgumentException(nameof(przekątna));
            Waga = waga ?? throw new ArgumentException(nameof(waga));
        }

        public string Cena { get; set; }
        public string Przekątna { get; set; }
        public string Waga { get; set; }


         public override string ToString()  // nadpisywanie klasy ToString override
            {
                return "Cena: "+Cena + " " + Waga + " " + Przekątna;
            }

    }

   
}
