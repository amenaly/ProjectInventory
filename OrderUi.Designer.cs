namespace ProjectInventory
{
    partial class OrderForm
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
            this.Supplierbox = new System.Windows.Forms.ComboBox();
            this.SupplierLabel = new System.Windows.Forms.Label();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.OrderTitle = new System.Windows.Forms.Label();
            this.Addbutton = new System.Windows.Forms.Button();
            this.QtyLabel = new System.Windows.Forms.Label();
            this.UPlabel = new System.Windows.Forms.Label();
            this.UPbox = new System.Windows.Forms.TextBox();
            this.Datelabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.amountlabel = new System.Windows.Forms.Label();
            this.qtynumchoice = new System.Windows.Forms.NumericUpDown();
            this.clearbutton = new System.Windows.Forms.Button();
            this.Descriplabel = new System.Windows.Forms.Label();
            this.amounttxtbox = new System.Windows.Forms.TextBox();
            this.Descriptionbox = new System.Windows.Forms.TextBox();
            this.OrderIDRanLabel = new System.Windows.Forms.Label();
            this.OrderIDLabel = new System.Windows.Forms.Label();
            this.Productbox = new System.Windows.Forms.TextBox();
            this.skewlabel = new System.Windows.Forms.Label();
            this.skewdroplabel = new System.Windows.Forms.Label();
            this.Editbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qtynumchoice)).BeginInit();
            this.SuspendLayout();
            // 
            // Supplierbox
            // 
            this.Supplierbox.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplierbox.FormattingEnabled = true;
            this.Supplierbox.Location = new System.Drawing.Point(301, 453);
            this.Supplierbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Supplierbox.Name = "Supplierbox";
            this.Supplierbox.Size = new System.Drawing.Size(489, 61);
            this.Supplierbox.TabIndex = 23;
            this.Supplierbox.SelectedIndexChanged += new System.EventHandler(this.Supplierbox_SelectedIndexChanged);
            // 
            // SupplierLabel
            // 
            this.SupplierLabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierLabel.Location = new System.Drawing.Point(75, 470);
            this.SupplierLabel.Name = "SupplierLabel";
            this.SupplierLabel.Size = new System.Drawing.Size(221, 45);
            this.SupplierLabel.TabIndex = 22;
            this.SupplierLabel.Text = "Supplier :";
            this.SupplierLabel.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // ProductLabel
            // 
            this.ProductLabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductLabel.Location = new System.Drawing.Point(77, 246);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(173, 45);
            this.ProductLabel.TabIndex = 21;
            this.ProductLabel.Text = "Product :";
            this.ProductLabel.Click += new System.EventHandler(this.OrderLabel_Click);
            // 
            // OrderTitle
            // 
            this.OrderTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OrderTitle.Location = new System.Drawing.Point(3, 10);
            this.OrderTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.OrderTitle.Name = "OrderTitle";
            this.OrderTitle.Size = new System.Drawing.Size(685, 95);
            this.OrderTitle.TabIndex = 19;
            this.OrderTitle.Text = "New Order Request";
            this.OrderTitle.Click += new System.EventHandler(this.OrderTitle_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Addbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Addbutton.Location = new System.Drawing.Point(326, 925);
            this.Addbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(216, 81);
            this.Addbutton.TabIndex = 26;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = false;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // QtyLabel
            // 
            this.QtyLabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtyLabel.Location = new System.Drawing.Point(75, 582);
            this.QtyLabel.Name = "QtyLabel";
            this.QtyLabel.Size = new System.Drawing.Size(173, 45);
            this.QtyLabel.TabIndex = 28;
            this.QtyLabel.Text = "Qty :";
            // 
            // UPlabel
            // 
            this.UPlabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPlabel.Location = new System.Drawing.Point(77, 680);
            this.UPlabel.Name = "UPlabel";
            this.UPlabel.Size = new System.Drawing.Size(221, 45);
            this.UPlabel.TabIndex = 29;
            this.UPlabel.Text = "Unit Price :";
            // 
            // UPbox
            // 
            this.UPbox.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPbox.Location = new System.Drawing.Point(304, 663);
            this.UPbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UPbox.Name = "UPbox";
            this.UPbox.Size = new System.Drawing.Size(308, 62);
            this.UPbox.TabIndex = 30;
            // 
            // Datelabel
            // 
            this.Datelabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelabel.Location = new System.Drawing.Point(960, 60);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(269, 45);
            this.Datelabel.TabIndex = 31;
            this.Datelabel.Text = "Request Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM dd yyyy hh:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(965, 122);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 38);
            this.dateTimePicker1.TabIndex = 32;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // amountlabel
            // 
            this.amountlabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountlabel.Location = new System.Drawing.Point(77, 785);
            this.amountlabel.Name = "amountlabel";
            this.amountlabel.Size = new System.Drawing.Size(173, 45);
            this.amountlabel.TabIndex = 34;
            this.amountlabel.Text = "Amount : ";
            this.amountlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // qtynumchoice
            // 
            this.qtynumchoice.Location = new System.Drawing.Point(304, 582);
            this.qtynumchoice.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.qtynumchoice.Name = "qtynumchoice";
            this.qtynumchoice.Size = new System.Drawing.Size(320, 38);
            this.qtynumchoice.TabIndex = 36;
            this.qtynumchoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clearbutton
            // 
            this.clearbutton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.clearbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearbutton.Location = new System.Drawing.Point(85, 925);
            this.clearbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(216, 81);
            this.clearbutton.TabIndex = 37;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = false;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // Descriplabel
            // 
            this.Descriplabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descriplabel.Location = new System.Drawing.Point(75, 362);
            this.Descriplabel.Name = "Descriplabel";
            this.Descriplabel.Size = new System.Drawing.Size(272, 45);
            this.Descriplabel.TabIndex = 38;
            this.Descriplabel.Text = "Description : ";
            // 
            // amounttxtbox
            // 
            this.amounttxtbox.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amounttxtbox.Location = new System.Drawing.Point(301, 768);
            this.amounttxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.amounttxtbox.Name = "amounttxtbox";
            this.amounttxtbox.Size = new System.Drawing.Size(308, 62);
            this.amounttxtbox.TabIndex = 20;
            // 
            // Descriptionbox
            // 
            this.Descriptionbox.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descriptionbox.Location = new System.Drawing.Point(301, 346);
            this.Descriptionbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Descriptionbox.Name = "Descriptionbox";
            this.Descriptionbox.Size = new System.Drawing.Size(684, 62);
            this.Descriptionbox.TabIndex = 39;
            // 
            // OrderIDRanLabel
            // 
            this.OrderIDRanLabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderIDRanLabel.Location = new System.Drawing.Point(339, 122);
            this.OrderIDRanLabel.Name = "OrderIDRanLabel";
            this.OrderIDRanLabel.Size = new System.Drawing.Size(192, 45);
            this.OrderIDRanLabel.TabIndex = 41;
            this.OrderIDRanLabel.Text = "OID: ";
            // 
            // OrderIDLabel
            // 
            this.OrderIDLabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderIDLabel.Location = new System.Drawing.Point(61, 122);
            this.OrderIDLabel.Name = "OrderIDLabel";
            this.OrderIDLabel.Size = new System.Drawing.Size(235, 45);
            this.OrderIDLabel.TabIndex = 40;
            this.OrderIDLabel.Text = "Order ID : ";
            // 
            // Productbox
            // 
            this.Productbox.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productbox.Location = new System.Drawing.Point(301, 229);
            this.Productbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Productbox.Name = "Productbox";
            this.Productbox.Size = new System.Drawing.Size(684, 62);
            this.Productbox.TabIndex = 42;
            // 
            // skewlabel
            // 
            this.skewlabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skewlabel.Location = new System.Drawing.Point(872, 470);
            this.skewlabel.Name = "skewlabel";
            this.skewlabel.Size = new System.Drawing.Size(165, 45);
            this.skewlabel.TabIndex = 44;
            this.skewlabel.Text = "Skew :";
            // 
            // skewdroplabel
            // 
            this.skewdroplabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skewdroplabel.Location = new System.Drawing.Point(1003, 470);
            this.skewdroplabel.Name = "skewdroplabel";
            this.skewdroplabel.Size = new System.Drawing.Size(192, 45);
            this.skewdroplabel.TabIndex = 45;
            this.skewdroplabel.Text = "Skew:";
            this.skewdroplabel.Click += new System.EventHandler(this.skewdroplabel_Click);
            // 
            // Editbutton
            // 
            this.Editbutton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Editbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Editbutton.Location = new System.Drawing.Point(574, 925);
            this.Editbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(216, 81);
            this.Editbutton.TabIndex = 53;
            this.Editbutton.Text = "Save Edit";
            this.Editbutton.UseVisualStyleBackColor = false;
            this.Editbutton.Click += new System.EventHandler(this.Editbutton_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1605, 1068);
            this.Controls.Add(this.Editbutton);
            this.Controls.Add(this.skewdroplabel);
            this.Controls.Add(this.skewlabel);
            this.Controls.Add(this.Productbox);
            this.Controls.Add(this.OrderIDRanLabel);
            this.Controls.Add(this.OrderIDLabel);
            this.Controls.Add(this.Descriptionbox);
            this.Controls.Add(this.Descriplabel);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.qtynumchoice);
            this.Controls.Add(this.amountlabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Datelabel);
            this.Controls.Add(this.UPbox);
            this.Controls.Add(this.UPlabel);
            this.Controls.Add(this.QtyLabel);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.Supplierbox);
            this.Controls.Add(this.SupplierLabel);
            this.Controls.Add(this.ProductLabel);
            this.Controls.Add(this.amounttxtbox);
            this.Controls.Add(this.OrderTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OrderForm";
            this.Text = "Add Order";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qtynumchoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SupplierLabel;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.Label OrderTitle;
        private System.Windows.Forms.Label QtyLabel;
        private System.Windows.Forms.Label UPlabel;
        private System.Windows.Forms.Label Datelabel;
        private System.Windows.Forms.Label amountlabel;
        public System.Windows.Forms.Button Addbutton;
        public System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Label Descriplabel;
        private System.Windows.Forms.Label OrderIDLabel;
        private System.Windows.Forms.Label skewlabel;
        public System.Windows.Forms.ComboBox Supplierbox;
        public System.Windows.Forms.TextBox UPbox;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.NumericUpDown qtynumchoice;
        public System.Windows.Forms.TextBox amounttxtbox;
        public System.Windows.Forms.TextBox Descriptionbox;
        public System.Windows.Forms.Label OrderIDRanLabel;
        public System.Windows.Forms.TextBox Productbox;
        public System.Windows.Forms.Label skewdroplabel;
        private System.Windows.Forms.Button Editbutton;
    }
}