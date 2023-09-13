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
    public partial class Search_Flight : Form
    {
      

        public Search_Flight()
        {
            InitializeComponent();
        }

        private void Search_Flight_Load(object sender, EventArgs e)
        {
            airportEntities db = new airportEntities();
            var items = db.flight_details.ToList();
            dataGridView5.DataSource = items;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            airportEntities db = new airportEntities();
            int id;


            if (int.TryParse(searchtxt.Text, out id))
            {
                var items = db.customer_details.Where(a => a.id == id).ToList();
                if (items != null)
                {
                    dataGridView5.DataSource = items;
                }
                else
                {

                    MessageBox.Show("Please enter a valid ID.");
                }
            }
        }
 


        private void button1_Click(object sender, EventArgs e)
        {
            string searchText = searchtxt.Text;
            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Please enter a valid Flight Name.");
                return;
            }

            List<flight_details> result = LinearSearch(searchText);

            List<flight_details> searchResult = new List<flight_details>();
            foreach (flight_details flight in result)
            {
                if (flight.flight_name.ToLower().Contains(searchText.ToLower()))
                {
                    searchResult.Add(flight);
                }
            }
            if (searchResult.Count == 0)
            {
                MessageBox.Show("Flight not found.");
            }
            else
            {
                dataGridView5.DataSource = searchResult;
            }
       
        }
        //LINEAR SEARCH
        public List<flight_details> LinearSearch(string flightName)
        {
            List<flight_details> result = new List<flight_details>();

            foreach (DataGridViewRow row in dataGridView5.Rows)
            {
                if (row.Cells[1].Value.ToString().ToLower().Contains(flightName.ToLower()))
                {
                    result.Add(new flight_details
                    {
                        fid = (int)row.Cells[0].Value,
                        flight_name = (string)row.Cells[1].Value,
                        sources = (string)row.Cells[2].Value,
                        destination = (string)row.Cells[3].Value,
                        arrival_item = (string)row.Cells[4].Value,
                        departure = (string)row.Cells[5].Value,
                        flight_class = (string)row.Cells[6].Value
                    });
                }
            }

            return result;
        }


    }
}
