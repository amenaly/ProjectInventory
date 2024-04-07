using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectInventory
{
    public partial class Supplier : Form
    {
        //Database connection
        SqlConnection con = new SqlConnection(@"Data Source=BB8\SQLEXPRESS;Initial Catalog=InventoryDB;Integrated Security=True;Encrypt=False");
        //SqlConnection con = new SqlConnection(@"Data Source=d0;Initial Catalog=InventoryDB;Integrated Security=True;Encrypt=False");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public Supplier()
        {
            InitializeComponent();
           LoadSupplier();

        }
        public void LoadSupplier()
        {
            dgvSupplier.Rows.Clear();
            try
            {
                //Open the connection
                con.Open();
                cmd = new SqlCommand("SELECT * FROM Suppliers WHERE supplier_name LIKE '%" + SearchtxtBox.Text + "%' OR skew LIKE '%" + SearchtxtBox.Text + "%' OR unit_price LIKE '%" + SearchtxtBox.Text + "%' OR supplier_phone LIKE '%" 
                    + SearchtxtBox.Text + "%' OR supplier_zip LIKE '%" + SearchtxtBox.Text + "%'", con);
                dr = cmd.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    i++;
                    //Display the supplier details in the datagridview
                    dgvSupplier.Rows.Add(dr["avail_qty"].ToString(),dr["supplier_name"].ToString(), dr["skew"].ToString(), 
                        dr["unit_price"].ToString(), dr["supplier_phone"].ToString(), dr["supplier_zip"].ToString());
                    
                }
                dr.Close();

            }
            //Catch any errors
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            }
        
        private void dgvSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardMenu dashboard = new DashboardMenu();
            dashboard.Show();
        }

        private void SearchtxtBox_TextChanged(object sender, EventArgs e)
        {
            LoadSupplier();
        }
    }
}
