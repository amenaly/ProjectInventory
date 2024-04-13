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
    public partial class ApproveForm : Form
    {
        //Database connection
        SqlConnection con = new SqlConnection(@"Data Source=d0;Initial Catalog=InventoryDB;Integrated Security=True;Encrypt=False");
        //SqlConnection con = new SqlConnection(@"Data Source=BB8\SQLEXPRESS;Initial Catalog=InventoryDB;Integrated Security=True;Encrypt=False");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        

        public ApproveForm()
        {
            InitializeComponent();
            LoadPendingOrders();

        }
        public void Clear()
        {
            IDlabel.Text = "";
            supplierinsertlabel.Text = "";
            qtyinsertlabel.Text = "";
            amtinsertlabel.Text = "";
        }
        public void LoadPendingOrders()
        {
            //where the clear rows will go 
            dgvPending.Rows.Clear();
            //Open the connection
            con.Open();
            //allow search txt too and calls from Database
            cmd = new SqlCommand("SELECT * FROM PendingOrders", con);
            dr = cmd.ExecuteReader();
            int i = 0;

            while (dr.Read())
            {
                i++;
                //Display the stock details in the datagridview
                dgvPending.Rows.Add(dr["order_id"].ToString(),
                    dr["product_name"].ToString(), dr["p_description"].ToString(), dr["skew_number"].ToString(), dr["supplier_name"].ToString(),
                    dr["qty"].ToString(), dr["amount_purchased"].ToString(), dr["requisition_date"].ToString());
            }
            dr.Close();
            con.Close();
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

        private void ApproveForm_Load(object sender, EventArgs e)
        {

        }

        private void PendingOrderButton_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void ApproveButton_Click(object sender, EventArgs e)
        {

        }
        //////allow for populating the datagridview in the top panel by selecting the checkmark
        private void dgvPending_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if the select button is clicked
            string colName = dgvPending.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                //delete the selected row
                if (MessageBox.Show("Are you sure you want to delete this PendingOrder?", "Delete PendingOrder", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM PendingOrders WHERE order_id = @order_id", con);
                    cmd.Parameters.AddWithValue("@order_id", dgvPending.Rows[e.RowIndex].Cells[0].Value);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("PendingOrder has been successfully deleted.", "Delete PendingOrder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (colName == "Approve")
            {
                if (MessageBox.Show("Are you sure you want to approve this PendingOrder?", "Approve PendingOrder", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO FinalOrders (oid, pname, supplier, skew, qty, amt_purchased, requisition_date, approval_date)" +
                        " VALUES (@oid, @pname, @supplier, @skew, @qty, @amt_purchased, @requisition_date, @approval_date)", con);
                    cmd.Parameters.AddWithValue("@oid", dgvPending.Rows[e.RowIndex].Cells[0].Value);
                    cmd.Parameters.AddWithValue("@pname", dgvPending.Rows[e.RowIndex].Cells[1].Value);
                    cmd.Parameters.AddWithValue("@supplier", dgvPending.Rows[e.RowIndex].Cells[4].Value);
                    cmd.Parameters.AddWithValue("@skew", dgvPending.Rows[e.RowIndex].Cells[3].Value);
                    cmd.Parameters.AddWithValue("@qty", dgvPending.Rows[e.RowIndex].Cells[5].Value);
                    cmd.Parameters.AddWithValue("@amt_purchased", dgvPending.Rows[e.RowIndex].Cells[6].Value);
                    cmd.Parameters.AddWithValue("@requisition_date", dgvPending.Rows[e.RowIndex].Cells[7].Value);
                    cmd.Parameters.AddWithValue("@approval_date", ApprovalPicker.Value);
                    cmd.ExecuteNonQuery();

                    //delete the selected row
                    cmd = new SqlCommand("DELETE FROM PendingOrders WHERE order_id = @order_id", con);
                    cmd.Parameters.AddWithValue("@order_id", dgvPending.Rows[e.RowIndex].Cells[0].Value);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("PendingOrder has been successfully approved.", "Approve PendingOrder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (colName == "Select")
            {
                IDlabel.Text = dgvPending.Rows[e.RowIndex].Cells[0].Value.ToString();
                supplierinsertlabel.Text = dgvPending.Rows[e.RowIndex].Cells[4].Value.ToString();
                qtyinsertlabel.Text = dgvPending.Rows[e.RowIndex].Cells[5].Value.ToString();
                amtinsertlabel.Text = dgvPending.Rows[e.RowIndex].Cells[6].Value.ToString();
                RDateLabel.Text = dgvPending.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            //if the edit button is clicked
            else if (colName == "Edit")
            {
                OrderForm orderForm = new OrderForm();
                //pass the data to the order form to be edited 
                orderForm.OrderIDRanLabel.Text = dgvPending.Rows[e.RowIndex].Cells[0].Value.ToString();
                orderForm.Productbox.Text = dgvPending.Rows[e.RowIndex].Cells[1].Value.ToString();
                orderForm.Descriptionbox.Text = dgvPending.Rows[e.RowIndex].Cells[2].Value.ToString();
                orderForm.Supplierbox.Text = dgvPending.Rows[e.RowIndex].Cells[4].Value.ToString();
                orderForm.skewdroplabel.Text = dgvPending.Rows[e.RowIndex].Cells[3].Value.ToString();
                orderForm.qtynumchoice.Value = Convert.ToInt32(dgvPending.Rows[e.RowIndex].Cells[5].Value);
                orderForm.amounttxtbox.Text = dgvPending.Rows[e.RowIndex].Cells[6].Value.ToString();
                orderForm.dateTimePicker1.Value = Convert.ToDateTime(dgvPending.Rows[e.RowIndex].Cells[7].Value);
                orderForm.Show();
            }
            //load with update 
            LoadPendingOrders();
            
        }


        private void ApproveButton_Click_1(object sender, EventArgs e)
        {
           
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
