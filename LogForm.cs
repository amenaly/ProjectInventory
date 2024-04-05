using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjectInventory
{
    public partial class LogForm : Form
    {
        //Database connection
        SqlConnection con = new SqlConnection(@"Data Source=d0;Initial Catalog=InventoryDB;Integrated Security=True;Encrypt=False");
        SqlDataReader dr;


        public LogForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernametxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //show message to close out the program 
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit(); //close out the program
            }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //clear out fields 
            usernametxtbox.Clear();
            Passtxtbox.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool isValid()
        {
            if (usernametxtbox.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Username is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Passtxtbox.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Password is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                //Database connection
                bool found;
                string _username = "", _name = "", _role = "";
                string _pass = "";
                try
                {

                    con.Open();
                    string query = "SELECT * FROM [User] WHERE Username = @username AND Password = @password";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Username", usernametxtbox.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", Passtxtbox.Text.Trim());
                    dr = cmd.ExecuteReader();
                    dr.Read();

                    if (dr.HasRows)
                    {
                        found = true;
                        _username = dr["username"].ToString();
                        _name = dr["name"].ToString();
                        _role = dr["role"].ToString();
                        _pass = dr["password"].ToString();
                    }
                    else
                    {
                        found = false;
                        MessageBox.Show("Invalid Log in, Try again", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dr.Close();
                    con.Close();
                    if (found)
                    {

                        if (_role == "Sales")
                        {
                            MessageBox.Show("Welcome " + _name + "!", "Login Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            usernametxtbox.Clear();
                            Passtxtbox.Clear();
                            this.Hide();
                            DashboardMenu dash = new DashboardMenu();
                            dash.usernamelabel.Text = _username;
                            dash.NameLabel.Text = _name + " | " + _role;
                            dash.ShowDialog();
                        }
                        if(_role == "Administrator")
                        {
                            MessageBox.Show("Welcome " + _name + "!", "Login Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            usernametxtbox.Clear();
                            Passtxtbox.Clear();
                            this.Hide();
                            DashboardMenu dash = new DashboardMenu();
                            dash.usernamelabel.Text = _username;
                            dash.NameLabel.Text = _name + " | " + _role;
                            dash.ShowDialog();
                        }

                        else
                        {
                            MessageBox.Show("Welcome" + _name + "!", "Login Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            usernametxtbox.Clear();
                            Passtxtbox.Clear();
                            this.Hide();
                            DashboardMenu dash = new DashboardMenu();
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                //MessageBox.Show("Login Successful", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //usernametxtbox.Clear();
                //Passtxtbox.Clear();
                // this.Hide();
                //DashboardMenu dash = new DashboardMenu();
                //dash.usernamelabel.Text = usernametxtbox.Text;
                //dash.Show();

            }


        }
        private void LogForm_Load(object sender, EventArgs e)
        {

        }
    }
}

