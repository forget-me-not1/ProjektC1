using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektC1  // jak jest taka sama nazwa to będą się wzajemnie widzieć.
{
    public class Kursant
    {
        public Kursant()
        {

        }

        public Kursant(string imię, string nazwisko)
        {
            Imię = imię ?? throw new ArgumentException(nameof(imię));
            Nazwisko = nazwisko ?? throw new ArgumentException(nameof(nazwisko));
        }

        public string Imię { get; set; }
        public string Nazwisko { get; set; }

        public override string ToString()  // nadpisywanie klasy ToString override
        {
            return Imię + " " + Nazwisko;
        }

    }
}
