using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjecMaandelijkseLonenKoenDeJans
{
    public partial class Form1 : Form
    {
        // lijst waar we de werknemers instoppen
        public static List<Werknemer> werknemersLijst = new List<Werknemer>();

        public Form1()
        {
            // startpositie van startscherm centreren
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime geboortedatum = new DateTime(1976, 07, 18);
            DateTime indienst = new DateTime(2015, 06, 16);
            Loon nieuwLoon = new Loon(1900, 38, true);
            Werknemer werknemer = new Werknemer("Koen De Jans", "Man", geboortedatum, "2500", indienst, "BE00 0000 0000", nieuwLoon);
            
            // in combobox werknemer zetten ipv lege box bij opstart
            if (werknemersLijst.Contains(werknemer))
            {
                cbWerknemers.DataSource = werknemersLijst;
                cbWerknemers.SelectedIndex = 0;
            }

            else
            {
                werknemersLijst.Add(werknemer);
                cbWerknemers.DataSource = werknemersLijst;
                cbWerknemers.SelectedIndex = 0;
            }
        }
        private void cbWerknemers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Werknemer geselecteerdeWerknemer = (Werknemer)cbWerknemers.SelectedItem;
            lblGeslacht.Text = geselecteerdeWerknemer.Geslacht;
            lblGeboorteDatumInvullen.Text = geselecteerdeWerknemer.GeboorteDatum.ToShortDateString();
            lblRijksregisterInvullen.Text = geselecteerdeWerknemer.RijksregisterNr;
            lblInvullenDatIndiest.Text = geselecteerdeWerknemer.DatumIndiensttreding.ToShortDateString();
            lblInvullenIbanNr.Text = geselecteerdeWerknemer.IbanNr;
            lblStartloon.Text = geselecteerdeWerknemer.Loon.StartLoon.ToString();
        }

        private void btnBasisloonAanpassen_Click(object sender, EventArgs e)
        {
            // Werknemer uit combobox halen en meegeven naar andere form.
            Werknemer geselecteerdeWerknemer = (Werknemer)cbWerknemers.SelectedItem;
            AanpassenLoon f = new AanpassenLoon(geselecteerdeWerknemer);
            f.Show();
            this.Close();
        }

        private void btnLoonbriefAanmaken_Click(object sender, EventArgs e)
        {
            string root = $@"C:\Users\dejan\source\repos\ProjecMaandelijkseLonenKoenDeJans\ProjecMaandelijkseLonenKoenDeJans\ProjecMaandelijkseLonenKoenDeJans\bin\Debug\LOONBRIEVEN{DateTime.Today.ToString(" MM yyyy")}\";
            
            // aanmaken van map als hij nog niet bestaat
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);

                foreach (var item in Form1.werknemersLijst)
                {
                    item.GeneratePayslip(root);
                }
            }

            else MessageBox.Show("De map bestaat al");
        }

        private void btnWerknemerAanmaken_Click(object sender, EventArgs e) // button aanmaken werknemer
        {
            NieuweWerknemer form = new NieuweWerknemer();
            form.Show();
        }

        private void btnWerkNemerAanpassen_Click(object sender, EventArgs e) // button aanpassen werknemer
        {
            Werknemer geselecteerdeWerknemer = (Werknemer)cbWerknemers.SelectedItem;
            NieuweWerknemer f = new NieuweWerknemer(geselecteerdeWerknemer);
            f.Show();
        }

        // Refresh button aangemaakt om alles te refreshen.  Dit is niet de beste oplossing maar ik wist niet hoe het beter te doen
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cbWerknemers.DataSource = null;
            cbWerknemers.DataSource = werknemersLijst;
            cbWerknemers.SelectedIndex = 0;
        }

        private void btnVerwijderenWerknemer_Click(object sender, EventArgs e) // button verwijderen werknemer
            // foutmelding bij verwijderen laatste werknemer.  Ik zou dit beter kunnen oplossen maar helaas tijds tekort
        {
            Werknemer geselecteerdeWerknemer = cbWerknemers.SelectedItem as Werknemer;
            foreach (var item in werknemersLijst)
            {
                if (item.Naam == geselecteerdeWerknemer.Naam)
                {
                    werknemersLijst.Remove(item);
                    btnRefresh_Click(sender, e);
                    break;
                }
            }
        }
    }
}
