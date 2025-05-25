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
            label1 = new Label();
            cmbUserFilter = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrderReports).BeginInit();
            SuspendLayout();
            // 
            // dgvOrderReports
            // 
            dgvOrderReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderReports.Location = new Point(38, 54);
            dgvOrderReports.Name = "dgvOrderReports";
            dgvOrderReports.Size = new Size(804, 288);
            dgvOrderReports.TabIndex = 0;
            // 
            // lblTotalOrders
            // 
            lblTotalOrders.AutoSize = true;
            lblTotalOrders.Location = new Point(38, 357);
            lblTotalOrders.Name = "lblTotalOrders";
            lblTotalOrders.Size = new Size(38, 15);
            lblTotalOrders.TabIndex = 1;
            lblTotalOrders.Text = "label1";
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.Location = new Point(38, 395);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(38, 15);
            lblTotalRevenue.TabIndex = 2;
            lblTotalRevenue.Text = "label1";
            // 
            // lblPaidOrders
            // 
            lblPaidOrders.AutoSize = true;
            lblPaidOrders.Location = new Point(38, 430);
            lblPaidOrders.Name = "lblPaidOrders";
            lblPaidOrders.Size = new Size(38, 15);
            lblPaidOrders.TabIndex = 3;
            lblPaidOrders.Text = "label1";
            // 
            // cmbOrderFilter
            // 
            cmbOrderFilter.FormattingEnabled = true;
            cmbOrderFilter.Location = new Point(124, 25);
            cmbOrderFilter.Name = "cmbOrderFilter";
            cmbOrderFilter.Size = new Size(121, 23);
            cmbOrderFilter.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(40, 26);
            label1.Name = "label1";
            label1.Size = new Size(78, 17);
            label1.TabIndex = 6;
            label1.Text = "Filtreleme :";
            // 
            // cmbUserFilter
            // 
            cmbUserFilter.FormattingEnabled = true;
            cmbUserFilter.Location = new Point(266, 25);
            cmbUserFilter.Name = "cmbUserFilter";
            cmbUserFilter.Size = new Size(121, 23);
            cmbUserFilter.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 9);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 8;
            label2.Text = "Zaman";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 9);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 9;
            label3.Text = "Kullanıcı";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(906, 463);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbUserFilter);
            Controls.Add(label1);
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
        private Label label1;
        private ComboBox cmbUserFilter;
        private Label label2;
        private Label label3;
    }
}