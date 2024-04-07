namespace ProjectInventory
{
    partial class DashboardMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardMenu));
            this.SideMenu = new System.Windows.Forms.Panel();
            this.LogOffButton = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.CurrentPanel = new System.Windows.Forms.Panel();
            this.AvailableButton = new System.Windows.Forms.Button();
            this.PendingButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.CurrentButton = new System.Windows.Forms.Button();
            this.ProductsPanel = new System.Windows.Forms.Panel();
            this.SupplierButton = new System.Windows.Forms.Button();
            this.Skewbutton = new System.Windows.Forms.Button();
            this.ProductButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.LogOnPanel = new System.Windows.Forms.Panel();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.TitlePane = new System.Windows.Forms.Panel();
            this.TitleMessage = new System.Windows.Forms.Label();
            this.ParentPanel = new System.Windows.Forms.Panel();
            this.SideMenu.SuspendLayout();
            this.CurrentPanel.SuspendLayout();
            this.ProductsPanel.SuspendLayout();
            this.LogOnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TitlePane.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideMenu
            // 
            this.SideMenu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.SideMenu.Controls.Add(this.LogOffButton);
            this.SideMenu.Controls.Add(this.ReportButton);
            this.SideMenu.Controls.Add(this.CurrentPanel);
            this.SideMenu.Controls.Add(this.CurrentButton);
            this.SideMenu.Controls.Add(this.ProductsPanel);
            this.SideMenu.Controls.Add(this.ProductButton);
            this.SideMenu.Controls.Add(this.HomeButton);
            this.SideMenu.Controls.Add(this.LogOnPanel);
            this.SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenu.Location = new System.Drawing.Point(0, 0);
            this.SideMenu.Margin = new System.Windows.Forms.Padding(1);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(181, 554);
            this.SideMenu.TabIndex = 0;
            // 
            // LogOffButton
            // 
            this.LogOffButton.BackColor = System.Drawing.Color.IndianRed;
            this.LogOffButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogOffButton.ForeColor = System.Drawing.Color.White;
            this.LogOffButton.Location = new System.Drawing.Point(0, 612);
            this.LogOffButton.Margin = new System.Windows.Forms.Padding(1);
            this.LogOffButton.Name = "LogOffButton";
            this.LogOffButton.Size = new System.Drawing.Size(181, 51);
            this.LogOffButton.TabIndex = 5;
            this.LogOffButton.Text = "Logoff";
            this.LogOffButton.UseVisualStyleBackColor = false;
            this.LogOffButton.Click += new System.EventHandler(this.LogOffButton_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportButton.Image = ((System.Drawing.Image)(resources.GetObject("ReportButton.Image")));
            this.ReportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReportButton.Location = new System.Drawing.Point(0, 561);
            this.ReportButton.Margin = new System.Windows.Forms.Padding(1);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(181, 51);
            this.ReportButton.TabIndex = 4;
            this.ReportButton.Text = "Reports";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // CurrentPanel
            // 
            this.CurrentPanel.Controls.Add(this.AvailableButton);
            this.CurrentPanel.Controls.Add(this.PendingButton);
            this.CurrentPanel.Controls.Add(this.AddButton);
            this.CurrentPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CurrentPanel.Location = new System.Drawing.Point(0, 409);
            this.CurrentPanel.Margin = new System.Windows.Forms.Padding(1);
            this.CurrentPanel.Name = "CurrentPanel";
            this.CurrentPanel.Size = new System.Drawing.Size(181, 152);
            this.CurrentPanel.TabIndex = 3;
            // 
            // AvailableButton
            // 
            this.AvailableButton.BackColor = System.Drawing.Color.SteelBlue;
            this.AvailableButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AvailableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AvailableButton.Image = ((System.Drawing.Image)(resources.GetObject("AvailableButton.Image")));
            this.AvailableButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AvailableButton.Location = new System.Drawing.Point(0, 102);
            this.AvailableButton.Margin = new System.Windows.Forms.Padding(1);
            this.AvailableButton.Name = "AvailableButton";
            this.AvailableButton.Size = new System.Drawing.Size(181, 51);
            this.AvailableButton.TabIndex = 6;
            this.AvailableButton.Text = "Available Stock";
            this.AvailableButton.UseVisualStyleBackColor = false;
            this.AvailableButton.Click += new System.EventHandler(this.AvailableButton_Click);
            // 
            // PendingButton
            // 
            this.PendingButton.BackColor = System.Drawing.Color.SteelBlue;
            this.PendingButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PendingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PendingButton.Image = ((System.Drawing.Image)(resources.GetObject("PendingButton.Image")));
            this.PendingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PendingButton.Location = new System.Drawing.Point(0, 51);
            this.PendingButton.Margin = new System.Windows.Forms.Padding(1);
            this.PendingButton.Name = "PendingButton";
            this.PendingButton.Size = new System.Drawing.Size(181, 51);
            this.PendingButton.TabIndex = 5;
            this.PendingButton.Text = "Pending Orders";
            this.PendingButton.UseVisualStyleBackColor = false;
            this.PendingButton.Click += new System.EventHandler(this.PendingButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.SteelBlue;
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(0, 0);
            this.AddButton.Margin = new System.Windows.Forms.Padding(1);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(181, 51);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add Order";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CurrentButton
            // 
            this.CurrentButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CurrentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CurrentButton.Image = ((System.Drawing.Image)(resources.GetObject("CurrentButton.Image")));
            this.CurrentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CurrentButton.Location = new System.Drawing.Point(0, 356);
            this.CurrentButton.Margin = new System.Windows.Forms.Padding(1);
            this.CurrentButton.Name = "CurrentButton";
            this.CurrentButton.Size = new System.Drawing.Size(181, 53);
            this.CurrentButton.TabIndex = 3;
            this.CurrentButton.Text = "Current Stock";
            this.CurrentButton.UseVisualStyleBackColor = true;
            this.CurrentButton.Click += new System.EventHandler(this.CurrentButton_Click);
            // 
            // ProductsPanel
            // 
            this.ProductsPanel.Controls.Add(this.SupplierButton);
            this.ProductsPanel.Controls.Add(this.Skewbutton);
            this.ProductsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductsPanel.Location = new System.Drawing.Point(0, 249);
            this.ProductsPanel.Margin = new System.Windows.Forms.Padding(1);
            this.ProductsPanel.Name = "ProductsPanel";
            this.ProductsPanel.Size = new System.Drawing.Size(181, 107);
            this.ProductsPanel.TabIndex = 2;
            // 
            // SupplierButton
            // 
            this.SupplierButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SupplierButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SupplierButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SupplierButton.Image = ((System.Drawing.Image)(resources.GetObject("SupplierButton.Image")));
            this.SupplierButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SupplierButton.Location = new System.Drawing.Point(0, 53);
            this.SupplierButton.Margin = new System.Windows.Forms.Padding(1);
            this.SupplierButton.Name = "SupplierButton";
            this.SupplierButton.Size = new System.Drawing.Size(181, 53);
            this.SupplierButton.TabIndex = 1;
            this.SupplierButton.Text = "Suppliers";
            this.SupplierButton.UseVisualStyleBackColor = false;
            this.SupplierButton.Click += new System.EventHandler(this.SupplierButton_Click);
            // 
            // Skewbutton
            // 
            this.Skewbutton.BackColor = System.Drawing.Color.SteelBlue;
            this.Skewbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.Skewbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Skewbutton.Image = ((System.Drawing.Image)(resources.GetObject("Skewbutton.Image")));
            this.Skewbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Skewbutton.Location = new System.Drawing.Point(0, 0);
            this.Skewbutton.Margin = new System.Windows.Forms.Padding(1);
            this.Skewbutton.Name = "Skewbutton";
            this.Skewbutton.Size = new System.Drawing.Size(181, 53);
            this.Skewbutton.TabIndex = 0;
            this.Skewbutton.Text = "Skew";
            this.Skewbutton.UseVisualStyleBackColor = false;
            this.Skewbutton.Click += new System.EventHandler(this.Skewbutton_Click);
            // 
            // ProductButton
            // 
            this.ProductButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductButton.Image = ((System.Drawing.Image)(resources.GetObject("ProductButton.Image")));
            this.ProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductButton.Location = new System.Drawing.Point(0, 196);
            this.ProductButton.Margin = new System.Windows.Forms.Padding(1);
            this.ProductButton.Name = "ProductButton";
            this.ProductButton.Size = new System.Drawing.Size(181, 53);
            this.ProductButton.TabIndex = 2;
            this.ProductButton.Text = "Products";
            this.ProductButton.UseVisualStyleBackColor = true;
            this.ProductButton.Click += new System.EventHandler(this.ProductButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.Location = new System.Drawing.Point(0, 143);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(1);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(181, 53);
            this.HomeButton.TabIndex = 1;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // LogOnPanel
            // 
            this.LogOnPanel.Controls.Add(this.usernamelabel);
            this.LogOnPanel.Controls.Add(this.pictureBox1);
            this.LogOnPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogOnPanel.Location = new System.Drawing.Point(0, 0);
            this.LogOnPanel.Margin = new System.Windows.Forms.Padding(1);
            this.LogOnPanel.Name = "LogOnPanel";
            this.LogOnPanel.Size = new System.Drawing.Size(181, 143);
            this.LogOnPanel.TabIndex = 0;
            this.LogOnPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LogOnPanel_Paint);
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Location = new System.Drawing.Point(59, 117);
            this.usernamelabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(55, 13);
            this.usernamelabel.TabIndex = 2;
            this.usernamelabel.Text = "Username";
            this.usernamelabel.Click += new System.EventHandler(this.usernamelabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(479, 23);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(32, 22);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Ln";
            this.NameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // TitlePane
            // 
            this.TitlePane.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TitlePane.Controls.Add(this.TitleMessage);
            this.TitlePane.Controls.Add(this.NameLabel);
            this.TitlePane.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePane.Location = new System.Drawing.Point(181, 0);
            this.TitlePane.Margin = new System.Windows.Forms.Padding(1);
            this.TitlePane.Name = "TitlePane";
            this.TitlePane.Size = new System.Drawing.Size(666, 68);
            this.TitlePane.TabIndex = 1;
            // 
            // TitleMessage
            // 
            this.TitleMessage.AutoSize = true;
            this.TitleMessage.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleMessage.Location = new System.Drawing.Point(307, 23);
            this.TitleMessage.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.TitleMessage.Name = "TitleMessage";
            this.TitleMessage.Size = new System.Drawing.Size(151, 22);
            this.TitleMessage.TabIndex = 0;
            this.TitleMessage.Text = "Good Afternoon, ";
            this.TitleMessage.Click += new System.EventHandler(this.TitleMessage_Click);
            // 
            // ParentPanel
            // 
            this.ParentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParentPanel.Location = new System.Drawing.Point(181, 68);
            this.ParentPanel.Margin = new System.Windows.Forms.Padding(1);
            this.ParentPanel.Name = "ParentPanel";
            this.ParentPanel.Size = new System.Drawing.Size(666, 486);
            this.ParentPanel.TabIndex = 2;
            this.ParentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ParentPanel_Paint);
            // 
            // DashboardMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 554);
            this.Controls.Add(this.ParentPanel);
            this.Controls.Add(this.TitlePane);
            this.Controls.Add(this.SideMenu);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "DashboardMenu";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.DashboardMenu_Load);
            this.SideMenu.ResumeLayout(false);
            this.CurrentPanel.ResumeLayout(false);
            this.ProductsPanel.ResumeLayout(false);
            this.LogOnPanel.ResumeLayout(false);
            this.LogOnPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TitlePane.ResumeLayout(false);
            this.TitlePane.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideMenu;
        private System.Windows.Forms.Panel LogOnPanel;
        private System.Windows.Forms.Panel TitlePane;
        private System.Windows.Forms.Label TitleMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ProductButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Panel ProductsPanel;
        private System.Windows.Forms.Button Skewbutton;
        private System.Windows.Forms.Panel CurrentPanel;
        private System.Windows.Forms.Button CurrentButton;
        private System.Windows.Forms.Button SupplierButton;
        private System.Windows.Forms.Button AvailableButton;
        private System.Windows.Forms.Button PendingButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button LogOffButton;
        private System.Windows.Forms.Button ReportButton;
        public System.Windows.Forms.Label usernamelabel;
        public System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Panel ParentPanel;
    }
}