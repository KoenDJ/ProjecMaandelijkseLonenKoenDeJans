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

        public Loon(double startloon, double aantalGewerkteUrenPerWeek, bool bedrijfswagen = false)
        {
            this.StartLoon = startloon;
            this.BedrijfsWagen = bedrijfswagen;
            this.AantalGewerkteUrenPerWeek = aantalGewerkteUrenPerWeek;
            this.BijdrageSocZekerheid = 200;
            Bedrijfsvoorheffing = BedrijfsWagen ? Bedrijfsvoorheffing = 17.30 : Bedrijfsvoorheffing = 13.68;
        }

        public Loon()
        {

        }

        public virtual double BerekenStartLoon()
        {
            double startLoonNaUurBerekening = Math.Round(((AantalGewerkteUrenPerWeek / 38) * StartLoon), 2);
            StartLoon = startLoonNaUurBerekening;
            return StartLoon;
        }
    }
}
