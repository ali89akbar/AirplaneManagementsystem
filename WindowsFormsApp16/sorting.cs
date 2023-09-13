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
    public partial class sorting : Form
    {
        public sorting()
        {
            InitializeComponent();
        }

        private void sorting_Load(object sender, EventArgs e)
        {
            airportEntities db = new airportEntities();
            var items = db.customer_details.ToList();
            dataGridView1.DataSource = items;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<customer_details> customerDetails = new List<customer_details>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    customer_details customer = new customer_details();
                    customer.namee = row.Cells[1].Value != null ? row.Cells[1].Value.ToString() : "";
                    customer.fathername = row.Cells[2].Value != null ? row.Cells[2].Value.ToString() : "";
                    customer.address = row.Cells[6].Value != null ? row.Cells[6].Value.ToString() : "";
                    customerDetails.Add(customer);
                }
            }

            // Sort the customer details using insertion sort
            for (int i = 1; i < customerDetails.Count; i++)
            {
                customer_details temp = customerDetails[i];
                int j = i - 1;
                while (j >= 0 && customerDetails[j].namee.CompareTo(temp.namee) > 0)
                {
                    customerDetails[j + 1] = customerDetails[j];
                    j--;
                }
                customerDetails[j + 1] = temp;
            }

            // Clear the rows in the DataGridView
            dataGridView1.DataSource=null;

            // Add the sorted customer details to the DataGridView
            // Define the columns
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("FatherName", "Father Name");
            dataGridView1.Columns.Add("Address", "Address");

            // Add the rows
            foreach (customer_details customer in customerDetails)
            {
                dataGridView1.Rows.Add(customer.namee, customer.fathername, customer.address);
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }


