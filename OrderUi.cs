using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectInventory
{
    public partial class OrderForm : Form
    {
        //define a list 
        //private List<Product> pendingProducts = new List<Product>();
        //Database connection
        SqlConnection con = new SqlConnection(@"Data Source=d0;Initial Catalog=InventoryDB;Integrated Security=True;Encrypt=False");
        //SqlConnection con = new SqlConnection(@"Data Source=BB8\SQLEXPRESS;Initial Catalog=InventoryDB;Integrated Security=True;Encrypt=False");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public OrderForm()
        {
            InitializeComponent();
            LoadSupplier();
            //LoadProduct();
            OrderID();
            Calculate();
        }

        //Generate random Order ID 
        public void OrderID()
        {
            Random rand = new Random();
            OrderIDRanLabel.Text = rand.Next().ToString();
        }

        //Load Supplier drop down 
        public void LoadSupplier()
            {
            //clear out the supplier box
                Supplierbox.Items.Clear();
                con.Open();
                cmd = new SqlCommand("SELECT * FROM Suppliers", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
            {
                Supplierbox.Items.Add(dr["supplier_name"].ToString());
                }
                con.Close();
            }
        //prepoulate unit price with supplier 
        private void Supplierbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSupplier = Supplierbox.Text;
            PopulateBoxes(selectedSupplier);
        }
        private void PopulateBoxes(string selectedSupplier)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM Suppliers WHERE supplier_name = @supplier_name", con);
                cmd.Parameters.AddWithValue("@supplier_name", selectedSupplier);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    UPbox.Text = dr["unit_price"].ToString();
                    skewdroplabel.Text = dr["skew"].ToString();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        //Load Product drop down
        //public void LoadProduct()
        //{
            //clear out the product box
            //productbox.Items.Clear();
            //con.Open();
            //cmd = new SqlCommand("SELECT * FROM Stock", con);
            //dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
                //productbox.Items.Add(dr["product_name"].ToString());
            //}
            //con.Close();
        //}

       private void AddtoPending()
        {
            
           try
            {
                if (MessageBox.Show("Submit new Order Request?", "Add Order?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO PendingOrders (order_id,product_name,p_description,supplier_name,skew_number,qty,amount_purchased, " +
                        "requisition_date) VALUES" + "(@order_id,@product_name,@p_description,@supplier_name,@skew_number,@qty,@amount_purchased,@requisition_date)", con);
                    cmd.Parameters.AddWithValue("@order_id", OrderIDRanLabel.Text);
                    cmd.Parameters.AddWithValue("@product_name", Productbox.Text);
                    cmd.Parameters.AddWithValue("@p_description", Descriptionbox.Text);
                    cmd.Parameters.AddWithValue("@supplier_name", Supplierbox.Text);
                    cmd.Parameters.AddWithValue("@skew_number", skewdroplabel.Text);
                    cmd.Parameters.AddWithValue("@qty", qtynumchoice.Value);
                    cmd.Parameters.AddWithValue("@amount_purchased", amounttxtbox.Text);
                    cmd.Parameters.AddWithValue("@requisition_date", dateTimePicker1.Value);

                    cmd.ExecuteNonQuery();
                    con.Close(); 
                    MessageBox.Show("Order Request Submmited for Admin Approval Successfully", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

}
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void Addbutton_Click(object sender, EventArgs e)
        {
            AddtoPending();
            Clear();
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
            //double qty = Convert.ToDouble(qtynumchoice.Value); 
            // Assuming you're using NumericUpDown for quantity
            //double price = Convert.ToDouble(UPbox.Text);
            //double amt = qty * price;
            //amounttxtbox.Text = amt.ToString();

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void productbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            Productbox.Text = "";
            amounttxtbox.Clear();
            UPbox.Clear();
            skewdroplabel.Text = "";
            Supplierbox.Text = "";
            qtynumchoice.Value = 0;
            dateTimePicker1.Value = DateTime.Now;
            Descriptionbox.Text = "";
            OrderID();
        }
       

        private void PendingOrderButton_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            Clear();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void skewdroplabel_Click(object sender, EventArgs e)
        {

        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            //after approve form request to make an edit, this saves the changes to the database
            try
            {
                con.Open();
                cmd = new SqlCommand("UPDATE PendingOrders SET product_name = @product_name, p_description = @p_description, supplier_name = @supplier_name, skew_number = @skew_number, qty = @qty, amount_purchased = @amount_purchased, requisition_date = @requisition_date WHERE order_id = @order_id", con);
                cmd.Parameters.AddWithValue("@order_id", OrderIDRanLabel.Text);
                cmd.Parameters.AddWithValue("@product_name", Productbox.Text);
                cmd.Parameters.AddWithValue("@p_description", Descriptionbox.Text);
                cmd.Parameters.AddWithValue("@supplier_name", Supplierbox.Text);
                cmd.Parameters.AddWithValue("@skew_number", skewdroplabel.Text);
                cmd.Parameters.AddWithValue("@qty", qtynumchoice.Value);
                cmd.Parameters.AddWithValue("@amount_purchased", amounttxtbox.Text);
                cmd.Parameters.AddWithValue("@requisition_date", dateTimePicker1.Value);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Order Request Updated Successfully", "Edit Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            this.Dispose(); //to close after update
        }
    }
}
