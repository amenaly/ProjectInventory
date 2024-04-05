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
    public partial class ApproveForm : Form
    {
        public ApproveForm()
        {
            InitializeComponent();
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
    }
}
