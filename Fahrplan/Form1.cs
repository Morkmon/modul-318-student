using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;


namespace Fahrplan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var Transport = new Transport();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void suchen_Click(object sender, EventArgs e)
        {

        }

        private void Abfahrtsort_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Abfahrtsort = Convert.ToString(comoBoxAbfahrtsort.Text);
            Transport.GetStations(Abfahrtsort);
            Stations stations = Transport.GetStations(Abfahrtsort);
            comoBoxAbfahrtsort.Items.Clear();
            foreach (Station station in stations.StationList)
            {
                comoBoxAbfahrtsort.Items.Add(station.Name);
            }
        }
    }
}
