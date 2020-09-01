using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjecMaandelijkseLonenKoenDeJans
{
    public class Loon
    {
        public double StartLoon;
        public bool BedrijfsWagen;
        public double AantalGewerkteUrenPerWeek;
        public double BijdrageSocZekerheid;
        public double Bedrijfsvoorheffing;

        public Loon(double startloon, bool bedrijfswagen, double aantalGewerkteUrenPerWeek,double bijdrageSocZekerhied, double bedrijfsvoorheffing)
        {
            this.StartLoon = startloon;
            this.BedrijfsWagen = bedrijfswagen;
            this.AantalGewerkteUrenPerWeek = aantalGewerkteUrenPerWeek;
            this.BijdrageSocZekerheid = bijdrageSocZekerhied;
            this.Bedrijfsvoorheffing = bedrijfsvoorheffing;
        }

        public virtual double BerekenStartLoon()
        {
            double startLoonNaUurBerekening = Math.Round(((AantalGewerkteUrenPerWeek/38) * StartLoon),2);
            return StartLoon;
        }


    }
}
