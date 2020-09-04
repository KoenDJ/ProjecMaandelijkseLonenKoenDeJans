using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjecMaandelijkseLonenKoenDeJans
{
    public class Werknemer // mijn hoofklasse
    {
        public string Naam { get; set; }
        public string Geslacht { get   ; set; }
        public DateTime GeboorteDatum { get; set; }
        public string RijksregisterNr { get; set; }
        public DateTime DatumIndiensttreding { get; set; }
        public string IbanNr { get; set; }
        public Loon Loon { get; set; }
        public string Functie { get; set; }
        public Werknemer(string naam, string geslacht, DateTime geboortedatum, string rijksregisterNr, DateTime datumIndiensttreding, string ibanNr, Loon loon)
        {
            this.Naam = naam;
            this.Geslacht = geslacht;
            this.GeboorteDatum = geboortedatum;
            this.RijksregisterNr = rijksregisterNr;
            this.DatumIndiensttreding = datumIndiensttreding;
            this.IbanNr = ibanNr;
            this.Loon = loon;
            this.Functie = "Werknemer";
        }

        public override string ToString()
        {
            return Naam;
        }

        //  code gevonden op stackoverflow van Stack Overflow
        public double BerekenAncieniteit()
        {
            DateTime zeroTime = new DateTime(1, 1, 1);
            double bedragAncienniteit = 0;

            TimeSpan span = DateTime.Now - DatumIndiensttreding;
            // omdat we bij het begin van de jaartelling starten met 1, moeten we dus op het einde terug 1 aftrekken
            int years = (zeroTime + span).Year - 1;

            for (int i = years; i > 1; i--)
            {
                Loon.Nettoloon *= 1.01;
                bedragAncienniteit = Loon.Nettoloon - Loon.StartLoon;
            }

            return bedragAncienniteit;
        }

        public double SocialeZekerheid() // berekenen socialezekerheid - dit was in dit geval vast: -200 euro
        {
            Loon.Nettoloon -= 200;
            return 200;
        }

        public double Bedrijfsvoorheffing() //bedrijfsvoorheffing berekenen.  Omdat een programmeur een auto kan hebben
            // eerst controleren als er auto is en dan beslissen welk percentage we moeten toepassen
        {
            if (this.Loon.BedrijfsWagen)
            {
                double aftehouden = Loon.Nettoloon * 0.1730;
                Loon.Nettoloon -= aftehouden;
                return aftehouden;
            }

            else
            {
                double aftehouden = Loon.Nettoloon * 0.1368;
                Loon.Nettoloon -= aftehouden;
                return aftehouden;
            }
        }

        // Code van Benjamin . Ik was terug in tijdsnood en ik wist niet hoe ik het anders kon doen, dus dank U Benjamin
        public void GeneratePayslip(string root)
        {
            string path = root + " " + $"{Naam}.txt";
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("------------------------------------------------------");
                sw.WriteLine($"Loonbrief {DateTime.Now.ToString("MMMM yyyy")}");
                sw.WriteLine("------------------------------------------------------");
                sw.WriteLine($"Naam                           :   {Naam}");
                sw.WriteLine($"Rijksregister nr.              :   {RijksregisterNr}");
                sw.WriteLine($"Iban nr.                       :   {IbanNr}");
                sw.WriteLine($"Geslacht                       :   {Geslacht}");
                sw.WriteLine($"Geboorte Datum                 :   {GeboorteDatum.ToShortDateString()}");
                sw.WriteLine($"Datum Indiensttreding          :   {DatumIndiensttreding.ToShortDateString()}");
                sw.WriteLine($"Functie                        :   {Functie}");
                sw.WriteLine($"Aantal gewerkte uren per week  :   {Loon.AantalGewerkteUrenPerWeek}");
                sw.WriteLine($"Bedrijfswagen                  :   {(Loon.BedrijfsWagen ? "Ja" : "Nee")}");
                sw.WriteLine("--------------------------------------------------------------------------------");
                sw.WriteLine($"Startloon                      :   €{Print(Loon.BerekenStartLoon())}");
                sw.WriteLine($"Anciëniteit                    : + €{Print(BerekenAncieniteit())}");
                sw.WriteLine($"                               :   €{Print(Loon.Nettoloon)}");
                sw.WriteLine($"Sociale zekerheid              : - €{Print(SocialeZekerheid())}");
                sw.WriteLine($"                               :   €{Print(Loon.Nettoloon)}");
                sw.WriteLine($"Bedrijfsvoorheffing            : - €{Print(Bedrijfsvoorheffing())}");
                if (this.Functie == "IT Support" || this.Functie == "CS Support")
                    SupportBonus();
                if (this.Functie == "CS Support")
                    CSSupportBonus();
                sw.WriteLine($"                               :   €{Print(Loon.Nettoloon)}");
                sw.WriteLine($"Netto Loon                     :   €{Print(Loon.Nettoloon)}");
            }
        }

        //Code from Benjamin
        public string Print(double numb)
        {
            string print = numb.ToString("0.00");
            print = string.Format("{0,10}", print);

            return print;
        }

        public double SupportBonus() // iedere Support medewerker krijgt extra 50 euro omdat hij van thuis werkt
        {
            return this.Loon.Nettoloon += 50;
        }

        public double CSSupportBonus() // de customer medewerker krijgt nog 19.50 maandelijkse onkosten terug betaald.
        {
            return this.Loon.Nettoloon += 19.50;
        }
    }
}
