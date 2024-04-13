namespace ProjectInventory
{
    partial class PrintPreview
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
            this.bottompanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.requisition_approvalTableAdapter1 = new ProjectInventory.InventoryDBDataSetTableAdapters.requisition_approvalTableAdapter();
            this.requisition_approvalTableAdapter2 = new ProjectInventory.InventoryDBDataSetTableAdapters.requisition_approvalTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bottompanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bottompanel
            // 
            this.bottompanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bottompanel.Controls.Add(this.TitleLabel);
            this.bottompanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bottompanel.Location = new System.Drawing.Point(0, 0);
            this.bottompanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bottompanel.Name = "bottompanel";
            this.bottompanel.Size = new System.Drawing.Size(1161, 119);
            this.bottompanel.TabIndex = 66;
            this.bottompanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bottompanel_Paint);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(32, 36);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(216, 38);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Print Preview";
            this.TitleLabel.Click += new System.EventHandler(this.BottomLabel_Click);
            // 
            // requisition_approvalTableAdapter1
            // 
            this.requisition_approvalTableAdapter1.ClearBeforeFill = true;
            // 
            // requisition_approvalTableAdapter2
            // 
            this.requisition_approvalTableAdapter2.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 119);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1161, 1174);
            this.reportViewer1.TabIndex = 67;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // PrintPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 1293);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.bottompanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrintPreview";
            this.Text = "PrintPreview";
            this.Load += new System.EventHandler(this.PrintPreview_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrintPreview_KeyDown);
            this.bottompanel.ResumeLayout(false);
            this.bottompanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bottompanel;
        private System.Windows.Forms.Label TitleLabel;
        private InventoryDBDataSetTableAdapters.requisition_approvalTableAdapter requisition_approvalTableAdapter1;
        private InventoryDBDataSetTableAdapters.requisition_approvalTableAdapter requisition_approvalTableAdapter2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}