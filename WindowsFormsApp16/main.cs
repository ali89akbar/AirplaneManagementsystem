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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void addNewTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ticket_reservation ticket = new ticket_reservation();
            ticket.MdiParent = this;
            ticket.Show();
        }

        private void addNewFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flight_detail flight = new flight_detail();
            flight.MdiParent = this;
            flight.Show();
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 customer = new Form2();
            customer.MdiParent = this;
            customer.Show();
        }

        private void searchCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search_customer search = new search_customer();
            search.MdiParent = this;
            search.Show();
        }

        private void sortCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sorting sort = new sorting();
            sort.MdiParent = this;
            sort.Show();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fl = new Form1();
            fl.Show();
           
        }

        private void searchFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Flight fs = new Search_Flight();
            fs.MdiParent = this;
            fs.Show();
        }

        private void sortFlightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Flight_Sort fsort = new Flight_Sort();
            fsort.MdiParent = this;
            fsort.Show();
        }

        private void lagyageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            laguage Item = new laguage();
            Item.MdiParent = this;
            Item.Show();
        }

        private void kruskalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kruskalAlgo ass = new kruskalAlgo();
            ass.MdiParent = this;
            ass.Show();
        }

        private void djikstraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            djikstra dj = new djikstra();
            dj.MdiParent = this;
            dj.Show();
        }
    }
}
