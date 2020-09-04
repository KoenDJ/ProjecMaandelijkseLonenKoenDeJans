using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjecMaandelijkseLonenKoenDeJans
{
    public class Programmeur : Werknemer // klasse Programmeur erft over van klasse Werknemer
    {
        public Programmeur(string naam, string geslacht, DateTime geboortedatum, string rijksregisternr, DateTime datumIndiensttreding , string ibanNr, Loon loon) :base(naam, geslacht, geboortedatum, rijksregisternr, datumIndiensttreding , ibanNr, loon)
        {
            this.Naam = naam;
            this.Geslacht = geslacht;
            this.GeboorteDatum = geboortedatum;
            this.RijksregisterNr = rijksregisternr;
            this.IbanNr = ibanNr;
            this.Loon = loon;
            this.Functie = "Programmeur";
        }
    }
}
