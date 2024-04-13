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
    public partial class DashboardMenu : Form
    {
        public string username { get { return usernamelabel.Text; } }
        public DashboardMenu()
        {
            InitializeComponent();
            customizeDesign();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ParentPanel.Controls.Add(childForm);
            ParentPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void customizeDesign()
        {
           ProductsPanel.Visible = false;
           CurrentPanel.Visible = false;
        }

        private void hideSubMenu()
        {
            if (ProductsPanel.Visible == true)
                ProductsPanel.Visible = false;
            if (CurrentPanel.Visible == true)
                CurrentPanel.Visible = false;
        }
        private void showSubMenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LogOnPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {

        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            showSubMenu(ProductsPanel);
        }

        private void Skewbutton_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void SupplierButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Supplier());
            hideSubMenu();
        }

        private void CurrentButton_Click(object sender, EventArgs e)
        {
            showSubMenu(CurrentPanel);
           
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            openChildForm(new OrderForm());
            hideSubMenu();

        }

        private void PendingButton_Click(object sender, EventArgs e)
        {
            openChildForm(new ApproveForm());
            hideSubMenu();
        }

        private void AvailableButton_Click(object sender, EventArgs e)
        {
            openChildForm(new CurrentStock());
            hideSubMenu();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Reports());
            hideSubMenu();
        }

        private void LogOffButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                LogForm login = new LogForm();
                login.Show();
            }
        }

        private void usernamelabel_Click(object sender, EventArgs e)
        {

        }

        private void DashboardMenu_Load(object sender, EventArgs e)
        {

        }

        private void TitleMessage_Click(object sender, EventArgs e)
        {

        }

        private void ParentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TitlePane_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
