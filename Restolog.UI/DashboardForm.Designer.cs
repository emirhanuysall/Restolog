namespace Restolog.UI
{
    partial class DashboardForm
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
            dgvOrderReports = new DataGridView();
            lblTotalOrders = new Label();
            lblTotalRevenue = new Label();
            lblPaidOrders = new Label();
            cmbOrderFilter = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvOrderReports).BeginInit();
            SuspendLayout();
            // 
            // dgvOrderReports
            // 
            dgvOrderReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderReports.Location = new Point(34, 42);
            dgvOrderReports.Name = "dgvOrderReports";
            dgvOrderReports.Size = new Size(647, 308);
            dgvOrderReports.TabIndex = 0;
            // 
            // lblTotalOrders
            // 
            lblTotalOrders.AutoSize = true;
            lblTotalOrders.Location = new Point(724, 42);
            lblTotalOrders.Name = "lblTotalOrders";
            lblTotalOrders.Size = new Size(38, 15);
            lblTotalOrders.TabIndex = 1;
            lblTotalOrders.Text = "label1";
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.Location = new Point(724, 85);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(38, 15);
            lblTotalRevenue.TabIndex = 2;
            lblTotalRevenue.Text = "label1";
            // 
            // lblPaidOrders
            // 
            lblPaidOrders.AutoSize = true;
            lblPaidOrders.Location = new Point(724, 131);
            lblPaidOrders.Name = "lblPaidOrders";
            lblPaidOrders.Size = new Size(38, 15);
            lblPaidOrders.TabIndex = 3;
            lblPaidOrders.Text = "label1";
            // 
            // cmbOrderFilter
            // 
            cmbOrderFilter.FormattingEnabled = true;
            cmbOrderFilter.Location = new Point(34, 12);
            cmbOrderFilter.Name = "cmbOrderFilter";
            cmbOrderFilter.Size = new Size(121, 23);
            cmbOrderFilter.TabIndex = 5;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(906, 463);
            Controls.Add(cmbOrderFilter);
            Controls.Add(lblPaidOrders);
            Controls.Add(lblTotalRevenue);
            Controls.Add(lblTotalOrders);
            Controls.Add(dgvOrderReports);
            Name = "DashboardForm";
            Text = "DashboardForm";
            ((System.ComponentModel.ISupportInitialize)dgvOrderReports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrderReports;
        private Label lblTotalOrders;
        private Label lblTotalRevenue;
        private Label lblPaidOrders;
        private ComboBox cmbOrderFilter;
    }
}