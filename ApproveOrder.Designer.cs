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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApproveForm));
            this.ApproveButton = new System.Windows.Forms.Button();
            this.OrderIDLabel = new System.Windows.Forms.Label();
            this.OrderTitle = new System.Windows.Forms.Label();
            this.Datelabel = new System.Windows.Forms.Label();
            this.Supplierbutton = new System.Windows.Forms.Label();
            this.Editbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPending = new System.Windows.Forms.DataGridView();
            this.bottompanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BottomLabel = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.supplierinsertlabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.amtinsertlabel = new System.Windows.Forms.Label();
            this.Quanitylabel = new System.Windows.Forms.Label();
            this.qtyinsertlabel = new System.Windows.Forms.Label();
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
            this.RDateLabel = new System.Windows.Forms.Label();
            this.ApprovalDateLabel = new System.Windows.Forms.Label();
            this.ApprovalPicker = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPending)).BeginInit();
            this.bottompanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ApproveButton
            // 
            this.ApproveButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ApproveButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApproveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ApproveButton.Location = new System.Drawing.Point(578, 6);
            this.ApproveButton.Margin = new System.Windows.Forms.Padding(1);
            this.ApproveButton.Name = "ApproveButton";
            this.ApproveButton.Size = new System.Drawing.Size(97, 34);
            this.ApproveButton.TabIndex = 40;
            this.ApproveButton.Text = "Approve";
            this.ApproveButton.UseVisualStyleBackColor = false;
            this.ApproveButton.Click += new System.EventHandler(this.ApproveButton_Click);
            // 
            // OrderIDLabel
            // 
            this.OrderIDLabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderIDLabel.Location = new System.Drawing.Point(10, 65);
            this.OrderIDLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.OrderIDLabel.Name = "OrderIDLabel";
            this.OrderIDLabel.Size = new System.Drawing.Size(78, 19);
            this.OrderIDLabel.TabIndex = 37;
            this.OrderIDLabel.Text = "Order_Id :";
            // 
            // OrderTitle
            // 
            this.OrderTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OrderTitle.Location = new System.Drawing.Point(202, 9);
            this.OrderTitle.Name = "OrderTitle";
            this.OrderTitle.Size = new System.Drawing.Size(327, 40);
            this.OrderTitle.TabIndex = 35;
            this.OrderTitle.Text = "Current Pending Orders :";
            this.OrderTitle.Click += new System.EventHandler(this.OrderTitle_Click);
            // 
            // Datelabel
            // 
            this.Datelabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelabel.Location = new System.Drawing.Point(187, 65);
            this.Datelabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(102, 19);
            this.Datelabel.TabIndex = 47;
            this.Datelabel.Text = "Request Date :";
            // 
            // Supplierbutton
            // 
            this.Supplierbutton.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplierbutton.Location = new System.Drawing.Point(10, 105);
            this.Supplierbutton.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Supplierbutton.Name = "Supplierbutton";
            this.Supplierbutton.Size = new System.Drawing.Size(83, 19);
            this.Supplierbutton.TabIndex = 38;
            this.Supplierbutton.Text = "Supplier :";
            // 
            // Editbutton
            // 
            this.Editbutton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Editbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Editbutton.Location = new System.Drawing.Point(565, 137);
            this.Editbutton.Margin = new System.Windows.Forms.Padding(1);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(97, 34);
            this.Editbutton.TabIndex = 52;
            this.Editbutton.Text = "Edit";
            this.Editbutton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvPending);
            this.panel1.Controls.Add(this.bottompanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 322);
            this.panel1.TabIndex = 54;
            // 
            // dgvPending
            // 
            this.dgvPending.AllowUserToAddRows = false;
            this.dgvPending.BackgroundColor = System.Drawing.Color.White;
            this.dgvPending.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPending.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            this.Edit});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPending.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPending.EnableHeadersVisualStyles = false;
            this.dgvPending.Location = new System.Drawing.Point(0, 0);
            this.dgvPending.Margin = new System.Windows.Forms.Padding(1);
            this.dgvPending.Name = "dgvPending";
            this.dgvPending.RowHeadersVisible = false;
            this.dgvPending.RowHeadersWidth = 102;
            this.dgvPending.RowTemplate.Height = 40;
            this.dgvPending.Size = new System.Drawing.Size(685, 272);
            this.dgvPending.TabIndex = 62;
            this.dgvPending.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellContentClick);
            // 
            // bottompanel
            // 
            this.bottompanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bottompanel.Controls.Add(this.pictureBox2);
            this.bottompanel.Controls.Add(this.BottomLabel);
            this.bottompanel.Controls.Add(this.ApproveButton);
            this.bottompanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottompanel.Location = new System.Drawing.Point(0, 272);
            this.bottompanel.Margin = new System.Windows.Forms.Padding(1);
            this.bottompanel.Name = "bottompanel";
            this.bottompanel.Size = new System.Drawing.Size(685, 50);
            this.bottompanel.TabIndex = 61;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(41, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
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
            this.BottomLabel.Size = new System.Drawing.Size(132, 17);
            this.BottomLabel.TabIndex = 0;
            this.BottomLabel.Text = "Pending Orders List";
            // 
            // IDlabel
            // 
            this.IDlabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlabel.Location = new System.Drawing.Point(79, 65);
            this.IDlabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(99, 19);
            this.IDlabel.TabIndex = 55;
            this.IDlabel.Text = "OID:";
            // 
            // supplierinsertlabel
            // 
            this.supplierinsertlabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierinsertlabel.Location = new System.Drawing.Point(79, 105);
            this.supplierinsertlabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.supplierinsertlabel.Name = "supplierinsertlabel";
            this.supplierinsertlabel.Size = new System.Drawing.Size(106, 19);
            this.supplierinsertlabel.TabIndex = 56;
            this.supplierinsertlabel.Text = "Supplier:";
            // 
            // AmountLabel
            // 
            this.AmountLabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.Location = new System.Drawing.Point(187, 105);
            this.AmountLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(83, 19);
            this.AmountLabel.TabIndex = 57;
            this.AmountLabel.Text = "Amount :";
            // 
            // amtinsertlabel
            // 
            this.amtinsertlabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtinsertlabel.Location = new System.Drawing.Point(254, 105);
            this.amtinsertlabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.amtinsertlabel.Name = "amtinsertlabel";
            this.amtinsertlabel.Size = new System.Drawing.Size(106, 19);
            this.amtinsertlabel.TabIndex = 58;
            this.amtinsertlabel.Text = "Amt:";
            // 
            // Quanitylabel
            // 
            this.Quanitylabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quanitylabel.Location = new System.Drawing.Point(10, 137);
            this.Quanitylabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Quanitylabel.Name = "Quanitylabel";
            this.Quanitylabel.Size = new System.Drawing.Size(61, 19);
            this.Quanitylabel.TabIndex = 59;
            this.Quanitylabel.Text = "Qty :";
            // 
            // qtyinsertlabel
            // 
            this.qtyinsertlabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyinsertlabel.Location = new System.Drawing.Point(79, 137);
            this.qtyinsertlabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.qtyinsertlabel.Name = "qtyinsertlabel";
            this.qtyinsertlabel.Size = new System.Drawing.Size(106, 19);
            this.qtyinsertlabel.TabIndex = 60;
            this.qtyinsertlabel.Text = "Qty:";
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
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.HeaderText = "Approval Date";
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
            // RDateLabel
            // 
            this.RDateLabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDateLabel.Location = new System.Drawing.Point(291, 65);
            this.RDateLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.RDateLabel.Name = "RDateLabel";
            this.RDateLabel.Size = new System.Drawing.Size(99, 19);
            this.RDateLabel.TabIndex = 61;
            this.RDateLabel.Text = "RDate:";
            // 
            // ApprovalDateLabel
            // 
            this.ApprovalDateLabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApprovalDateLabel.Location = new System.Drawing.Point(427, 65);
            this.ApprovalDateLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.ApprovalDateLabel.Name = "ApprovalDateLabel";
            this.ApprovalDateLabel.Size = new System.Drawing.Size(102, 19);
            this.ApprovalDateLabel.TabIndex = 62;
            this.ApprovalDateLabel.Text = "Approval Date :";
            // 
            // ApprovalPicker
            // 
            this.ApprovalPicker.CustomFormat = "MM dd yyyy hh:mm";
            this.ApprovalPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ApprovalPicker.Location = new System.Drawing.Point(531, 65);
            this.ApprovalPicker.Margin = new System.Windows.Forms.Padding(1);
            this.ApprovalPicker.Name = "ApprovalPicker";
            this.ApprovalPicker.Size = new System.Drawing.Size(115, 20);
            this.ApprovalPicker.TabIndex = 63;
            // 
            // ApproveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(685, 505);
            this.Controls.Add(this.ApprovalPicker);
            this.Controls.Add(this.ApprovalDateLabel);
            this.Controls.Add(this.RDateLabel);
            this.Controls.Add(this.qtyinsertlabel);
            this.Controls.Add(this.Quanitylabel);
            this.Controls.Add(this.amtinsertlabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.supplierinsertlabel);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Editbutton);
            this.Controls.Add(this.Datelabel);
            this.Controls.Add(this.Supplierbutton);
            this.Controls.Add(this.OrderIDLabel);
            this.Controls.Add(this.OrderTitle);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "ApproveForm";
            this.Text = "ApproveOrder";
            this.Load += new System.EventHandler(this.ApproveForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPending)).EndInit();
            this.bottompanel.ResumeLayout(false);
            this.bottompanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ApproveButton;
        private System.Windows.Forms.Label OrderIDLabel;
        private System.Windows.Forms.Label OrderTitle;
        private System.Windows.Forms.Label Datelabel;
        private System.Windows.Forms.Label Supplierbutton;
        private System.Windows.Forms.Button Editbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel bottompanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label BottomLabel;
        private System.Windows.Forms.DataGridView dgvPending;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label supplierinsertlabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label amtinsertlabel;
        private System.Windows.Forms.Label Quanitylabel;
        private System.Windows.Forms.Label qtyinsertlabel;
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
        private System.Windows.Forms.Label RDateLabel;
        private System.Windows.Forms.Label ApprovalDateLabel;
        private System.Windows.Forms.DateTimePicker ApprovalPicker;
    }
}