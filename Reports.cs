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
    public partial class Reports : Form
    {
        //Database connection
        SqlConnection con = new SqlConnection(@"Data Source=d0;Initial Catalog=InventoryDB;Integrated Security=True;Encrypt=False");
        //SqlConnection con = new SqlConnection(@"Data Source=BB8\SQLEXPRESS;Initial Catalog=InventoryDB;Integrated Security=True;Encrypt=False");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public Reports()
        {
            InitializeComponent();
            LoadOrdersReports();
        }

        public void LoadOrdersReports()
        {
               dgvReports.Rows.Clear();
                //Open the connection
                con.Open();
                cmd = new SqlCommand("SELECT * FROM FinalOrders" , con);
                dr = cmd.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    i++;
                    //Display the order details in the datagridview
                    dgvReports.Rows.Add(dr["oid"].ToString(), dr["pname"].ToString(), dr["supplier"].ToString(), dr["skew"].ToString(),
                        dr["qty"].ToString(), dr["amt_purchased"].ToString(),
                        dr["requisition_date"].ToString(), dr["approval_date"].ToString());
                }
                dr.Close();
                con.Close();
            
        }

        private void dgvReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //this is where selections to the database display will go 

        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            //open up the print class
            PrintPreview printPreview = new PrintPreview();
            if (dgvReports.Rows.Count > 0)
            {
                printPreview.LoadPrint("SELECT * FROM FinalOrders");

            }
            printPreview.Show();


        }
    }
}
