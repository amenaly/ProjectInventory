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
        //SqlConnection con = new SqlConnection(@"Data Source=d0;Initial Catalog=InventoryDB;Integrated Security=True;Encrypt=False");
        SqlConnection con = new SqlConnection(@"Data Source=BB8\SQLEXPRESS;Initial Catalog=InventoryDB;Integrated Security=True;Encrypt=False");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        //int _qty;

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
                    dr["product_name"].ToString(),dr["p_description"].ToString(), dr["skew_number"].ToString(), dr["supplier_name"].ToString(),
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
        ////allow for populating the datagridview in the top panel by selecting the checkmark
        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvPending.Columns[e.ColumnIndex].Name;
            if (colName == "Select")
            {
                IDlabel.Text = dgvPending.Rows[e.RowIndex].Cells[0].Value.ToString();
                supplierinsertlabel.Text = dgvPending.Rows[e.RowIndex].Cells[4].Value.ToString();
                qtyinsertlabel.Text = dgvPending.Rows[e.RowIndex].Cells[5].Value.ToString();
                amtinsertlabel.Text = dgvPending.Rows[e.RowIndex].Cells[6].Value.ToString();
                RDateLabel.Text = dgvPending.Rows[e.RowIndex].Cells[7].Value.ToString();


                //_qty = int.TryParse(dgvPending.Rows[e.RowIndex].Cells[6].Value.ToString(), out _qty) ? _qty : 0;
            }
           
        }
    }
}
