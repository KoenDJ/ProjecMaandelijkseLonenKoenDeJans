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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Werknemer> werknemersLijst = new List<Werknemer>();
        private void Form1_Load(object sender, EventArgs e)
        {
            Werknemer Koen = new Werknemer("Koen", "man", "18/07/1976", "760718-874.24", "12/03/2010", "Be 125484474866");

            cbWerknemers.DataSource = werknemersLijst;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbWerknemers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void gbWerknemerGegevens_Enter(object sender, EventArgs e)
        {

        }

        private void btnWerkNemerAanpassen_Click(object sender, EventArgs e)
        {

        }

        private void btnVerwijderenWerknemer_Click(object sender, EventArgs e)
        {

        }

        private void btnLoonbriefAanmaken_Click(object sender, EventArgs e)
        {

        }

        private void btnWerknemerAanmaken_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblGeslacht_Click(object sender, EventArgs e)
        {

        }
    }
}
