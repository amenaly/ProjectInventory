﻿namespace ProjectInventory
{
    partial class CurrentStock
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentStock));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SkewNumLabel = new System.Windows.Forms.Label();
            this.ProdDescLabel = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.descriptionlabel = new System.Windows.Forms.Label();
            this.skewnumberlabel = new System.Windows.Forms.Label();
            this.productidlabel = new System.Windows.Forms.Label();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.Searchlabel = new System.Windows.Forms.Label();
            this.SearchtxtBox = new System.Windows.Forms.TextBox();
            this.Addbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bottompanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BottomLabel = new System.Windows.Forms.Label();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewImageColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bottompanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // SkewNumLabel
            // 
            this.SkewNumLabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkewNumLabel.Location = new System.Drawing.Point(229, 56);
            this.SkewNumLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.SkewNumLabel.Name = "SkewNumLabel";
            this.SkewNumLabel.Size = new System.Drawing.Size(122, 19);
            this.SkewNumLabel.TabIndex = 10;
            this.SkewNumLabel.Text = "Product Skew:";
            this.SkewNumLabel.Click += new System.EventHandler(this.SkewNumLabel_Click);
            // 
            // ProdDescLabel
            // 
            this.ProdDescLabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdDescLabel.Location = new System.Drawing.Point(106, 96);
            this.ProdDescLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.ProdDescLabel.Name = "ProdDescLabel";
            this.ProdDescLabel.Size = new System.Drawing.Size(110, 19);
            this.ProdDescLabel.TabIndex = 9;
            this.ProdDescLabel.Text = "PDesc:";
            // 
            // IDlabel
            // 
            this.IDlabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlabel.Location = new System.Drawing.Point(102, 56);
            this.IDlabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(72, 19);
            this.IDlabel.TabIndex = 8;
            this.IDlabel.Text = "PID:";
            this.IDlabel.Click += new System.EventHandler(this.IDlabel_Click);
            // 
            // descriptionlabel
            // 
            this.descriptionlabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionlabel.Location = new System.Drawing.Point(11, 96);
            this.descriptionlabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.descriptionlabel.Name = "descriptionlabel";
            this.descriptionlabel.Size = new System.Drawing.Size(88, 19);
            this.descriptionlabel.TabIndex = 7;
            this.descriptionlabel.Text = "Description:";
            // 
            // skewnumberlabel
            // 
            this.skewnumberlabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skewnumberlabel.Location = new System.Drawing.Point(185, 56);
            this.skewnumberlabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.skewnumberlabel.Name = "skewnumberlabel";
            this.skewnumberlabel.Size = new System.Drawing.Size(42, 19);
            this.skewnumberlabel.TabIndex = 6;
            this.skewnumberlabel.Text = "Skew:";
            // 
            // productidlabel
            // 
            this.productidlabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productidlabel.Location = new System.Drawing.Point(11, 56);
            this.productidlabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.productidlabel.Name = "productidlabel";
            this.productidlabel.Size = new System.Drawing.Size(88, 19);
            this.productidlabel.TabIndex = 4;
            this.productidlabel.Text = "Product_ID:";
            this.productidlabel.Click += new System.EventHandler(this.productidlabel_Click);
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelabel.Location = new System.Drawing.Point(73, 14);
            this.usernamelabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(77, 19);
            this.usernamelabel.TabIndex = 3;
            this.usernamelabel.Text = "Username";
            this.usernamelabel.Click += new System.EventHandler(this.usernamelabel_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.Searchlabel);
            this.TopPanel.Controls.Add(this.SearchtxtBox);
            this.TopPanel.Controls.Add(this.Addbutton);
            this.TopPanel.Controls.Add(this.SkewNumLabel);
            this.TopPanel.Controls.Add(this.ProdDescLabel);
            this.TopPanel.Controls.Add(this.IDlabel);
            this.TopPanel.Controls.Add(this.descriptionlabel);
            this.TopPanel.Controls.Add(this.skewnumberlabel);
            this.TopPanel.Controls.Add(this.productidlabel);
            this.TopPanel.Controls.Add(this.usernamelabel);
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(1);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(680, 132);
            this.TopPanel.TabIndex = 59;
            this.TopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TopPanel_Paint);
            // 
            // Searchlabel
            // 
            this.Searchlabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchlabel.Image = ((System.Drawing.Image)(resources.GetObject("Searchlabel.Image")));
            this.Searchlabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Searchlabel.Location = new System.Drawing.Point(218, 94);
            this.Searchlabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Searchlabel.Name = "Searchlabel";
            this.Searchlabel.Size = new System.Drawing.Size(81, 19);
            this.Searchlabel.TabIndex = 64;
            this.Searchlabel.Text = "Search :";
            this.Searchlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // SearchtxtBox
            // 
            this.SearchtxtBox.Font = new System.Drawing.Font("Times New Roman", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchtxtBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.SearchtxtBox.Location = new System.Drawing.Point(302, 95);
            this.SearchtxtBox.Margin = new System.Windows.Forms.Padding(1);
            this.SearchtxtBox.Multiline = true;
            this.SearchtxtBox.Name = "SearchtxtBox";
            this.SearchtxtBox.Size = new System.Drawing.Size(239, 22);
            this.SearchtxtBox.TabIndex = 4;
            this.SearchtxtBox.TextChanged += new System.EventHandler(this.SearchtxtBox_TextChanged);
            // 
            // Addbutton
            // 
            this.Addbutton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Addbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Addbutton.Location = new System.Drawing.Point(571, 56);
            this.Addbutton.Margin = new System.Windows.Forms.Padding(1);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(97, 34);
            this.Addbutton.TabIndex = 63;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = false;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bottompanel
            // 
            this.bottompanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bottompanel.Controls.Add(this.pictureBox2);
            this.bottompanel.Controls.Add(this.BottomLabel);
            this.bottompanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottompanel.Location = new System.Drawing.Point(0, 395);
            this.bottompanel.Margin = new System.Windows.Forms.Padding(1);
            this.bottompanel.Name = "bottompanel";
            this.bottompanel.Size = new System.Drawing.Size(680, 53);
            this.bottompanel.TabIndex = 60;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(39, 13);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // BottomLabel
            // 
            this.BottomLabel.AutoSize = true;
            this.BottomLabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomLabel.ForeColor = System.Drawing.Color.White;
            this.BottomLabel.Location = new System.Drawing.Point(97, 13);
            this.BottomLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.BottomLabel.Name = "BottomLabel";
            this.BottomLabel.Size = new System.Drawing.Size(125, 17);
            this.BottomLabel.TabIndex = 0;
            this.BottomLabel.Text = "Current Stock List";
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.BackgroundColor = System.Drawing.Color.White;
            this.dgvStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Column6,
            this.Select});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStock.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStock.EnableHeadersVisualStyles = false;
            this.dgvStock.Location = new System.Drawing.Point(0, 132);
            this.dgvStock.Margin = new System.Windows.Forms.Padding(1);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.RowHeadersWidth = 102;
            this.dgvStock.RowTemplate.Height = 40;
            this.dgvStock.Size = new System.Drawing.Size(680, 263);
            this.dgvStock.TabIndex = 61;
            this.dgvStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellContentClick);
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
            // Select
            // 
            this.Select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Select.HeaderText = "";
            this.Select.Image = ((System.Drawing.Image)(resources.GetObject("Select.Image")));
            this.Select.MinimumWidth = 12;
            this.Select.Name = "Select";
            this.Select.Width = 12;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CurrentStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(680, 448);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.bottompanel);
            this.Controls.Add(this.TopPanel);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "CurrentStock";
            this.Text = "CurrentStock";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bottompanel.ResumeLayout(false);
            this.bottompanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label SkewNumLabel;
        private System.Windows.Forms.Label ProdDescLabel;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label descriptionlabel;
        private System.Windows.Forms.Label skewnumberlabel;
        private System.Windows.Forms.Label productidlabel;
        public System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel bottompanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label BottomLabel;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn Select;
        private System.Windows.Forms.TextBox SearchtxtBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Label Searchlabel;
    }
}