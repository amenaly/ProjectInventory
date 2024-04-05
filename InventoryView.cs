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
    
    public partial class StockTable : Form
    {
        //Database connection
        SqlConnection con = new SqlConnection(@"Data Source=d0;Initial Catalog=InventoryDB;Integrated Security=True;Encrypt=False");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public StockTable()
        {
            InitializeComponent();
            LoadStock();
        }
        public void LoadStock()
        {
            dgvStock.Rows.Clear();
            try
            {
                //Open the connection
                con.Open();
                cmd = new SqlCommand("SELECT * FROM Stock", con);
                dr = cmd.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    i++;
                    //Display the stock details in the datagridview
                    dgvStock.Rows.Add(dr["st_product_id"].ToString(), dr["supp_id"].ToString(), dr["skew_number"].ToString(),
                        dr["product_name"].ToString(), dr["p_desc"].ToString(), dr["quantity"].ToString());
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

        private void button1_Click(object sender, EventArgs e)
        {
            //CLEAR OUT Text Fields 
            //skutxtbox.Text = "";
            //orderidtxtbox.Text = "";
           // nametxtbox.Text = "";
           // pricetxtbox.Text = "";
           // qtytxtbox.Text = "";
           // CategoryBox.SelectedIndex = -1; //clears the drop down

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SupplierButton_Click(object sender, EventArgs e)
        {

        }

        private void ProductName_Click(object sender, EventArgs e)
        {

        }

        private void InventoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // Whenever the function loads, whatever below in the function will be executed
        private void InventoryTable_Load(object sender, EventArgs e)
        {
            //fit to screen
            Rectangle resolutionRect = System.Windows.Forms.Screen.FromControl(this).Bounds;
            if (this.Width >= resolutionRect.Width || this.Height >= resolutionRect.Height)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        
        // Set the data source to the Inventory table
        //InventoryGridView.Columns.Add("SKU");
        // InventoryGridView.Columns.Add("Order ID");
        // InventoryGridView.Columns.Add("Name");
        //InventoryGridView.Columns.Add("Price");
        // InventoryGridView.Columns.Add("Category"); //this will be a drop down
        // InventoryGridView.Columns.Add("QTY");

        //point to data source 
    }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Save to Daabase !

        }

        private void TitleMessage_Click(object sender, EventArgs e)
        {

        }

        private void skutxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardMenu dashboard = new DashboardMenu();
            dashboard.Show();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //this will be used to search whole inventory table tied to DB 
        }

        private void Add_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderForm order = new OrderForm();
            order.Show();
        }

        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BottomLabel_Click(object sender, EventArgs e)
        {

        }

        private void savebutton_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Searchtxt_Enter(object sender, EventArgs e)
        {
            //Search function goes here!!!
        }

        private void dgvStock_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
