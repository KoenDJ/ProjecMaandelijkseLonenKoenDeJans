using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjecMaandelijkseLonenKoenDeJans
{
    public partial class NieuweWerknemer : Form
    {
        Werknemer geselecteerdeWerknemer;
        public NieuweWerknemer()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        // 2e Constructor indien werknemer aangepast moet worden, zodat form gevuld kan vullen.
        public NieuweWerknemer(Werknemer geselWerknemer)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            geselecteerdeWerknemer = geselWerknemer;
        }

        private void NieuweWerknemer_Load(object sender, EventArgs e)
        {
            // Kijken of er werknemer is meegegeven om aan te passen, zo ja boxen vullen met gegevens van persoon.
            if (geselecteerdeWerknemer != null)
            {
                tbNaam.Text = geselecteerdeWerknemer.Naam;
                cbGeslacht.Text = geselecteerdeWerknemer.Geslacht;
                dtpGeboortedatum.Value = geselecteerdeWerknemer.GeboorteDatum;
                tbRijksregister.Text = geselecteerdeWerknemer.RijksregisterNr;
                tbIban.Text = geselecteerdeWerknemer.IbanNr;
                tbStartloon.Text = geselecteerdeWerknemer.Loon.ToString();

            }
            VulComboboxen();
        }

        private void VulComboboxen()
        {
            cbFuncties.Items.Add("Werknemer");
            cbFuncties.Items.Add("Programmeur");
            cbFuncties.Items.Add("IT Support");
            cbFuncties.Items.Add("CS Support");
            cbFuncties.SelectedIndex = 0;

            cbGeslacht.Items.Add("Man");
            cbGeslacht.Items.Add("Vrouw");
            cbGeslacht.SelectedIndex = 0;
        }

        private void Opslaan_Click(object sender, EventArgs e)
        {
            // Controle of alle velden ingevuld zijn.
            if (tbNaam.Text == string.Empty || cbGeslacht.Text == string.Empty || tbRijksregister.Text == string.Empty
                 || tbIban.Text == string.Empty || tbStartloon.Text == string.Empty || cbFuncties.Text == string.Empty || tbUren.Text == string.Empty)
            {
                MessageBox.Show("Gelieve alle velden in te vullen.");
            }

            // Kijken of bij loon en uren correcte input werd gegeven.
            else if (!double.TryParse(tbStartloon.Text, out double startloon) || !int.TryParse(tbUren.Text, out int uren))
            {
                MessageBox.Show("Gelieve de correcte tekens in de juiste velden te gebruiken.");
            }

            else
            {
                Loon nieuwLoon = new Loon(Convert.ToDouble(tbStartloon.Text), Convert.ToDouble(tbUren.Text), rbJa.Checked ? true : false);
                Werknemer nieuweWerknemer = new Werknemer(tbNaam.Text, cbGeslacht.Text, dtpGeboortedatum.Value, tbRijksregister.Text, dtpIndienst.Value, tbIban.Text, nieuwLoon);
                foreach (var item in Form1.werknemersLijst)
                {
                    // Als een match wordt gevonden, overschrijf.
                    if (item.Naam == nieuweWerknemer.Naam)
                    {
                        item.Naam = nieuweWerknemer.Naam;
                        item.Geslacht = nieuweWerknemer.Geslacht;
                        item.GeboorteDatum = nieuweWerknemer.GeboorteDatum;
                        item.RijksregisterNr = nieuweWerknemer.RijksregisterNr;
                        item.DatumIndiensttreding = nieuweWerknemer.DatumIndiensttreding;
                        item.IbanNr = nieuweWerknemer.IbanNr;
                        item.Loon = nieuweWerknemer.Loon;
                        item.Functie = nieuweWerknemer.Functie;
                    }
                }
                Form1.werknemersLijst.Add(nieuweWerknemer);
                Form1.ActiveForm.Invalidate();
                Form1.ActiveForm.Refresh();
                this.Close();
            }
        }

        private void cbFuncties_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kijken of geselecteerde functie programmeur is en indien nodig de groupbox bedrijfswagen activeren.
            if (cbFuncties.SelectedIndex != 1)
            {
                gbBedrijfswagen.Enabled = false;
                rbJa.Checked = false;
                rbNee.Checked = false;
            }

            else
            {
                gbBedrijfswagen.Enabled = true;
            }
        }
    }
}
