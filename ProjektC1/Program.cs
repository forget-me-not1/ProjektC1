using System;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Console;
using TestowaNamespace;
using MojaBiblioteka2;
using System.Linq;
using System.IO;

/// <summary>
/// a tego też wczeńśniej nie było v.1
/// </summary>

/// robimy zmiany do gałęzi drugiej. 


namespace ProjektC1
{
    class Program
    {
        static void Main(string[] args) //klasa statyczna
        {
            var powtórz = "t";
            do
            {
                //DemoConsole01();
                //DemoTypyDanych();
                //DemoStrukturyJęzykowe();
                //DemoParsowanie();
                //RównanieKwadratowe();
                //WspółczynnikBMI();
                //DemoUkład2Równań2Niewiadome();
                //DemoKrotki();
                //DemoPrzestrzenie();
                //DemoPrzeciążanieMetod(); //w zależności od podanych parametórw i ich typów
                //DemoParametryOpcjonalne();
                //DemoWartościReferencje();
                //DemoTabele();
                //DemoLiczbyPierwsze();
                //DemoTypyNullowalne();
                DemoPracaPlikiTXT();


                WriteLine("czy powtórzyć? t/n");
                powtórz = Convert.ToString(Console.ReadLine());
                Clear();
                //ReadKey(); // czekaj aż coś się naciśnie na klawiaturze. 
            } while (powtórz == "t");

            //tego wcześniej nie było. 
        }

        private static void DemoPracaPlikiTXT()
        {
            /*
             * string cośDoZapisuTxt;
            FileStream fsZapis;
            fsZapis = new FileStream(@"C:\Users\cieslo\Documents\visual studio 2017\Projects\ProjektC1\ProjektC1\klasa\pliki\dane.txt", FileMode.Create);  //create - tworzy nowy, createNew - sprawdza czy istnieje i wywala wyjątek który trzeba obsłużyć.
            StreamWriter sw = new StreamWriter(fsZapis);
           
            WriteLine("Podaj swoje imię:");
            string imię = ReadLine();
            WriteLine("Podaj swoje nazwisko:");
            string nazwisko = ReadLine();
            cośDoZapisuTxt = imię + " " + nazwisko;
            sw.WriteLine(cośDoZapisuTxt); //zapis do pliku
            sw.Close(); //zamknięcie pliku
            
*/
            //odczyt pliku
            /*
            string cośOdczytaneZpliku;
            FileStream fsOdczyt;
            fsOdczyt = new FileStream(@"C:\Users\cieslo\Documents\visual studio 2017\Projects\ProjektC1\ProjektC1\klasa\pliki\dane.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fsOdczyt);

            //TODO - do dokończenia odczyt pliku i wyświetlenie promienia koła
            while ((cośOdczytaneZpliku = sr.ReadLine()) != null)
            {
                int i=0;
                if (i < 3)
                    {
                        PromieńKoła(float.TryParse(float cośOdczytaneZpliku, out float promień));
                        WriteLine(cośOdczytaneZpliku);
                        i++;
                        
                    }
            }
            sr.Close();
            */

            /*
                        //ścieżka do pliku
                        string ścieżka = @"C:\Users\cieslo\Documents\visual studio 2017\Projects\ProjektC1\ProjektC1\klasa\pliki\dane.txt";
                        if (!File.Exists(ścieżka))
                        {
                            using (StreamWriter sw = File.CreateText(ścieżka))
                            {
                                WriteLine("Podaj swoje imię:");
                                string imię = ReadLine();
                                WriteLine("Podaj swoje nazwisko:");
                                string nazwisko = ReadLine();
                                string cośDoZapisuTxt = imię + " " + nazwisko;
                                sw.WriteLine(cośDoZapisuTxt);
                            }
                        }
                        else
                        {
                            using (StreamWriter sw = File.AppendText(ścieżka))
                            {
                                WriteLine("Podaj swoje imię:");
                                string imię = ReadLine();
                                WriteLine("Podaj swoje nazwisko:");
                                string nazwisko = ReadLine();
                                string cośDoZapisuTxt = imię + " " + nazwisko;
                                sw.WriteLine(cośDoZapisuTxt+Environment.NewLine);
                            }
                        }
                        */
            string ścieżka = @"pliki\raven.txt";
           /* 
            string danePlik = File.ReadAllText(ścieżka);
            WriteLine(danePlik);

            string[] danePlikArr = File.ReadAllText(ścieżka);  //TODO - coś nie działa
            foreach (var item in danePlikArr)
            {
                WriteLine(item);
            }
            int ileLiniiTekstu = File.ReadAllLines(ścieżka).Length;
            WriteLine(ileLiniiTekstu);
            */
            //użycie Linq
            var linieKruk = (from l in File.ReadAllLines(ścieżka)  // tu jest specyficzny zapis biblioteki Linq
                             where l.Contains("Raven")
                             select l).ToList();
            foreach (var item in linieKruk)
            {
                WriteLine(item);
            }

            string ścieżkaWyniki = @"pliki\ravenWyniki.txt";
            File.WriteAllLines(ścieżkaWyniki, linieKruk);

        }

