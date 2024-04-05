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
            this.ApproveButton = new System.Windows.Forms.Button();
            this.OrderIDLabel = new System.Windows.Forms.Label();
            this.OrderTitle = new System.Windows.Forms.Label();
            this.PendingOrderButton = new System.Windows.Forms.DataGridView();
            this.orderidbox = new System.Windows.Forms.TextBox();
            this.amountbox = new System.Windows.Forms.TextBox();
            this.QtyLabel = new System.Windows.Forms.Label();
            this.UPbox = new System.Windows.Forms.TextBox();
            this.Datelabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Supplierbox = new System.Windows.Forms.ComboBox();
            this.Supplierbutton = new System.Windows.Forms.Label();
            this.UPlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Editbutton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PendingOrderButton)).BeginInit();
            this.SuspendLayout();
            // 
            // ApproveButton
            // 
            this.ApproveButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ApproveButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApproveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ApproveButton.Location = new System.Drawing.Point(1325, 294);
            this.ApproveButton.Name = "ApproveButton";
            this.ApproveButton.Size = new System.Drawing.Size(258, 81);
            this.ApproveButton.TabIndex = 40;
            this.ApproveButton.Text = "Approve";
            this.ApproveButton.UseVisualStyleBackColor = false;
            // 
            // OrderIDLabel
            // 
            this.OrderIDLabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderIDLabel.Location = new System.Drawing.Point(16, 107);
            this.OrderIDLabel.Name = "OrderIDLabel";
            this.OrderIDLabel.Size = new System.Drawing.Size(173, 46);
            this.OrderIDLabel.TabIndex = 37;
            this.OrderIDLabel.Text = "OrderID";
            // 
            // OrderTitle
            // 
            this.OrderTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OrderTitle.Location = new System.Drawing.Point(11, 11);
            this.OrderTitle.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.OrderTitle.Name = "OrderTitle";
            this.OrderTitle.Size = new System.Drawing.Size(490, 96);
            this.OrderTitle.TabIndex = 35;
            this.OrderTitle.Text = "Approve Orders";
            this.OrderTitle.Click += new System.EventHandler(this.OrderTitle_Click);
            // 
            // PendingOrderButton
            // 
            this.PendingOrderButton.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PendingOrderButton.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PendingOrderButton.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PendingOrderButton.Location = new System.Drawing.Point(12, 398);
            this.PendingOrderButton.Name = "PendingOrderButton";
            this.PendingOrderButton.RowHeadersWidth = 102;
            this.PendingOrderButton.RowTemplate.Height = 40;
            this.PendingOrderButton.Size = new System.Drawing.Size(1571, 628);
            this.PendingOrderButton.TabIndex = 41;
            // 
            // orderidbox
            // 
            this.orderidbox.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderidbox.Location = new System.Drawing.Point(23, 155);
            this.orderidbox.Name = "orderidbox";
            this.orderidbox.Size = new System.Drawing.Size(308, 62);
            this.orderidbox.TabIndex = 51;
            // 
            // amountbox
            // 
            this.amountbox.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountbox.Location = new System.Drawing.Point(23, 303);
            this.amountbox.Name = "amountbox";
            this.amountbox.Size = new System.Drawing.Size(308, 62);
            this.amountbox.TabIndex = 36;
            // 
            // QtyLabel
            // 
            this.QtyLabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtyLabel.Location = new System.Drawing.Point(16, 254);
            this.QtyLabel.Name = "QtyLabel";
            this.QtyLabel.Size = new System.Drawing.Size(173, 46);
            this.QtyLabel.TabIndex = 44;
            this.QtyLabel.Text = "Qty";
            // 
            // UPbox
            // 
            this.UPbox.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPbox.Location = new System.Drawing.Point(365, 303);
            this.UPbox.Name = "UPbox";
            this.UPbox.Size = new System.Drawing.Size(308, 62);
            this.UPbox.TabIndex = 46;
            // 
            // Datelabel
            // 
            this.Datelabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelabel.Location = new System.Drawing.Point(759, 107);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(173, 46);
            this.Datelabel.TabIndex = 47;
            this.Datelabel.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM dd yyyy hh:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(766, 169);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 38);
            this.dateTimePicker1.TabIndex = 48;
            // 
            // Supplierbox
            // 
            this.Supplierbox.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplierbox.FormattingEnabled = true;
            this.Supplierbox.Location = new System.Drawing.Point(380, 156);
            this.Supplierbox.Name = "Supplierbox";
            this.Supplierbox.Size = new System.Drawing.Size(323, 61);
            this.Supplierbox.TabIndex = 39;
            // 
            // Supplierbutton
            // 
            this.Supplierbutton.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplierbutton.Location = new System.Drawing.Point(373, 107);
            this.Supplierbutton.Name = "Supplierbutton";
            this.Supplierbutton.Size = new System.Drawing.Size(222, 46);
            this.Supplierbutton.TabIndex = 38;
            this.Supplierbutton.Text = "Supplier";
            // 
            // UPlabel
            // 
            this.UPlabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPlabel.Location = new System.Drawing.Point(358, 254);
            this.UPlabel.Name = "UPlabel";
            this.UPlabel.Size = new System.Drawing.Size(173, 46);
            this.UPlabel.TabIndex = 45;
            this.UPlabel.Text = "Unit Price";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(710, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 46);
            this.label1.TabIndex = 50;
            this.label1.Text = "Amount";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(717, 303);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 62);
            this.textBox1.TabIndex = 49;
            // 
            // Editbutton
            // 
            this.Editbutton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Editbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Editbutton.Location = new System.Drawing.Point(1325, 169);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(258, 81);
            this.Editbutton.TabIndex = 52;
            this.Editbutton.Text = "Edit";
            this.Editbutton.UseVisualStyleBackColor = false;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackButton.Location = new System.Drawing.Point(1325, 26);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(258, 81);
            this.BackButton.TabIndex = 53;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ApproveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1604, 1142);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.Editbutton);
            this.Controls.Add(this.orderidbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Datelabel);
            this.Controls.Add(this.UPbox);
            this.Controls.Add(this.UPlabel);
            this.Controls.Add(this.QtyLabel);
            this.Controls.Add(this.PendingOrderButton);
            this.Controls.Add(this.ApproveButton);
            this.Controls.Add(this.Supplierbox);
            this.Controls.Add(this.Supplierbutton);
            this.Controls.Add(this.OrderIDLabel);
            this.Controls.Add(this.amountbox);
            this.Controls.Add(this.OrderTitle);
            this.Name = "ApproveForm";
            this.Text = "ApproveOrder";
            this.Load += new System.EventHandler(this.ApproveForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PendingOrderButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ApproveButton;
        private System.Windows.Forms.Label OrderIDLabel;
        private System.Windows.Forms.Label OrderTitle;
        private System.Windows.Forms.DataGridView PendingOrderButton;
        private System.Windows.Forms.TextBox orderidbox;
        private System.Windows.Forms.TextBox amountbox;
        private System.Windows.Forms.Label QtyLabel;
        private System.Windows.Forms.TextBox UPbox;
        private System.Windows.Forms.Label Datelabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox Supplierbox;
        private System.Windows.Forms.Label Supplierbutton;
        private System.Windows.Forms.Label UPlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Editbutton;
        private System.Windows.Forms.Button BackButton;
    }
}