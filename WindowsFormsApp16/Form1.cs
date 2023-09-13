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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            airportEntities db = new airportEntities();
            if (usrtxt.Text != string.Empty && passtxt.Text != string.Empty)
            {
                var user = db.adminns.Where(a=> a.username.Equals(usrtxt.Text)).SingleOrDefault();
                if (user != null)
                {
                    if (user.passwordd.Equals(passtxt.Text))
                    {
                        MessageBox.Show("Login SucessFully");
                        main main = new main();
                        main.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password");
                    }
                }
                else {
                    MessageBox.Show("Invalid Username");
                }
            }
            else {
                MessageBox.Show("Fill The Form");
            }
        }
        private void main_Load(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 customer = new Form2();
            customer.Show();
        }
    }
}
