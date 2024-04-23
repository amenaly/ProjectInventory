using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectInventory
{
    public partial class HomeUpdate : Form
    {
        //Database connection
        SqlConnection con = new SqlConnection(@"Data Source=d0;Initial Catalog=InventoryDB;Integrated Security=True;Encrypt=False");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public HomeUpdate()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void HomeUpdate_Load(object sender, EventArgs e)
        {
            // fill out the boxes in homeupdate
            con.Open();
            cmd = new SqlCommand ("SELECT COUNT(*) FROM PendingOrders", con); /// count the number of pending orders
            
            
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                orderrequeststext.Text = dr[0].ToString();
                
            }
            dr.Close();
            cmd = new SqlCommand("SELECT COUNT(*) FROM Stock", con); /// count the number of stock
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                totalstocktext.Text = dr[0].ToString();
            }
            dr.Close();
            cmd = new SqlCommand("SELECT COUNT(*) FROM FinalOrders", con); /// count the number of approved orders
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                approvetext.Text = dr[0].ToString();
            }
            dr.Close();
            cmd = new SqlCommand("SELECT ISNULL(SUM(amt_purchased), 0) FROM FinalOrders", con); /// count the total $ amount of approved orders
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                decimal total = Convert.ToDecimal(dr[0]);
                totalpurchaselabel.Text = total.ToString("0.00");
            }
            dr.Close();
            con.Close();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
