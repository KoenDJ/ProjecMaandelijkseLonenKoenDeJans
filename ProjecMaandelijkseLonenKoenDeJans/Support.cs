using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjecMaandelijkseLonenKoenDeJans
{
    public class Support : Werknemer // klasse Support erft over van hoofdklasse werknemer
    {
        public Support(string naam, string geslacht, DateTime geboortedatum,
            string rijksregisterNr, DateTime datumIndiensttreding, 
            string ibanNr, Loon loon):base(naam, geslacht, geboortedatum, rijksregisterNr, datumIndiensttreding, ibanNr, loon)
        {
            this.Naam = naam;
            this.Geslacht = geslacht;
            this.GeboorteDatum = geboortedatum;
            this.RijksregisterNr = rijksregisterNr;
            this.DatumIndiensttreding = datumIndiensttreding;
            this.IbanNr = ibanNr;
            this.Loon = loon;
            this.Functie = "CS Support";
        }
    }
}
