using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectInventory
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {

        }

        private void OrderLabel_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void OrderTitle_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardMenu dashboard = new DashboardMenu();
            dashboard.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //calculate the amount automatically 
        private void Calculate()
        {
            double qty = 0;
            double price = 0;
            double amt = 0;

            double.TryParse(qtytxtbox.Text, out qty);
            double.TryParse(UPbox.Text, out price);
            
            amt = qty * price;
            amountxtbox.Text = amt.ToString();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void productbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
