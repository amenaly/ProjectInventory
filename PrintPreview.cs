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
using Microsoft.Reporting.WinForms;

namespace ProjectInventory
{
    public partial class PrintPreview : Form
    {
        //Database connection
        SqlConnection con = new SqlConnection(@"Data Source=d0;Initial Catalog=InventoryDB;Integrated Security=True;Encrypt=False");
        //SqlConnection con = new SqlConnection(@"Data Source=BB8\SQLEXPRESS;Initial Catalog=InventoryDB;Integrated Security=True;Encrypt=False");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        
        public PrintPreview()
        {
            InitializeComponent();

        }

        public string LoadEmployee(string username)
        {
            LogForm logForm = new LogForm();
            string employee = ""; // Initialize to empty string
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM [User]", con);
                cmd.Parameters.AddWithValue("@username", logForm.usernametxtbox.Text);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    employee = dr["username"].ToString();

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                // Ensure connection is closed even in case of exceptions
            }
            return employee;
        }
    

        private void BottomLabel_Click(object sender, EventArgs e)
        {

        }

        private void PrintPreview_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
        public void LoadPrint(string sql)
        {
            try
            {
                ReportDataSource rptDataSource;
                this.reportViewer1.LocalReport.ReportPath = @"Reports\OrdersReport.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                InventoryDBDataSet ds = new InventoryDBDataSet();
                SqlDataAdapter da = new SqlDataAdapter();

                con.Open();
                da.SelectCommand = new SqlCommand(sql, con);
                da.Fill(ds, "FinalOrders");
                con.Close();

                //assign the parameters to the report
                ReportParameter pFactory = new ReportParameter("pFactory", "St. Mary's Factory");
                ReportParameter pEmployee = new ReportParameter("pEmployee", sql);
                ReportParameter pOrderId = new ReportParameter("pOrderId", "test");
                ReportParameter pUnitPrice = new ReportParameter("pUnitPrice", "test");

            
                reportViewer1.LocalReport.SetParameters(new ReportParameter[] { pFactory, pEmployee, pOrderId, pUnitPrice});

                rptDataSource = new ReportDataSource("DataSet1", ds.Tables["FinalOrders"]);
                reportViewer1.LocalReport.DataSources.Add(rptDataSource);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 30;

            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }
       

        private void PrintPreview_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
           
        }

        private void bottompanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
