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
    public partial class Form2 : Form
    {

     
        public Form2()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            airportEntities db = new airportEntities();
            customer_details customers = new customer_details
            {
                namee = nametxt.Text,
                fathername = fathertxt.Text,
                birthdate = birthdate.Value,
                email = emailtxt.Text,
                phone = phonetxt.Text,
                address = addresstxt.Text
            };
            db.customer_details.Add(customers);
            db.SaveChanges();
            MessageBox.Show("Add One Customer");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
