namespace ProjectInventory
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bottompanel = new System.Windows.Forms.Panel();
            this.PrintButton = new System.Windows.Forms.PictureBox();
            this.ReportImage = new System.Windows.Forms.PictureBox();
            this.BottomLabel = new System.Windows.Forms.Label();
            this.OrdersBodyPanel = new System.Windows.Forms.Panel();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bottompanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrintButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportImage)).BeginInit();
            this.OrdersBodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // bottompanel
            // 
            this.bottompanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bottompanel.Controls.Add(this.PrintButton);
            this.bottompanel.Controls.Add(this.ReportImage);
            this.bottompanel.Controls.Add(this.BottomLabel);
            this.bottompanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottompanel.Location = new System.Drawing.Point(0, 1085);
            this.bottompanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bottompanel.Name = "bottompanel";
            this.bottompanel.Size = new System.Drawing.Size(1827, 119);
            this.bottompanel.TabIndex = 66;
            // 
            // PrintButton
            // 
            this.PrintButton.Image = ((System.Drawing.Image)(resources.GetObject("PrintButton.Image")));
            this.PrintButton.Location = new System.Drawing.Point(1695, 39);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(30, 30);
            this.PrintButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PrintButton.TabIndex = 3;
            this.PrintButton.TabStop = false;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // ReportImage
            // 
            this.ReportImage.Image = ((System.Drawing.Image)(resources.GetObject("ReportImage.Image")));
            this.ReportImage.Location = new System.Drawing.Point(109, 24);
            this.ReportImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReportImage.Name = "ReportImage";
            this.ReportImage.Size = new System.Drawing.Size(80, 72);
            this.ReportImage.TabIndex = 2;
            this.ReportImage.TabStop = false;
            // 
            // BottomLabel
            // 
            this.BottomLabel.AutoSize = true;
            this.BottomLabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomLabel.ForeColor = System.Drawing.Color.White;
            this.BottomLabel.Location = new System.Drawing.Point(259, 31);
            this.BottomLabel.Name = "BottomLabel";
            this.BottomLabel.Size = new System.Drawing.Size(132, 38);
            this.BottomLabel.TabIndex = 0;
            this.BottomLabel.Text = "Reports";
            // 
            // OrdersBodyPanel
            // 
            this.OrdersBodyPanel.Controls.Add(this.dgvReports);
            this.OrdersBodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersBodyPanel.Location = new System.Drawing.Point(0, 0);
            this.OrdersBodyPanel.Name = "OrdersBodyPanel";
            this.OrdersBodyPanel.Size = new System.Drawing.Size(1827, 1085);
            this.OrdersBodyPanel.TabIndex = 67;
            // 
            // dgvReports
            // 
            this.dgvReports.AllowUserToAddRows = false;
            this.dgvReports.BackgroundColor = System.Drawing.Color.White;
            this.dgvReports.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReports.ColumnHeadersHeight = 58;
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReports.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReports.EnableHeadersVisualStyles = false;
            this.dgvReports.Location = new System.Drawing.Point(0, 0);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.RowHeadersVisible = false;
            this.dgvReports.RowHeadersWidth = 102;
            this.dgvReports.RowTemplate.Height = 40;
            this.dgvReports.Size = new System.Drawing.Size(1827, 1085);
            this.dgvReports.TabIndex = 2;
            this.dgvReports.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReports_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Order_Id";
            this.Column1.MinimumWidth = 12;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Product Name";
            this.Column2.MinimumWidth = 12;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Supplier";
            this.Column3.MinimumWidth = 12;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Skew";
            this.Column4.MinimumWidth = 12;
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Orderd Date";
            this.Column6.MinimumWidth = 12;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "Approved Date";
            this.Column7.MinimumWidth = 12;
            this.Column7.Name = "Column7";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1827, 1204);
            this.Controls.Add(this.OrdersBodyPanel);
            this.Controls.Add(this.bottompanel);
            this.Name = "Reports";
            this.Text = "Reports";
            this.bottompanel.ResumeLayout(false);
            this.bottompanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrintButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportImage)).EndInit();
            this.OrdersBodyPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bottompanel;
        private System.Windows.Forms.PictureBox ReportImage;
        private System.Windows.Forms.Label BottomLabel;
        private System.Windows.Forms.Panel OrdersBodyPanel;
        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.PictureBox PrintButton;
    }
}