using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public partial class flight_detail : Form
    {
        airportEntities db;
        public flight_detail()
        {
            InitializeComponent();
            db = new airportEntities();
        }

        private void sourcetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Add_Flight_Click(object sender, EventArgs e)
        {
            flight_details fd = new flight_details();
            fd.flight_name = flightnametxt.Text;
            fd.sources = sourcetxt.Text;
            fd.destination = destinationtxt.Text;
            fd.arrival_item = arrivaltxt.Text;
            fd.departure = departuretxt.Text;
            fd.flight_class = classtxt.Text;
            fd.flight_charges = Decimal.Parse(chargetxt.Text);
            fd.seats = int.Parse(seatstxt.Text);
            db.flight_details.Add(fd);
            db.SaveChanges();
            MessageBox.Show("Flight Added");

        }
    }
}