        private static void PromieńKoła(bool v)
        {
            throw new NotImplementedException();
        }

        private static void DemoTypyNullowalne()
        {
            int? liczba = null;
            int? liczbaInna = null;
            bool? czyChceszIśćDoKina = null;
            double? liczbaRzecz = new double?();

            double wynik;
            wynik = liczbaInna ?? 0;  // ?? - jeśli liczba inna to wpisz null
            wynik = liczbaInna ?? liczba ?? 0;  // ?? - sprawdź czy liczba jeżeli nie to idź dalej, a na końcu wpisz 0 jeżeli wcześniej nie było liczby.
            WriteLine(wynik.ToString());  //przyda się przy projektach bazodanowych! 

            // na pliki binarne - binaryformater
            


        }

        private static void DemoLiczbyPierwsze()
        {
            //string[] liczbyPierwsze = { "2", "3", "5", "7", "11", "13", "17", "19", "23" };

            //WriteLine("Sprawdź liczbę pierwszą");
            //string lit = ReadLine();

            //if (liczbyPierwsze.Contains(lit))
            //{ //contains - porównuje tylko string a nie char
            //    WriteLine(lit + "jest liczbą pierwszą");
            //}
            //else
            //{
            //    WriteLine(lit + "nie jest liczbą pierwszą");
            //}

            ///niezrobiony projekt.
            ///
            /// 
            ////long[] liczbyPierwsze = { 2, 3, 5, 7, 11, 13, 17, 19, 23 };

            ////WriteLine("Sprawdź liczbę pierwszą");
            ////long lit = ReadLine();

            ////if ()
            ////{ //contains - porównuje tylko string a nie char
            ////    WriteLine(lit + "jest liczbą pierwszą");
            ////}
            ////else
            ////{
            ////    WriteLine(lit + "nie jest liczbą pierwszą");
            ////}
            ///

            //tablica wielowymiarowa (2)
            double[,] liczby = new double[2, 2] { { 3.34, 4.32 }, { 1.23, 6.43 } };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    WriteLine(liczby[i, j]);
                }
            }

            //tablica nieregularna (postrzępiona, jadged)
            string[][,] ludzie = new string[3][,] // przecinek oznacza 2 elementy [,,] - trzy elementy
            {
                new[,] {{"imię","jan"}, { "wiek", "34"} },
                new[,] {{"imię","iwona"}, { "wiek", "24"}, { "adres", "Jerozolimskie 23B"} },
                new[,] {{"imię","Marcin"}, { "wiek", "18"} }
            };

