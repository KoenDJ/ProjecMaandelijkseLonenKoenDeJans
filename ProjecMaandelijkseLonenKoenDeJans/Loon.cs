using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjecMaandelijkseLonenKoenDeJans
{
    public class Loon // Hier géén overerving
    {
        public double StartLoon;
        public double Nettoloon;
        public bool BedrijfsWagen;
        public double AantalGewerkteUrenPerWeek;
        public double BijdrageSocZekerheid;
        public double Bedrijfsvoorheffing;

        public Loon(double startloon, double aantalGewerkteUrenPerWeek, bool bedrijfswagen)
        {
            this.StartLoon = startloon;
            this.Nettoloon = startloon;
            this.BedrijfsWagen = bedrijfswagen;
            this.AantalGewerkteUrenPerWeek = aantalGewerkteUrenPerWeek;
            this.BijdrageSocZekerheid = 200; // verkorte versie van if statement om te bepalen als er een bedrijfswagen is of niet
            Bedrijfsvoorheffing = BedrijfsWagen ? Bedrijfsvoorheffing = 17.30 : Bedrijfsvoorheffing = 13.68;
        }

        public virtual double BerekenStartLoon() // methode voor berekening startloon
        {
            double startLoonNaUurBerekening = Math.Round(((AantalGewerkteUrenPerWeek / 38) * StartLoon), 2);
            StartLoon = startLoonNaUurBerekening;
            return StartLoon;
        }

        public override string ToString()
        {
            return StartLoon.ToString();
        }
    }
}
