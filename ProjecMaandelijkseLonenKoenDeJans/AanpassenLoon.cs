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
    public partial class AanpassenLoon : Form
    {
        Werknemer geselWerknemer;
        public AanpassenLoon(Werknemer geselecteerdeWerknemer)
        {
            // Geselecteerde werknemer gelijkzetten aan bovenaan gedeclareerde werknemer.
            InitializeComponent();
            geselWerknemer = geselecteerdeWerknemer;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void AanpassenLoon_Load(object sender, EventArgs e)
        {
            // Textbox vullen met startloon van de geselecteerde medewerker.
            tbBasisloon.Text = geselWerknemer.Loon.BerekenStartLoon().ToString();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            // Kijken of nieuwe input cijfers zijn, error gooien indien dit niet het geval is.
            if (Double.TryParse(tbBasisloon.Text, out double nieuwloon))
            {
                // Door de "Database" werknemerlijst in hoofdform itereren.
                foreach (Werknemer item in Form1.werknemersLijst)
                {
                    // Kijken of geselecteerde medewerker overeenkomt met een medewerker in de lijst.
                    if (item == geselWerknemer)
                    {
                        // Startloon aanpassen, oude werknemer verwijderen en nieuwe toevoegen.
                        geselWerknemer.Loon.StartLoon = nieuwloon;
                        Form1.werknemersLijst.Remove(item);
                        Form1.werknemersLijst.Add(geselWerknemer);
                        Close();
                        break;
                    }
                }
            }

            else
            {
                MessageBox.Show("Gelieve enkel cijfers in te geven.");
            }
        }
    }
}
