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
    public partial class search_customer : Form
    {
        public search_customer()
        {
            InitializeComponent();
        }

        private void search_customer_Load(object sender, EventArgs e)
        {
            airportEntities db = new airportEntities();
            var items = db.customer_details.ToList();
            dataGridView1.DataSource = items;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            airportEntities db = new airportEntities();
            int id;


            if (int.TryParse(textBox1.Text, out id))
            {
                var items = db.customer_details.Where(a => a.id == id).ToList();
                if (items != null)
                {
                    dataGridView1.DataSource = items;
                }
                else
                {

                    MessageBox.Show("Please enter a valid ID.");
                }
            }
   
        }

        private List<customer_details> BinarySearchCustomers(int customerId)
        {
            int left = 0;
            int right = dataGridView1.Rows.Count - 1;
            List<customer_details> result = new List<customer_details>();

            while (left <= right)
            {
                int middle = (left + right) / 2;
                if ((int)dataGridView1.Rows[middle].Cells["id"].Value == customerId)
                {
                    result.Add(new customer_details
                    {
                        id = (int)dataGridView1.Rows[middle].Cells["id"].Value,
                        namee = (string)dataGridView1.Rows[middle].Cells["namee"].Value,
                        fathername = (string)dataGridView1.Rows[middle].Cells["fathername"].Value,
                        email = (string)dataGridView1.Rows[middle].Cells["email"].Value,
                        phone = (string)dataGridView1.Rows[middle].Cells["phone"].Value,
                        address = (string)dataGridView1.Rows[middle].Cells["address"].Value
                    });
                    break;
                }
                else if ((int)dataGridView1.Rows[middle].Cells["id"].Value < customerId)
                {
                    left = middle + 1;
                
                }
                else
                {
                    right = middle - 1;
                 
                }
            }

           

            return result;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int customerId = int.Parse(textBox1.Text);
            List<customer_details> searchResult = BinarySearchCustomers(customerId);
           //List<customer_details> searchResults = new List<customer_details>(); 
            if (searchResult.Count == 0)
            {
                MessageBox.Show("Customer not found.");


            }
            else
            {
                dataGridView1.DataSource = searchResult;
              
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id =Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            Form2 c1 = new Form2();
            c1.ShowDialog();
        }
    }
}

