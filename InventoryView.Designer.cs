namespace ProjectInventory
{
    partial class StockTable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockTable));
            this.BottomLabel = new System.Windows.Forms.Label();
            this.bottompanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.savebutton = new System.Windows.Forms.Button();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.productidlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.skewnumberlabel = new System.Windows.Forms.Label();
            this.descriptionlabel = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.ProdDescLabel = new System.Windows.Forms.Label();
            this.SkewNumLabel = new System.Windows.Forms.Label();
            this.SupplierNumLabel = new System.Windows.Forms.Label();
            this.PNameLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchtxtBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bottompanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BottomLabel
            // 
            this.BottomLabel.AutoSize = true;
            this.BottomLabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomLabel.ForeColor = System.Drawing.Color.White;
            this.BottomLabel.Location = new System.Drawing.Point(153, 35);
            this.BottomLabel.Name = "BottomLabel";
            this.BottomLabel.Size = new System.Drawing.Size(276, 38);
            this.BottomLabel.TabIndex = 0;
            this.BottomLabel.Text = "Stock Adjustment";
            this.BottomLabel.Click += new System.EventHandler(this.BottomLabel_Click);
            // 
            // bottompanel
            // 
            this.bottompanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bottompanel.Controls.Add(this.SearchtxtBox);
            this.bottompanel.Controls.Add(this.savebutton);
            this.bottompanel.Controls.Add(this.pictureBox2);
            this.bottompanel.Controls.Add(this.BottomLabel);
            this.bottompanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottompanel.Location = new System.Drawing.Point(0, 1042);
            this.bottompanel.Name = "bottompanel";
            this.bottompanel.Size = new System.Drawing.Size(1605, 99);
            this.bottompanel.TabIndex = 57;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.textBox1);
            this.TopPanel.Controls.Add(this.QuantityLabel);
            this.TopPanel.Controls.Add(this.PNameLabel);
            this.TopPanel.Controls.Add(this.ProductNameLabel);
            this.TopPanel.Controls.Add(this.SupplierNumLabel);
            this.TopPanel.Controls.Add(this.SkewNumLabel);
            this.TopPanel.Controls.Add(this.ProdDescLabel);
            this.TopPanel.Controls.Add(this.IDlabel);
            this.TopPanel.Controls.Add(this.descriptionlabel);
            this.TopPanel.Controls.Add(this.skewnumberlabel);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.productidlabel);
            this.TopPanel.Controls.Add(this.usernamelabel);
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1605, 314);
            this.TopPanel.TabIndex = 58;
            // 
            // savebutton
            // 
            this.savebutton.FlatAppearance.BorderSize = 0;
            this.savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.ForeColor = System.Drawing.Color.White;
            this.savebutton.Location = new System.Drawing.Point(1449, 20);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(135, 64);
            this.savebutton.TabIndex = 3;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click_1);
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelabel.Location = new System.Drawing.Point(114, 35);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(194, 45);
            this.usernamelabel.TabIndex = 3;
            this.usernamelabel.Text = "Username";
            // 
            // productidlabel
            // 
            this.productidlabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productidlabel.Location = new System.Drawing.Point(30, 134);
            this.productidlabel.Name = "productidlabel";
            this.productidlabel.Size = new System.Drawing.Size(192, 46);
            this.productidlabel.TabIndex = 4;
            this.productidlabel.Text = "Product_ID:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(489, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Supplier_ID:";
            // 
            // skewnumberlabel
            // 
            this.skewnumberlabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skewnumberlabel.Location = new System.Drawing.Point(363, 134);
            this.skewnumberlabel.Name = "skewnumberlabel";
            this.skewnumberlabel.Size = new System.Drawing.Size(111, 46);
            this.skewnumberlabel.TabIndex = 6;
            this.skewnumberlabel.Text = "Skew:";
            // 
            // descriptionlabel
            // 
            this.descriptionlabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionlabel.Location = new System.Drawing.Point(30, 229);
            this.descriptionlabel.Name = "descriptionlabel";
            this.descriptionlabel.Size = new System.Drawing.Size(192, 46);
            this.descriptionlabel.TabIndex = 7;
            this.descriptionlabel.Text = "Description:";
            // 
            // IDlabel
            // 
            this.IDlabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlabel.Location = new System.Drawing.Point(213, 134);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(117, 46);
            this.IDlabel.TabIndex = 8;
            this.IDlabel.Text = "PID:";
            // 
            // ProdDescLabel
            // 
            this.ProdDescLabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdDescLabel.Location = new System.Drawing.Point(213, 229);
            this.ProdDescLabel.Name = "ProdDescLabel";
            this.ProdDescLabel.Size = new System.Drawing.Size(213, 46);
            this.ProdDescLabel.TabIndex = 9;
            this.ProdDescLabel.Text = "PDesc:";
            // 
            // SkewNumLabel
            // 
            this.SkewNumLabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkewNumLabel.Location = new System.Drawing.Point(480, 134);
            this.SkewNumLabel.Name = "SkewNumLabel";
            this.SkewNumLabel.Size = new System.Drawing.Size(240, 46);
            this.SkewNumLabel.TabIndex = 10;
            this.SkewNumLabel.Text = "Product Skew:";
            // 
            // SupplierNumLabel
            // 
            this.SupplierNumLabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierNumLabel.Location = new System.Drawing.Point(687, 229);
            this.SupplierNumLabel.Name = "SupplierNumLabel";
            this.SupplierNumLabel.Size = new System.Drawing.Size(213, 46);
            this.SupplierNumLabel.TabIndex = 11;
            this.SupplierNumLabel.Text = "SupplierNum:";
            // 
            // PNameLabel
            // 
            this.PNameLabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNameLabel.Location = new System.Drawing.Point(1152, 134);
            this.PNameLabel.Name = "PNameLabel";
            this.PNameLabel.Size = new System.Drawing.Size(108, 46);
            this.PNameLabel.TabIndex = 13;
            this.PNameLabel.Text = "Name:";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameLabel.Location = new System.Drawing.Point(921, 134);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(225, 46);
            this.ProductNameLabel.TabIndex = 12;
            this.ProductNameLabel.Text = "Product Name:";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(954, 229);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(111, 46);
            this.QuantityLabel.TabIndex = 14;
            this.QuantityLabel.Text = "QTY:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1071, 229);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 45);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.BackgroundColor = System.Drawing.Color.White;
            this.dgvStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStock.ColumnHeadersHeight = 58;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStock.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStock.EnableHeadersVisualStyles = false;
            this.dgvStock.Location = new System.Drawing.Point(0, 314);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.RowHeadersWidth = 102;
            this.dgvStock.RowTemplate.Height = 40;
            this.dgvStock.Size = new System.Drawing.Size(1605, 728);
            this.dgvStock.TabIndex = 59;
            this.dgvStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellContentClick_1);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Product_ID";
            this.Column1.MinimumWidth = 12;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Supplier_ID";
            this.Column2.MinimumWidth = 12;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Skew_Num";
            this.Column3.MinimumWidth = 12;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Name";
            this.Column4.MinimumWidth = 12;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Description ";
            this.Column5.MinimumWidth = 12;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Qty";
            this.Column6.MinimumWidth = 12;
            this.Column6.Name = "Column6";
            // 
            // SearchtxtBox
            // 
            this.SearchtxtBox.Font = new System.Drawing.Font("Times New Roman", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchtxtBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.SearchtxtBox.Location = new System.Drawing.Point(573, 35);
            this.SearchtxtBox.Multiline = true;
            this.SearchtxtBox.Name = "SearchtxtBox";
            this.SearchtxtBox.Size = new System.Drawing.Size(631, 48);
            this.SearchtxtBox.TabIndex = 4;
            this.SearchtxtBox.Text = "Search";
            this.SearchtxtBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            this.SearchtxtBox.Enter += new System.EventHandler(this.Searchtxt_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(36, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // StockTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(48F, 90F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1605, 1141);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.bottompanel);
            this.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.Name = "StockTable";
            this.Text = "Current Stock";
            this.Load += new System.EventHandler(this.InventoryTable_Load);
            this.bottompanel.ResumeLayout(false);
            this.bottompanel.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label BottomLabel;
        private System.Windows.Forms.Panel bottompanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Label productidlabel;
        private System.Windows.Forms.Label descriptionlabel;
        private System.Windows.Forms.Label skewnumberlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProdDescLabel;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label SupplierNumLabel;
        private System.Windows.Forms.Label SkewNumLabel;
        private System.Windows.Forms.Label PNameLabel;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox SearchtxtBox;
    }
}

