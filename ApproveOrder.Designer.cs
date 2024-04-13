namespace ProjectInventory
{
    partial class ApproveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApproveForm));
            this.OrderIDLabel = new System.Windows.Forms.Label();
            this.OrderTitle = new System.Windows.Forms.Label();
            this.Datelabel = new System.Windows.Forms.Label();
            this.Supplierbutton = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.supplierinsertlabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.amtinsertlabel = new System.Windows.Forms.Label();
            this.Quanitylabel = new System.Windows.Forms.Label();
            this.qtyinsertlabel = new System.Windows.Forms.Label();
            this.RDateLabel = new System.Windows.Forms.Label();
            this.ApprovalDateLabel = new System.Windows.Forms.Label();
            this.ApprovalPicker = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvPending = new System.Windows.Forms.DataGridView();
            this.bottompanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BottomLabel = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Approve = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPending)).BeginInit();
            this.bottompanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderIDLabel
            // 
            this.OrderIDLabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderIDLabel.Location = new System.Drawing.Point(27, 155);
            this.OrderIDLabel.Name = "OrderIDLabel";
            this.OrderIDLabel.Size = new System.Drawing.Size(208, 45);
            this.OrderIDLabel.TabIndex = 37;
            this.OrderIDLabel.Text = "Order_Id :";
            // 
            // OrderTitle
            // 
            this.OrderTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OrderTitle.Location = new System.Drawing.Point(539, 21);
            this.OrderTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.OrderTitle.Name = "OrderTitle";
            this.OrderTitle.Size = new System.Drawing.Size(872, 95);
            this.OrderTitle.TabIndex = 35;
            this.OrderTitle.Text = "Current Pending Orders :";
            this.OrderTitle.Click += new System.EventHandler(this.OrderTitle_Click);
            // 
            // Datelabel
            // 
            this.Datelabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelabel.Location = new System.Drawing.Point(499, 155);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(272, 45);
            this.Datelabel.TabIndex = 47;
            this.Datelabel.Text = "Request Date :";
            // 
            // Supplierbutton
            // 
            this.Supplierbutton.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplierbutton.Location = new System.Drawing.Point(27, 250);
            this.Supplierbutton.Name = "Supplierbutton";
            this.Supplierbutton.Size = new System.Drawing.Size(221, 45);
            this.Supplierbutton.TabIndex = 38;
            this.Supplierbutton.Text = "Supplier :";
            // 
            // IDlabel
            // 
            this.IDlabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlabel.Location = new System.Drawing.Point(211, 155);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(264, 45);
            this.IDlabel.TabIndex = 55;
            this.IDlabel.Text = "OID:";
            // 
            // supplierinsertlabel
            // 
            this.supplierinsertlabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierinsertlabel.Location = new System.Drawing.Point(211, 250);
            this.supplierinsertlabel.Name = "supplierinsertlabel";
            this.supplierinsertlabel.Size = new System.Drawing.Size(283, 45);
            this.supplierinsertlabel.TabIndex = 56;
            this.supplierinsertlabel.Text = "Supplier:";
            // 
            // AmountLabel
            // 
            this.AmountLabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.Location = new System.Drawing.Point(499, 250);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(221, 45);
            this.AmountLabel.TabIndex = 57;
            this.AmountLabel.Text = "Amount :";
            // 
            // amtinsertlabel
            // 
            this.amtinsertlabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtinsertlabel.Location = new System.Drawing.Point(677, 250);
            this.amtinsertlabel.Name = "amtinsertlabel";
            this.amtinsertlabel.Size = new System.Drawing.Size(283, 45);
            this.amtinsertlabel.TabIndex = 58;
            this.amtinsertlabel.Text = "Amt:";
            // 
            // Quanitylabel
            // 
            this.Quanitylabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quanitylabel.Location = new System.Drawing.Point(27, 327);
            this.Quanitylabel.Name = "Quanitylabel";
            this.Quanitylabel.Size = new System.Drawing.Size(163, 45);
            this.Quanitylabel.TabIndex = 59;
            this.Quanitylabel.Text = "Qty :";
            // 
            // qtyinsertlabel
            // 
            this.qtyinsertlabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyinsertlabel.Location = new System.Drawing.Point(211, 327);
            this.qtyinsertlabel.Name = "qtyinsertlabel";
            this.qtyinsertlabel.Size = new System.Drawing.Size(283, 45);
            this.qtyinsertlabel.TabIndex = 60;
            this.qtyinsertlabel.Text = "Qty:";
            // 
            // RDateLabel
            // 
            this.RDateLabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDateLabel.Location = new System.Drawing.Point(776, 155);
            this.RDateLabel.Name = "RDateLabel";
            this.RDateLabel.Size = new System.Drawing.Size(264, 45);
            this.RDateLabel.TabIndex = 61;
            this.RDateLabel.Text = "RDate:";
            // 
            // ApprovalDateLabel
            // 
            this.ApprovalDateLabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApprovalDateLabel.Location = new System.Drawing.Point(1139, 155);
            this.ApprovalDateLabel.Name = "ApprovalDateLabel";
            this.ApprovalDateLabel.Size = new System.Drawing.Size(272, 45);
            this.ApprovalDateLabel.TabIndex = 62;
            this.ApprovalDateLabel.Text = "Approval Date :";
            // 
            // ApprovalPicker
            // 
            this.ApprovalPicker.CustomFormat = "MM dd yyyy hh:mm";
            this.ApprovalPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ApprovalPicker.Location = new System.Drawing.Point(1416, 155);
            this.ApprovalPicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ApprovalPicker.Name = "ApprovalPicker";
            this.ApprovalPicker.Size = new System.Drawing.Size(300, 38);
            this.ApprovalPicker.TabIndex = 63;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1827, 400);
            this.panel2.TabIndex = 64;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dgvPending
            // 
            this.dgvPending.AllowUserToAddRows = false;
            this.dgvPending.BackgroundColor = System.Drawing.Color.White;
            this.dgvPending.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPending.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPending.ColumnHeadersHeight = 58;
            this.dgvPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPending.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column7,
            this.Column6,
            this.Column5,
            this.Column8,
            this.Column9,
            this.Select,
            this.Edit,
            this.Delete,
            this.Approve});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPending.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPending.EnableHeadersVisualStyles = false;
            this.dgvPending.Location = new System.Drawing.Point(0, 400);
            this.dgvPending.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPending.Name = "dgvPending";
            this.dgvPending.RowHeadersVisible = false;
            this.dgvPending.RowHeadersWidth = 102;
            this.dgvPending.RowTemplate.Height = 40;
            this.dgvPending.Size = new System.Drawing.Size(1827, 685);
            this.dgvPending.TabIndex = 66;
            this.dgvPending.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPending_CellContentClick);
            // 
            // bottompanel
            // 
            this.bottompanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bottompanel.Controls.Add(this.pictureBox2);
            this.bottompanel.Controls.Add(this.BottomLabel);
            this.bottompanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottompanel.Location = new System.Drawing.Point(0, 1085);
            this.bottompanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bottompanel.Name = "bottompanel";
            this.bottompanel.Size = new System.Drawing.Size(1827, 119);
            this.bottompanel.TabIndex = 65;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(109, 24);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 72);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // BottomLabel
            // 
            this.BottomLabel.AutoSize = true;
            this.BottomLabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomLabel.ForeColor = System.Drawing.Color.White;
            this.BottomLabel.Location = new System.Drawing.Point(259, 31);
            this.BottomLabel.Name = "BottomLabel";
            this.BottomLabel.Size = new System.Drawing.Size(313, 38);
            this.BottomLabel.TabIndex = 0;
            this.BottomLabel.Text = "Pending Orders List";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Order_id";
            this.Column1.MinimumWidth = 12;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 12;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Description";
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
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "Supplier";
            this.Column7.MinimumWidth = 12;
            this.Column7.Name = "Column7";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Qty";
            this.Column6.MinimumWidth = 12;
            this.Column6.Name = "Column6";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Order_Amt";
            this.Column5.MinimumWidth = 12;
            this.Column5.Name = "Column5";
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "Ordered Date";
            this.Column8.MinimumWidth = 12;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.HeaderText = "Approval Date";
            this.Column9.MinimumWidth = 12;
            this.Column9.Name = "Column9";
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
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.MinimumWidth = 12;
            this.Edit.Name = "Edit";
            this.Edit.Width = 12;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 12;
            this.Delete.Name = "Delete";
            this.Delete.Width = 12;
            // 
            // Approve
            // 
            this.Approve.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Approve.HeaderText = "";
            this.Approve.Image = ((System.Drawing.Image)(resources.GetObject("Approve.Image")));
            this.Approve.MinimumWidth = 12;
            this.Approve.Name = "Approve";
            this.Approve.Width = 12;
            // 
            // ApproveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1827, 1204);
            this.Controls.Add(this.dgvPending);
            this.Controls.Add(this.bottompanel);
            this.Controls.Add(this.ApprovalPicker);
            this.Controls.Add(this.ApprovalDateLabel);
            this.Controls.Add(this.RDateLabel);
            this.Controls.Add(this.qtyinsertlabel);
            this.Controls.Add(this.Quanitylabel);
            this.Controls.Add(this.amtinsertlabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.supplierinsertlabel);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.Datelabel);
            this.Controls.Add(this.Supplierbutton);
            this.Controls.Add(this.OrderIDLabel);
            this.Controls.Add(this.OrderTitle);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ApproveForm";
            this.Text = "ApproveOrder";
            this.Load += new System.EventHandler(this.ApproveForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPending)).EndInit();
            this.bottompanel.ResumeLayout(false);
            this.bottompanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label OrderIDLabel;
        private System.Windows.Forms.Label OrderTitle;
        private System.Windows.Forms.Label Datelabel;
        private System.Windows.Forms.Label Supplierbutton;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label supplierinsertlabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label amtinsertlabel;
        private System.Windows.Forms.Label Quanitylabel;
        private System.Windows.Forms.Label qtyinsertlabel;
        private System.Windows.Forms.Label RDateLabel;
        private System.Windows.Forms.Label ApprovalDateLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvPending;
        private System.Windows.Forms.Panel bottompanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label BottomLabel;
        public System.Windows.Forms.DateTimePicker ApprovalPicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewImageColumn Select;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn Approve;
    }
}