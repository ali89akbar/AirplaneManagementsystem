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
    public partial class ticket_reservation : Form
    {

        airportEntities db;
        
        public ticket_reservation()
        {
            InitializeComponent();
            db = new airportEntities();
            BindSource();
            BindDestination();
        }

        private void BindSource()
        {
            var items = db.flight_details.ToList();
            sourcecombo.DataSource = items;
            sourcecombo.DisplayMember = "sources";
        }
        private void BindDestination()
        {

            var items = db.flight_details.ToList();
            destcombo.DataSource = items;
            destcombo.DisplayMember = "destination";
        }
        private void ticket_reservation_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(seattxt.Text) <= 50)
            {
                if (availableseat() == true)
                {
                    booking book = new booking();
                    book.customerid = Convert.ToInt32(custidtxt.Text);
                    book.dateofjourney = dateTimePicker2.Value;
                    book.flightid = Convert.ToInt32(flightidtxt.Text);
                    book.seatno = Convert.ToInt32(seattxt.Text);
                    db.bookings.Add(book);
                    db.SaveChanges();
                    MessageBox.Show("Booked");
                }
                else {
                    MessageBox.Show("Already Booked");
                }
            }
            else {
                MessageBox.Show("Number is greater than 50");
            }
        }

        private bool availableseat()
        {
            string dateofjourney = dateTimePicker2.Value.ToString();
            int flightid = Convert.ToInt32(flightidtxt.Text);
            int seatno = Convert.ToInt32(seattxt.Text);
            var item = db.bookings.Where(a=>a.flightid == flightid && a.seatno == seatno).FirstOrDefault();
            if (item != null)
            {
                string currentdate = (dateTimePicker2.Value.ToString("dd/mm/yyyy"));
                if (currentdate == dateofjourney)
                {
                    return false;

                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sourcecombo.Text != destcombo.Text)
            {
                dataGridView1.DataSource = db.flight_details.Where(a => a.sources.Equals(sourcecombo.Text) && a.destination.Equals(destcombo.Text)).ToList();
            }
        }

 


        private void button3_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(custidtxt.Text);
            var items = db.customer_details.Where(a => a.id == ID).FirstOrDefault();
            custnametxt.Text = items.namee;
            fathertxt.Text = items.fathername;
            dateTimePicker1.Value = (DateTime)items.birthdate;
            mailtxt.Text = items.email;
            notxt.Text = items.phone;
            addresstxt.Text = items.address;



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var flightid = dataGridView1.SelectedRows[0].Cells[0].Value;
            flightidtxt.Text = flightid.ToString();

        }
    }
}
