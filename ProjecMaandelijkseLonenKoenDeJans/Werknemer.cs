using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjecMaandelijkseLonenKoenDeJans
{
    public class Werknemer
    {
        public string Naam { get; set; }
        public string Geslacht { get   ; set; }
        public DateTime GeboorteDatum { get; set; }
        public string RijksregisterNr { get; set; }
        public DateTime DatumIndiensttreding { get; set; }
        public string IbanNr { get; set; }
        public Loon Loon { get; set; }
        public Werknemer(string naam, string geslacht, DateTime geboortedatum, string rijksregisterNr, DateTime datumIndiensttreding, string ibanNr, Loon loon)
        {
            this.Naam = naam;
            this.Geslacht = geslacht;
            this.GeboorteDatum = geboortedatum;
            this.RijksregisterNr = rijksregisterNr;
            this.DatumIndiensttreding = datumIndiensttreding;
            this.IbanNr = ibanNr;
            this.Loon = loon;
        }

        public override string ToString()
        {
            return Naam;
        }
    }
}
