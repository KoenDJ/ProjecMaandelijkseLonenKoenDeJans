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
        public string GeboorteDatum { get; set; }
        public string RijksregisterNr { get; set; }
        public string DatumIndiensttreding { get; set; }
        public string IbanNr { get; set; }

        public Loon Loon = new Loon();
        public Werknemer(string naam, string geslacht, string geboortedatum, string rijksregisterNr, string datumIndiensttreding, string ibanNr, Loon loon)
        {
            this.Naam = naam;
            this.Geslacht = geslacht;
            this.GeboorteDatum = geboortedatum;
            this.RijksregisterNr = rijksregisterNr;
            this.DatumIndiensttreding = datumIndiensttreding;
            this.IbanNr = ibanNr;
            this.Loon = loon;
        }
    }
}
