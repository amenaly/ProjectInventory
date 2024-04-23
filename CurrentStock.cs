using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectInventory
{
    public partial class CurrentStock : Form
    {

        //Database connection
        SqlConnection con = new SqlConnection(@"Data Source=d0;Initial Catalog=InventoryDB;Integrated Security=True;Encrypt=False");
        //SqlConnection con = new SqlConnection(@"Data Source=BB8\SQLEXPRESS;Initial Catalog=InventoryDB;Integrated Security=True;Encrypt=False");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        int _qty;

        public CurrentStock()
        {
            InitializeComponent();

            LoadStock();
            ProductID();
        }


        public void ProductID()
        { 
            Random rand = new Random();
            IDlabel.Text = rand.Next().ToString();

        }

        public void LoadStock()
        {
            dgvStock.Rows.Clear();
            
                //Open the connection
                con.Open();
                //allow search txt too and calls from Database
                cmd = new SqlCommand("SELECT * FROM Stock WHERE product_name LIKE '%" + SearchtxtBox.Text + "%' " +
                    "OR skew_number LIKE '%" + SearchtxtBox.Text + "%' OR p_desc LIKE '%" + 
                    SearchtxtBox.Text + "%'", con);
                dr = cmd.ExecuteReader();
                int i = 0;

                //Read the data from the database
                while (dr.Read())
                {
                    i++;
                    //Display the stock details in the datagridview
                    dgvStock.Rows.Add(dr["st_product_id"].ToString(), dr["supp_id"].ToString(),
                        dr["skew_number"].ToString(),
                        dr["product_name"].ToString(),
                        dr["p_desc"].ToString(), dr["quantity"].ToString());
                }

                dr.Close();
                con.Close();

            }
           //allow for populating the datagridview in the top panel by selecting the checkmark
        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvStock.Columns[e.ColumnIndex].Name;
            if (colName == "Select")
            {
                IDlabel.Text = dgvStock.Rows[e.RowIndex].Cells[0].Value.ToString();
                SkewNumLabel.Text = dgvStock.Rows[e.RowIndex].Cells[2].Value.ToString();
                pnameselect.Text = dgvStock.Rows[e.RowIndex].Cells[3].Value.ToString();
                ProdDescLabel.Text = dgvStock.Rows[e.RowIndex].Cells[4].Value.ToString();
                //dgvStock.Rows[e.RowIndex].Cells[4].Value.ToString() + " " +
                //dgvStock.Rows[e.RowIndex].Cells[5].Value.ToString();

              _qty = int.TryParse(dgvStock.Rows[e.RowIndex].Cells[6].Value.ToString(), out _qty) ? _qty : 0;
                

            }
        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void usernamelabel_Click(object sender, EventArgs e)
        {
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardMenu dashboard = new DashboardMenu();
            dashboard.Show();
        }
        //search function
        private void SearchtxtBox_TextChanged(object sender, EventArgs e)
        {
            LoadStock();
        }

        public void Clear()
        {
            IDlabel.Text = "";
            ProdDescLabel.Text = "";

            SkewNumLabel.Text = "";

          
            ProductID();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderForm addstock = new OrderForm();
            addstock.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IDlabel_Click(object sender, EventArgs e)
        {

        }

        private void productidlabel_Click(object sender, EventArgs e)
        {

        }

        private void SkewNumLabel_Click(object sender, EventArgs e)
        {

        }

        private void ProdDescLabel_Click(object sender, EventArgs e)
        {

        }
    }
    }


