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
    public partial class Flight_Sort : Form
    {
        public Flight_Sort()
        {
            InitializeComponent();
        }

        private void Flight_Sort_Load(object sender, EventArgs e)
        {
            airportEntities db = new airportEntities();
            var items = db.flight_details.ToList();
            dataGridView1.DataSource = items;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            List<flight_details> flights = dataGridView1.DataSource as List<flight_details>;
            if (flights == null || flights.Count == 0)
            {
                MessageBox.Show("No flights found.");
                return;
            }

            for (int i = 0; i < flights.Count - 1; i++)
            {
                for (int j = 0; j < flights.Count - i - 1; j++)
                {
                    if (flights[j].flight_name.CompareTo(flights[j + 1].flight_name) > 0)
                    {
                        flight_details temp = flights[j];
                        flights[j] = flights[j + 1];
                        flights[j + 1] = temp;
                    }
                }
            }
            dataGridView1.DataSource = flights;
            dataGridView1.Columns.Add("flight_name", "flight_name");
            dataGridView1.Columns.Add("sources", "sources");
            dataGridView1.Columns.Add("destination", "destination");

        }
    }
}
