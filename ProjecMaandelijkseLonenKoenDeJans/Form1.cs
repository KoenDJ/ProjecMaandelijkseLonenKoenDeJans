using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public static List<Werknemer> werknemersLijst = new List<Werknemer>();

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime geboortedatum = new DateTime(1976, 07, 18);
            DateTime indienst = new DateTime(2015, 06, 16);
            Loon nieuwLoon = new Loon(1900, 38, true);
            Werknemer werknemer = new Werknemer("Koen De Jans", "Man", geboortedatum, "2500", indienst, "BE00 0000 0000", nieuwLoon);
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
            lblStartloon.Text = geselecteerdeWerknemer.Loon.BerekenStartLoon().ToString();
        }

        private void btnBasisloonAanpassen_Click(object sender, EventArgs e)
        {
            // Werknemer uit combobox halen en meegeven naar andere form.
            Werknemer geselecteerdeWerknemer = (Werknemer)cbWerknemers.SelectedItem;
            AanpassenLoon f = new AanpassenLoon(geselecteerdeWerknemer);
            f.Show();
            this.Close();
        }
    }
}
