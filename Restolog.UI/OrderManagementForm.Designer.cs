namespace Restolog.UI
{
    partial class OrderManagementForm
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
            panel1 = new Panel();
            panel4 = new Panel();
            lblRole = new Label();
            lblUsername = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnReturn = new Button();
            btnLogout = new Button();
            label2 = new Label();
            btnOrderSave = new Button();
            btnOrderDelete = new Button();
            pnlTable = new Panel();
            label1 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            label9 = new Label();
            label8 = new Label();
            cmbTableStatus = new ComboBox();
            cmbOrderStatus = new ComboBox();
            label7 = new Label();
            txtSearch = new TextBox();
            btnApply = new Button();
            splitContainer1 = new SplitContainer();
            PanelProductMenu = new SplitContainer();
            panelProduct = new FlowLayoutPanel();
            panelProductCaregory = new FlowLayoutPanel();
            dgOrderItems = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            label10 = new Label();
            lblTotal = new Label();
            ItemId = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PanelProductMenu).BeginInit();
            PanelProductMenu.Panel1.SuspendLayout();
            PanelProductMenu.Panel2.SuspendLayout();
            PanelProductMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgOrderItems).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(btnReturn);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(169, 500);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.AliceBlue;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblRole);
            panel4.Controls.Add(lblUsername);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(3, 20);
            panel4.Name = "panel4";
            panel4.Size = new Size(161, 58);
            panel4.TabIndex = 13;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblRole.Location = new Point(80, 37);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(31, 13);
            lblRole.TabIndex = 12;
            lblRole.Text = "Rolü";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblUsername.Location = new Point(80, 19);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(24, 13);
            lblUsername.TabIndex = 11;
            lblUsername.Text = "Adı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(42, 37);
            label6.Name = "label6";
            label6.Size = new Size(37, 13);
            label6.TabIndex = 10;
            label6.Text = "Rolü :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(3, 19);
            label5.Name = "label5";
            label5.Size = new Size(76, 13);
            label5.TabIndex = 9;
            label5.Text = "Kullanıcı Adı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(-1, 0);
            label4.Name = "label4";
            label4.Size = new Size(116, 13);
            label4.TabIndex = 7;
            label4.Text = "Aktif Kullanıcı Bilgiler";
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.SteelBlue;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnReturn.Location = new Point(3, 384);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(161, 41);
            btnReturn.TabIndex = 7;
            btnReturn.Text = "Önceki Sayfaya Dön";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Firebrick;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnLogout.Location = new Point(3, 431);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(161, 41);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Çıkış Yap";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(-1, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 17);
            label2.TabIndex = 6;
            label2.Text = "İşlemler";
            // 
            // btnOrderSave
            // 
            btnOrderSave.BackColor = Color.DodgerBlue;
            btnOrderSave.Dock = DockStyle.Fill;
            btnOrderSave.FlatStyle = FlatStyle.Flat;
            btnOrderSave.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOrderSave.Location = new Point(200, 73);
            btnOrderSave.Name = "btnOrderSave";
            btnOrderSave.Size = new Size(191, 31);
            btnOrderSave.TabIndex = 12;
            btnOrderSave.Text = "Siparişi Tamamla";
            btnOrderSave.UseVisualStyleBackColor = false;
            btnOrderSave.Click += btnOrderSave_Click;
            // 
            // btnOrderDelete
            // 
            btnOrderDelete.BackColor = Color.Firebrick;
            btnOrderDelete.Dock = DockStyle.Fill;
            btnOrderDelete.FlatStyle = FlatStyle.Flat;
            btnOrderDelete.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOrderDelete.Location = new Point(3, 73);
            btnOrderDelete.Name = "btnOrderDelete";
            btnOrderDelete.Size = new Size(191, 31);
            btnOrderDelete.TabIndex = 9;
            btnOrderDelete.Text = "Sipariş Sil";
            btnOrderDelete.UseVisualStyleBackColor = false;
            // 
            // pnlTable
            // 
            pnlTable.BorderStyle = BorderStyle.FixedSingle;
            pnlTable.Location = new Point(4, 78);
            pnlTable.Name = "pnlTable";
            pnlTable.Size = new Size(262, 343);
            pnlTable.TabIndex = 1;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(969, 21);
            label1.TabIndex = 5;
            label1.Text = "Sipariş Yönetim Paneli";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 17);
            label3.TabIndex = 7;
            label3.Text = "Filtreleme";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(cmbTableStatus);
            panel3.Controls.Add(cmbOrderStatus);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txtSearch);
            panel3.Controls.Add(btnApply);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(796, 72);
            panel3.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.Location = new Point(144, 25);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.Yes;
            label9.Size = new Size(79, 13);
            label9.TabIndex = 36;
            label9.Text = "Masa Durumu";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.Location = new Point(3, 25);
            label8.Name = "label8";
            label8.Size = new Size(86, 13);
            label8.TabIndex = 35;
            label8.Text = "Sipariş Durumu";
            // 
            // cmbTableStatus
            // 
            cmbTableStatus.FormattingEnabled = true;
            cmbTableStatus.Location = new Point(144, 41);
            cmbTableStatus.Name = "cmbTableStatus";
            cmbTableStatus.Size = new Size(121, 23);
            cmbTableStatus.TabIndex = 34;
            // 
            // cmbOrderStatus
            // 
            cmbOrderStatus.FormattingEnabled = true;
            cmbOrderStatus.Location = new Point(3, 41);
            cmbOrderStatus.Name = "cmbOrderStatus";
            cmbOrderStatus.Size = new Size(121, 23);
            cmbOrderStatus.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(338, 15);
            label7.Name = "label7";
            label7.Size = new Size(35, 21);
            label7.TabIndex = 32;
            label7.Text = "Ara";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.ScrollBar;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtSearch.Location = new Point(338, 41);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(151, 23);
            txtSearch.TabIndex = 31;
            // 
            // btnApply
            // 
            btnApply.BackColor = Color.Green;
            btnApply.FlatStyle = FlatStyle.Flat;
            btnApply.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnApply.Location = new Point(526, 41);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(71, 23);
            btnApply.TabIndex = 30;
            btnApply.Text = "Uygula";
            btnApply.UseVisualStyleBackColor = false;
            btnApply.Click += btnApply_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 21);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(PanelProductMenu);
            splitContainer1.Panel2.Controls.Add(panel3);
            splitContainer1.Panel2.Controls.Add(pnlTable);
            splitContainer1.Size = new Size(969, 500);
            splitContainer1.SplitterDistance = 169;
            splitContainer1.TabIndex = 6;
            // 
            // PanelProductMenu
            // 
            PanelProductMenu.Dock = DockStyle.Fill;
            PanelProductMenu.Location = new Point(0, 72);
            PanelProductMenu.Name = "PanelProductMenu";
            // 
            // PanelProductMenu.Panel1
            // 
            PanelProductMenu.Panel1.Controls.Add(panelProduct);
            PanelProductMenu.Panel1.Controls.Add(panelProductCaregory);
            // 
            // PanelProductMenu.Panel2
            // 
            PanelProductMenu.Panel2.Controls.Add(dgOrderItems);
            PanelProductMenu.Panel2.Controls.Add(tableLayoutPanel1);
            PanelProductMenu.Size = new Size(796, 428);
            PanelProductMenu.SplitterDistance = 398;
            PanelProductMenu.TabIndex = 3;
            PanelProductMenu.Visible = false;
            PanelProductMenu.SplitterMoved += PanelProductMenu_SplitterMoved;
            // 
            // panelProduct
            // 
            panelProduct.BackColor = Color.LightSkyBlue;
            panelProduct.Dock = DockStyle.Fill;
            panelProduct.Location = new Point(0, 61);
            panelProduct.Name = "panelProduct";
            panelProduct.Size = new Size(398, 367);
            panelProduct.TabIndex = 0;
            // 
            // panelProductCaregory
            // 
            panelProductCaregory.BackColor = Color.CadetBlue;
            panelProductCaregory.Dock = DockStyle.Top;
            panelProductCaregory.Location = new Point(0, 0);
            panelProductCaregory.Name = "panelProductCaregory";
            panelProductCaregory.Size = new Size(398, 61);
            panelProductCaregory.TabIndex = 1;
            // 
            // dgOrderItems
            // 
            dgOrderItems.AllowUserToAddRows = false;
            dgOrderItems.AllowUserToDeleteRows = false;
            dgOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgOrderItems.Columns.AddRange(new DataGridViewColumn[] { ItemId, ProductName, Quantity, UnitPrice, SubTotal });
            dgOrderItems.Dock = DockStyle.Fill;
            dgOrderItems.Location = new Point(0, 0);
            dgOrderItems.Name = "dgOrderItems";
            dgOrderItems.ReadOnly = true;
            dgOrderItems.RowHeadersVisible = false;
            dgOrderItems.Size = new Size(394, 321);
            dgOrderItems.TabIndex = 0;
            dgOrderItems.CellClick += dgOrderItems_CellClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(btnOrderSave, 1, 2);
            tableLayoutPanel1.Controls.Add(btnOrderDelete, 0, 2);
            tableLayoutPanel1.Controls.Add(label10, 0, 1);
            tableLayoutPanel1.Controls.Add(lblTotal, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 321);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Size = new Size(394, 107);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Dock = DockStyle.Fill;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.FromArgb(224, 224, 224);
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(191, 29);
            button1.TabIndex = 15;
            button1.Text = "Ürün Sil";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label10.Location = new Point(3, 35);
            label10.Name = "label10";
            label10.Size = new Size(191, 35);
            label10.TabIndex = 13;
            label10.Text = "Toplam";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            lblTotal.Dock = DockStyle.Fill;
            lblTotal.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            lblTotal.Location = new Point(200, 35);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(191, 35);
            lblTotal.TabIndex = 14;
            lblTotal.Text = "999,99";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ItemId
            // 
            ItemId.DataPropertyName = "Id";
            ItemId.HeaderText = "ItemId";
            ItemId.Name = "ItemId";
            ItemId.ReadOnly = true;
            ItemId.Visible = false;
            // 
            // ProductName
            // 
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "Product Name";
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // UnitPrice
            // 
            UnitPrice.DataPropertyName = "UnitPrice";
            UnitPrice.HeaderText = "UnitPrice";
            UnitPrice.Name = "UnitPrice";
            UnitPrice.ReadOnly = true;
            // 
            // SubTotal
            // 
            SubTotal.DataPropertyName = "SubTotal";
            SubTotal.HeaderText = "SubTotal";
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            // 
            // OrderManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(969, 521);
            Controls.Add(splitContainer1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "OrderManagementForm";
            Text = "Sipariş Yönetimi";
            Load += OrderManagementForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            PanelProductMenu.Panel1.ResumeLayout(false);
            PanelProductMenu.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PanelProductMenu).EndInit();
            PanelProductMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgOrderItems).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlTable;
        private Label label1;
        private Label label2;
        private Button btnLogout;
        private Button btnReturn;
        private Button btnOrderDelete;
        private Label label3;
        private Panel panel3;
        private Label label7;
        private TextBox txtSearch;
        private Button btnApply;
        private Button btnOrderSave;
        private Panel panel4;
        private Label lblRole;
        private Label lblUsername;
        private Label label5;
        private Label label4;
        private Label label6;
        private ComboBox cmbOrderStatus;
        private ComboBox cmbTableStatus;
        private Label label8;
        private Label label9;
        private SplitContainer splitContainer1;
        private SplitContainer PanelProductMenu;
        private FlowLayoutPanel panelProductCaregory;
        private FlowLayoutPanel panelProduct;
        private DataGridView dgOrderItems;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label10;
        private Label lblTotal;
        private Button button1;
        private DataGridViewTextBoxColumn ItemId;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn SubTotal;
    }
}