            for (int i = 0; i < ludzie.Length; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        WriteLine(ludzie[i][j, k]);
                    }
                }
            }



        }

        private static void DemoTabele()
        {
            string[] samogłoski = { "a", "e", "ą", "ę", "u", "ó", "i", "o" };
            for (int i = 0; i < samogłoski.Length; i++)
            {
                WriteLine(samogłoski[i]);
            }
            foreach (var item in samogłoski)
            {
                WriteLine(item);
            }
            WriteLine("Wpisz literę");
            string lit = ReadLine();

            if (samogłoski.Contains(lit)){ //contains - porównuje tylko string a nie char
                WriteLine(lit + "jest samogłoską");
            } else
            {
                WriteLine (lit + "jest spółgłoską");
            }
        }

        private static void DemoWartościReferencje()
        {
            int liczba = 23;
            int liczba2 = 23;
            WriteLine("przed");
            WriteLine("licza 1 {0}", liczba);
            WriteLine("licza 2 {0}", liczba2);

            ZmieńArgumenty(liczba, ref liczba2);

            WriteLine("po");
            WriteLine("licza 1 {0}", liczba);
            WriteLine("licza 2 {0}", liczba2);
        }

        private static void ZmieńArgumenty(object liczba, ref int liczba2)
        {
            liczba = 45;
            liczba2 = 45;
        }

        private static void DemoParametryOpcjonalne()
        {
            WriteLine("POle prostokąta wynosi: {0}", PoleProstąta(12.45, 3.4));
            WriteLine("Pole prostokąta wynosi: {0}", PoleProstąta(12.45));
        }


        /// <summary>
        /// korzytsanie z metody opcjonalnej.
        /// </summary>
        /// <param name="bokA">wymagany - obliczamy prostokąt lub kwadrat</param>
        /// <param name="bokB">opcjonalny - obliczamy kwadrat jeśli 0</param>
        /// <returns>wynik pola prostokąta lub kwadratu</returns>
        private static double PoleProstąta(double bokA, double bokB = 0)
        {
            if (bokB == 0)
            {
                return bokA * bokA;
            } else
            {
                return bokA * bokB;
            }
            
        }

        private static void DemoPrzeciążanieMetod()
        {
            WriteLine("Pole Koła o promieniu {0} wynosi {1}", 2.45, PoleKoła(2.45));
            WriteLine("Pole Koła o promieniu {0} wynosi {1}", "4.45", PoleKoła("4,45"));
            
        }

        private static double PoleKoła(double promień) //tu jest 
            {
                return Math.PI* Math.Pow(promień,2);
            }

        private static object PoleKoła(string promień)
    {
        if (!double.TryParse(promień, out double pr))
        {
            return "Źle podany promień";
        }
        else
        {
            return Math.PI * Math.Pow(pr, 2);
        }
    }

        private static void DemoPrzestrzenie()
        {
            //DemoNS01();
            DemoKlasa.DemoNS01();
            mojaKlasaNS.DemoNS01();
        }

        private static void DemoKrotki()
        {
            var krotka = ("trzy", 4);
            WriteLine(krotka);
            (int, string, bool) krotka2 = (23, "testk", false);
            WriteLine(krotka2);
            var krotkaNazwy = (nazwaWina: "Tokaj", ilość: 3);
            WriteLine("zakupiono " + krotkaNazwy.nazwaWina);
            foreach (var item in GeneratorDlaKrotki(krotka))
            {
                WriteLine(item);
            }


        }

        private static IEnumerable<object> GeneratorDlaKrotki((string, int) krotka)  //IEnumerable - wyliczenia
        {
            yield return krotka.Item1;
        }

        private static void DemoUkład2Równań2Niewiadome()
        {
            //ax+by=c
            //dx+ey=f
            //?W, Wx, Wy
            //x = Wx/w, y=Wy/W
            double a=5, b=4.5, c=3, d=0, e=4.1, f=7;

            //WriteLine("podaj a:");
            //a = ReadLine();
            //WriteLine("podaj b:");
            //b = ReadLine();
            //WriteLine("podaj c:");
            //c = ReadLine();
            //WriteLine("podaj d:");
            //d = ReadLine();
            //WriteLine("podaj e:");
            //e = ReadLine();
            //WriteLine("podaj f:");
            //f = ReadLine();
            ////a = Convert.ToInt32(Console.ReadLine());
            try
            {
                var W = a * e - b * d;
                var Wx = c * e - b * f;
                var Wy = a * f - c * d;
                var x = Wx / W;
                var y = Wy / W;
                WriteLine($"x = {x}, y = {y}");
            }
            catch (DivideByZeroException ex)  //dzielenie przez zero tylko występuje w int, w double pokazuje wartość inifinty. 
            {
                Debug.WriteLine(ex.Message);
            }

         


        }

        private static void WspółczynnikBMI()
        {
            WriteLine("Podaj masę: ");
            var jeden = ReadLine();
            
            if (float.TryParse(jeden, out float jeden2))
            {
                if(jeden2 < 0) {
                    WriteLine("podaj jeszcze raz wzrost: ");
                    jeden = ReadLine();
                }
            }
            WriteLine("Podaj wzrost w centymetrach: ");
            var dwa = ReadLine();
            if (float.TryParse(dwa, out float dwa2))
            {
                if (dwa2 < 5)
                {
                    WriteLine("podaj jeszcze raz wzrost: ");
                    dwa = ReadLine();
                }
            }
            

                if (!float.TryParse(jeden, out float liczba1) || !float.TryParse(dwa, out float liczba2) ) //out - jak ci się uda to parsuj
            {
                throw new ArgumentException("błąd! nie wprowadzono liczb! "); // błąd typu danych argumentexception - do celów produkcyjnych.
                //Debug.WriteLine("błąd danych!");  // wyprodukowanie do naszej wiadomości - teksty w Dane wyjściowe.

            }
            else
            {
                double wynik = liczba1 / Math.Pow(liczba2/100, 2); //((liczba2/100) * (liczba2/100));
                if(wynik<18.5) {
                    WriteLine("Twój wynik BMI wynosi: " + wynik + " - niedowaga");
                } else if (wynik >= 25)
                {
                    WriteLine("Twój wynik BMI wynosi: " + wynik + " - nadwaga");
                } else
                {
                    WriteLine("Twój wynik BMI wynosi: " + wynik + " - prawidłowa waga.");
                }



            }
            
        }

        private static void RównanieKwadratowe()
        {
            WriteLine("Podaj liczbę a: ");
            var jeden = ReadLine();
            WriteLine("Podaj liczbę b: ");
            var dwa = ReadLine();

            WriteLine("Podaj liczbę c: ");
            var trzy = ReadLine();

            if (!float.TryParse(jeden, out float liczba1) || !float.TryParse(dwa, out float liczba2) || !float.TryParse(trzy, out float liczba3)) //out - jak ci się uda to parsuj
            {
                throw new ArgumentException("błąd! nie wprowadzono liczb! "); // błąd typu danych argumentexception - do celów produkcyjnych.
                //Debug.WriteLine("błąd danych!");  // wyprodukowanie do naszej wiadomości - teksty w Dane wyjściowe.

            }
            else
            {
                  if(liczba1 > 0)
                {
                    double delta = (liczba2 * liczba2) - (4 * liczba1 * liczba3);
                    double x1, x2, x0 ;
                    x0 = (-liczba2) / (2 * liczba1);
                    WriteLine("Delta wynosi: " + delta);
                    

                    
                    x1 = (-liczba2 + Math.Sqrt(delta)) / (2 * liczba1);
                    x2 = (-liczba2 - Math.Sqrt(delta)) / (2 * liczba1);
                    if (delta < 0) WriteLine("Nie istnieją pierwiastki");
                    else if (delta == 0) WriteLine($"x1 i x2 wynosi: {x0}");
                    else if (delta > 0) WriteLine("Istnieja pierwiastki i wynosza:\nx1={0}, x2={1}", x1, x2);

                } else
                {
                    WriteLine("podano liczbę mniejszą od zera.");
                }

                

            }

        }

        private static void DemoParsowanie()
        {
            WriteLine("Podaj 1 liczbę: ");
            var jeden = ReadLine();
            WriteLine("Podaj 2 liczbę: ");
            var dwa = ReadLine();
            
            if (!long.TryParse(jeden, out long liczba1) || !long.TryParse(dwa, out long liczba2)) //out - jak ci się uda to parsuj
            {
                throw new ArgumentException("błąd! wprowadź liczbę! "); // błąd typu danych argumentexception - do celów produkcyjnych.
                //Debug.WriteLine("błąd danych!");  // wyprodukowanie do naszej wiadomości - teksty w Dane wyjściowe.

            }
            else
            {
                
                var wynik = liczba1 * liczba2; 
                WriteLine("Pole prostokąta wynosi: " + wynik);
                WriteLine($"pole prostokąta wynosi: {liczba1 * liczba2}");
                

            }

        }

        private static void DemoStrukturyJęzykowe()
        {
            WriteLine("Podaj swój Pesel: ");
            var pesel = ReadLine();

            //WriteLine(liczba.GetType());  //pokaż zmienną GetType

            if (!long.TryParse(pesel, out long liczba)) //out - jak ci się uda to parsuj
            {
                throw new ArgumentException("nie wprowadzonon pesel jako liczby"); // błąd typu danych argumentexception
            }
            else
            {
                if(pesel.Length == 11)
                {
                    WriteLine("jest dobrze, możemy dalej analizować pesel");
                    int rok, miesiąc, dzień;
                    dzień = int.Parse(pesel.Substring(4, 2));
                    miesiąc = int.Parse(pesel.Substring(2, 2));
                    rok = int.Parse(pesel.Substring(0, 2));
                    if(miesiąc > 12)
                    {
                        miesiąc -= 20;
                        rok += 2000;
                    }
                    else
                    {
                        rok += 1900;
                    }
                    int płeć;
                    płeć = int.Parse(pesel.Substring(9, 1));
                    if (płeć % 2 == 0)
                    {
                        WriteLine("Dziewcznynka");
                        
                    }else
                    {
                        WriteLine("chłopczyk");
                    }



                    //DateTime teraz = new DateTime();
                    DateTime dataUrodzenia = new DateTime(rok, miesiąc, dzień);
                    WriteLine(dataUrodzenia.ToLongDateString());
                   // WriteLine(DateTime.Now.ToLongDateString());  //format daty bazuje na ustawionym w OS formacie daty.
                   // WriteLine(DateTime.Now.ToShortDateString());
                } else
                {
                    Debug.WriteLine("pesel powinieni mieć 11 cyferek");
                    //throw new ArgumentException("pesel powinieni mieć 11 cyferek");
                }

                
            }
        }

        private static void DemoTypyDanych()
        {
            throw new NotImplementedException();  // wywołanie wyjątku

            sbyte LiczbaMała = 120;

            short liczbaWiększa = -23456;
            Int16 liczbaWiększaInaczej = 23456;

            int liczbaJeszczeWiększa = 123456;
            Int32 liczbaTeżWiększa = 234567;

            long liczbaBardzoDużaInaczej = 1234567;
            Int64 liczbaBardzoDuża = 12324567;

            byte liczbaDodatniaMała = 123; //liczba dodatnia - na ujemne podkreśla błąd
            ushort liczbaWiększaDodatnia = 63456;
            uint liczbaDużaDodatnia = 416548546;
            ulong liczbaBardzoDużaDodatnia = 26541261;

            //liczby rzeczywiste
            
            float liczbaRzeczywista2 = 123.456F;
            double liczbaRzeczywistaCzęstoUżywana = 123.456678;
            decimal liczbaRzeczywistaBardzoDokładna = 123.456789123456789456M;

            //inne 
            bool czyJestemBogat = true;
            char znakKoduAscii = 'W';
        }



        /// <summary>
        /// komentarz opisujący dziłanie danej metody
        /// </summary>
        private static void DemoConsole01()  //metoda pusta void, nie zwraca wyniku
        {
            //Math.           // jak nie ma static - to znaczy że są metody, jak nie to trzeba używać słowa NEW
            WriteLine("Hello World!");
            WriteLine("Witaj " + Environment.UserName);
            WriteLine("Wpisz tekst: ");
            var imię = ReadLine();
            WriteLine("Witaj " + imię);
            WriteLine($"Witaj {imię}");  // $ tutaj będziesz używać nazwy zmiennej w {}
            WriteLine("Witaj {0}", imię); //{0} tablica indeksowana od zera.
        }
    }
}
