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
            this.Supplierbutton = new System.Windows.Forms.Label();
            this.ProductButton = new System.Windows.Forms.Label();
            this.qtytxtbox = new System.Windows.Forms.TextBox();
            this.OrderTitle = new System.Windows.Forms.Label();
            this.PendingOrderButton = new System.Windows.Forms.DataGridView();
            this.Addbutton = new System.Windows.Forms.Button();
            this.productbox = new System.Windows.Forms.ComboBox();
            this.QtyLabel = new System.Windows.Forms.Label();
            this.UPlabel = new System.Windows.Forms.Label();
            this.UPbox = new System.Windows.Forms.TextBox();
            this.Datelabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.amountlabel = new System.Windows.Forms.Label();
            this.amountxtbox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PendingOrderButton)).BeginInit();
            this.SuspendLayout();
            // 
            // Supplierbox
            // 
            this.Supplierbox.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplierbox.FormattingEnabled = true;
            this.Supplierbox.Location = new System.Drawing.Point(388, 153);
            this.Supplierbox.Name = "Supplierbox";
            this.Supplierbox.Size = new System.Drawing.Size(323, 61);
            this.Supplierbox.TabIndex = 23;
            // 
            // Supplierbutton
            // 
            this.Supplierbutton.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplierbutton.Location = new System.Drawing.Point(381, 104);
            this.Supplierbutton.Name = "Supplierbutton";
            this.Supplierbutton.Size = new System.Drawing.Size(222, 46);
            this.Supplierbutton.TabIndex = 22;
            this.Supplierbutton.Text = "Supplier";
            this.Supplierbutton.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // ProductButton
            // 
            this.ProductButton.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductButton.Location = new System.Drawing.Point(24, 104);
            this.ProductButton.Name = "ProductButton";
            this.ProductButton.Size = new System.Drawing.Size(173, 46);
            this.ProductButton.TabIndex = 21;
            this.ProductButton.Text = "Product";
            this.ProductButton.Click += new System.EventHandler(this.OrderLabel_Click);
            // 
            // qtytxtbox
            // 
            this.qtytxtbox.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtytxtbox.Location = new System.Drawing.Point(31, 300);
            this.qtytxtbox.Name = "qtytxtbox";
            this.qtytxtbox.Size = new System.Drawing.Size(308, 62);
            this.qtytxtbox.TabIndex = 20;
            // 
            // OrderTitle
            // 
            this.OrderTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OrderTitle.Location = new System.Drawing.Point(3, 9);
            this.OrderTitle.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.OrderTitle.Name = "OrderTitle";
            this.OrderTitle.Size = new System.Drawing.Size(490, 96);
            this.OrderTitle.TabIndex = 19;
            this.OrderTitle.Text = "NEW ORDER";
            this.OrderTitle.Click += new System.EventHandler(this.OrderTitle_Click);
            // 
            // PendingOrderButton
            // 
            this.PendingOrderButton.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PendingOrderButton.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PendingOrderButton.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PendingOrderButton.Location = new System.Drawing.Point(15, 381);
            this.PendingOrderButton.Name = "PendingOrderButton";
            this.PendingOrderButton.RowHeadersWidth = 102;
            this.PendingOrderButton.RowTemplate.Height = 40;
            this.PendingOrderButton.Size = new System.Drawing.Size(1571, 647);
            this.PendingOrderButton.TabIndex = 25;
            // 
            // Addbutton
            // 
            this.Addbutton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Addbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Addbutton.Location = new System.Drawing.Point(1328, 281);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(258, 81);
            this.Addbutton.TabIndex = 26;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = false;
            // 
            // productbox
            // 
            this.productbox.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productbox.FormattingEnabled = true;
            this.productbox.Location = new System.Drawing.Point(31, 153);
            this.productbox.Name = "productbox";
            this.productbox.Size = new System.Drawing.Size(323, 61);
            this.productbox.TabIndex = 27;
            this.productbox.SelectedIndexChanged += new System.EventHandler(this.productbox_SelectedIndexChanged);
            // 
            // QtyLabel
            // 
            this.QtyLabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtyLabel.Location = new System.Drawing.Point(24, 251);
            this.QtyLabel.Name = "QtyLabel";
            this.QtyLabel.Size = new System.Drawing.Size(173, 46);
            this.QtyLabel.TabIndex = 28;
            this.QtyLabel.Text = "Qty";
            // 
            // UPlabel
            // 
            this.UPlabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPlabel.Location = new System.Drawing.Point(366, 251);
            this.UPlabel.Name = "UPlabel";
            this.UPlabel.Size = new System.Drawing.Size(173, 46);
            this.UPlabel.TabIndex = 29;
            this.UPlabel.Text = "Unit Price";
            // 
            // UPbox
            // 
            this.UPbox.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPbox.Location = new System.Drawing.Point(373, 300);
            this.UPbox.Name = "UPbox";
            this.UPbox.Size = new System.Drawing.Size(308, 62);
            this.UPbox.TabIndex = 30;
            // 
            // Datelabel
            // 
            this.Datelabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelabel.Location = new System.Drawing.Point(767, 104);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(173, 46);
            this.Datelabel.TabIndex = 31;
            this.Datelabel.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM dd yyyy hh:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(774, 166);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 38);
            this.dateTimePicker1.TabIndex = 32;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // amountlabel
            // 
            this.amountlabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountlabel.Location = new System.Drawing.Point(718, 251);
            this.amountlabel.Name = "amountlabel";
            this.amountlabel.Size = new System.Drawing.Size(173, 46);
            this.amountlabel.TabIndex = 34;
            this.amountlabel.Text = "Amount";
            this.amountlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // amountxtbox
            // 
            this.amountxtbox.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountxtbox.Location = new System.Drawing.Point(725, 300);
            this.amountxtbox.Name = "amountxtbox";
            this.amountxtbox.Size = new System.Drawing.Size(308, 62);
            this.amountxtbox.TabIndex = 33;
            this.amountxtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackButton.Location = new System.Drawing.Point(1334, 24);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(258, 81);
            this.BackButton.TabIndex = 35;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1604, 1142);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.amountlabel);
            this.Controls.Add(this.amountxtbox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Datelabel);
            this.Controls.Add(this.UPbox);
            this.Controls.Add(this.UPlabel);
            this.Controls.Add(this.QtyLabel);
            this.Controls.Add(this.productbox);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.PendingOrderButton);
            this.Controls.Add(this.Supplierbox);
            this.Controls.Add(this.Supplierbutton);
            this.Controls.Add(this.ProductButton);
            this.Controls.Add(this.qtytxtbox);
            this.Controls.Add(this.OrderTitle);
            this.Name = "OrderForm";
            this.Text = "Add Order";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PendingOrderButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Supplierbox;
        private System.Windows.Forms.Label Supplierbutton;
        private System.Windows.Forms.Label ProductButton;
        private System.Windows.Forms.TextBox qtytxtbox;
        private System.Windows.Forms.Label OrderTitle;
        private System.Windows.Forms.DataGridView PendingOrderButton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.ComboBox productbox;
        private System.Windows.Forms.Label QtyLabel;
        private System.Windows.Forms.Label UPlabel;
        private System.Windows.Forms.TextBox UPbox;
        private System.Windows.Forms.Label Datelabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label amountlabel;
        private System.Windows.Forms.TextBox amountxtbox;
        private System.Windows.Forms.Button BackButton;
    }
}