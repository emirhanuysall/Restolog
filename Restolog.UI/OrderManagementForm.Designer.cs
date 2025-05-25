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
            label2 = new Label();
            btnOrderSave = new Button();
            btnOrderDelete = new Button();
            pnlTable = new Panel();
            label1 = new Label();
            label3 = new Label();
            pnlFilter = new Panel();
            label9 = new Label();
            cmbTableStatus = new ComboBox();
            label7 = new Label();
            txtSearch = new TextBox();
            btnApply = new Button();
            pnlMain = new SplitContainer();
            PanelProductMenu = new SplitContainer();
            panelProduct = new FlowLayoutPanel();
            panelProductCaregory = new FlowLayoutPanel();
            dgOrderItems = new DataGridView();
            ItemNo = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnDeleteProduct = new Button();
            button1 = new Button();
            label10 = new Label();
            lblTotal = new Label();
            pnlTableInfo = new Panel();
            btnReturn = new Button();
            btnLogout = new Button();
            lblCurrenTable = new Label();
            label12 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlMain).BeginInit();
            pnlMain.Panel1.SuspendLayout();
            pnlMain.Panel2.SuspendLayout();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PanelProductMenu).BeginInit();
            PanelProductMenu.Panel1.SuspendLayout();
            PanelProductMenu.Panel2.SuspendLayout();
            PanelProductMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgOrderItems).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            pnlTableInfo.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 100);
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
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 17);
            panel4.Name = "panel4";
            panel4.Size = new Size(223, 82);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(0, 0);
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
            btnOrderSave.ForeColor = Color.FromArgb(224, 224, 224);
            btnOrderSave.Location = new Point(223, 73);
            btnOrderSave.Name = "btnOrderSave";
            btnOrderSave.Size = new Size(215, 31);
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
            btnOrderDelete.ForeColor = Color.FromArgb(224, 224, 224);
            btnOrderDelete.Location = new Point(3, 73);
            btnOrderDelete.Name = "btnOrderDelete";
            btnOrderDelete.Size = new Size(214, 31);
            btnOrderDelete.TabIndex = 9;
            btnOrderDelete.Text = "Sipariş Sil";
            btnOrderDelete.UseVisualStyleBackColor = false;
            btnOrderDelete.Click += btnOrderDelete_Click;
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
            label1.Size = new Size(1264, 21);
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
            // pnlFilter
            // 
            pnlFilter.BorderStyle = BorderStyle.FixedSingle;
            pnlFilter.Controls.Add(label9);
            pnlFilter.Controls.Add(cmbTableStatus);
            pnlFilter.Controls.Add(label7);
            pnlFilter.Controls.Add(txtSearch);
            pnlFilter.Controls.Add(btnApply);
            pnlFilter.Controls.Add(label3);
            pnlFilter.Dock = DockStyle.Top;
            pnlFilter.Location = new Point(0, 35);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(1264, 72);
            pnlFilter.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.Location = new Point(3, 26);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.Yes;
            label9.Size = new Size(79, 13);
            label9.TabIndex = 36;
            label9.Text = "Masa Durumu";
            // 
            // cmbTableStatus
            // 
            cmbTableStatus.FormattingEnabled = true;
            cmbTableStatus.Location = new Point(3, 42);
            cmbTableStatus.Name = "cmbTableStatus";
            cmbTableStatus.Size = new Size(121, 23);
            cmbTableStatus.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(197, 16);
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
            txtSearch.Location = new Point(197, 42);
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
            btnApply.ForeColor = Color.FromArgb(224, 224, 224);
            btnApply.Location = new Point(385, 42);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(71, 23);
            btnApply.TabIndex = 30;
            btnApply.Text = "Uygula";
            btnApply.UseVisualStyleBackColor = false;
            btnApply.Click += btnApply_Click;
            // 
            // pnlMain
            // 
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 21);
            pnlMain.Name = "pnlMain";
            // 
            // pnlMain.Panel1
            // 
            pnlMain.Panel1.Controls.Add(panel1);
            pnlMain.Panel1Collapsed = true;
            // 
            // pnlMain.Panel2
            // 
            pnlMain.Panel2.Controls.Add(PanelProductMenu);
            pnlMain.Panel2.Controls.Add(pnlFilter);
            pnlMain.Panel2.Controls.Add(pnlTable);
            pnlMain.Panel2.Controls.Add(pnlTableInfo);
            pnlMain.Size = new Size(1264, 708);
            pnlMain.SplitterDistance = 225;
            pnlMain.TabIndex = 6;
            // 
            // PanelProductMenu
            // 
            PanelProductMenu.Dock = DockStyle.Fill;
            PanelProductMenu.Location = new Point(0, 107);
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
            PanelProductMenu.Size = new Size(1264, 601);
            PanelProductMenu.SplitterDistance = 819;
            PanelProductMenu.TabIndex = 3;
            PanelProductMenu.Visible = false;
            PanelProductMenu.SplitterMoved += PanelProductMenu_SplitterMoved;
            // 
            // panelProduct
            // 
            panelProduct.BackColor = Color.LightSteelBlue;
            panelProduct.Dock = DockStyle.Fill;
            panelProduct.Location = new Point(0, 66);
            panelProduct.Name = "panelProduct";
            panelProduct.Size = new Size(819, 535);
            panelProduct.TabIndex = 0;
            // 
            // panelProductCaregory
            // 
            panelProductCaregory.AutoScroll = true;
            panelProductCaregory.BackColor = Color.LightSteelBlue;
            panelProductCaregory.Dock = DockStyle.Top;
            panelProductCaregory.Location = new Point(0, 0);
            panelProductCaregory.Name = "panelProductCaregory";
            panelProductCaregory.Size = new Size(819, 66);
            panelProductCaregory.TabIndex = 1;
            panelProductCaregory.WrapContents = false;
            // 
            // dgOrderItems
            // 
            dgOrderItems.AllowUserToAddRows = false;
            dgOrderItems.AllowUserToDeleteRows = false;
            dgOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgOrderItems.Columns.AddRange(new DataGridViewColumn[] { ItemNo, ProductName, Quantity, UnitPrice, SubTotal });
            dgOrderItems.Dock = DockStyle.Fill;
            dgOrderItems.Location = new Point(0, 0);
            dgOrderItems.Name = "dgOrderItems";
            dgOrderItems.ReadOnly = true;
            dgOrderItems.RowHeadersVisible = false;
            dgOrderItems.Size = new Size(441, 494);
            dgOrderItems.TabIndex = 0;
            dgOrderItems.CellClick += dgOrderItems_CellClick;
            // 
            // ItemNo
            // 
            ItemNo.DataPropertyName = "ItemNo";
            ItemNo.HeaderText = "ItemId";
            ItemNo.Name = "ItemNo";
            ItemNo.ReadOnly = true;
            ItemNo.Visible = false;
            // 
            // ProductName
            // 
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "Ürün";
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Adet";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // UnitPrice
            // 
            UnitPrice.DataPropertyName = "UnitPrice";
            UnitPrice.HeaderText = "Birim Fiyat";
            UnitPrice.Name = "UnitPrice";
            UnitPrice.ReadOnly = true;
            // 
            // SubTotal
            // 
            SubTotal.DataPropertyName = "SubTotal";
            SubTotal.HeaderText = "Ara Toplam";
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnDeleteProduct, 1, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(btnOrderSave, 1, 2);
            tableLayoutPanel1.Controls.Add(btnOrderDelete, 0, 2);
            tableLayoutPanel1.Controls.Add(label10, 0, 1);
            tableLayoutPanel1.Controls.Add(lblTotal, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 494);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Size = new Size(441, 107);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.BackColor = Color.IndianRed;
            btnDeleteProduct.Dock = DockStyle.Fill;
            btnDeleteProduct.FlatStyle = FlatStyle.Flat;
            btnDeleteProduct.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDeleteProduct.ForeColor = Color.FromArgb(224, 224, 224);
            btnDeleteProduct.Location = new Point(223, 3);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(215, 29);
            btnDeleteProduct.TabIndex = 16;
            btnDeleteProduct.Text = "Ürün Sil";
            btnDeleteProduct.UseVisualStyleBackColor = false;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
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
            button1.Size = new Size(214, 29);
            button1.TabIndex = 15;
            button1.Text = "Satır Sil";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label10.Location = new Point(3, 35);
            label10.Name = "label10";
            label10.Size = new Size(214, 35);
            label10.TabIndex = 13;
            label10.Text = "Toplam";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            lblTotal.Dock = DockStyle.Fill;
            lblTotal.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            lblTotal.Location = new Point(223, 35);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(215, 35);
            lblTotal.TabIndex = 14;
            lblTotal.Text = "999,99";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlTableInfo
            // 
            pnlTableInfo.Controls.Add(btnReturn);
            pnlTableInfo.Controls.Add(btnLogout);
            pnlTableInfo.Controls.Add(lblCurrenTable);
            pnlTableInfo.Controls.Add(label12);
            pnlTableInfo.Dock = DockStyle.Top;
            pnlTableInfo.Location = new Point(0, 0);
            pnlTableInfo.Name = "pnlTableInfo";
            pnlTableInfo.Size = new Size(1264, 35);
            pnlTableInfo.TabIndex = 39;
            pnlTableInfo.Visible = false;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.SteelBlue;
            btnReturn.Dock = DockStyle.Right;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnReturn.ForeColor = Color.FromArgb(224, 224, 224);
            btnReturn.Location = new Point(990, 0);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(137, 35);
            btnReturn.TabIndex = 8;
            btnReturn.Text = "Masalar";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Firebrick;
            btnLogout.Dock = DockStyle.Right;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnLogout.ForeColor = Color.FromArgb(224, 224, 224);
            btnLogout.Location = new Point(1127, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(137, 35);
            btnLogout.TabIndex = 15;
            btnLogout.Text = "Çıkış";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // lblCurrenTable
            // 
            lblCurrenTable.AutoSize = true;
            lblCurrenTable.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            lblCurrenTable.Location = new Point(85, 12);
            lblCurrenTable.Name = "lblCurrenTable";
            lblCurrenTable.Size = new Size(27, 15);
            lblCurrenTable.TabIndex = 14;
            lblCurrenTable.Text = "001";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label12.Location = new Point(4, 12);
            label12.Name = "label12";
            label12.Size = new Size(79, 15);
            label12.TabIndex = 13;
            label12.Text = "Aktif Masa :";
            // 
            // OrderManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1264, 729);
            Controls.Add(pnlMain);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "OrderManagementForm";
            Text = "Sipariş Yönetimi";
            Load += OrderManagementForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            pnlMain.Panel1.ResumeLayout(false);
            pnlMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pnlMain).EndInit();
            pnlMain.ResumeLayout(false);
            PanelProductMenu.Panel1.ResumeLayout(false);
            PanelProductMenu.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PanelProductMenu).EndInit();
            PanelProductMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgOrderItems).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            pnlTableInfo.ResumeLayout(false);
            pnlTableInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlTable;
        private Label label1;
        private Label label2;
     
        private Button btnOrderDelete;
        private Label label3;
        private Panel pnlFilter;
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
        private ComboBox cmbTableStatus;
        private Label label9;
        private SplitContainer pnlMain;
        private SplitContainer PanelProductMenu;
        private FlowLayoutPanel panelProductCaregory;
        private FlowLayoutPanel panelProduct;
        private DataGridView dgOrderItems;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label10;
        private Label lblTotal;
        private Button button1;
        private DataGridViewTextBoxColumn ItemNo;
        private DataGridViewTextBoxColumn Ürün;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewTextBoxColumn ProductName;
        private Button btnDeleteProduct;
        private Panel pnlTableInfo;
        private Label lblCurrenTable;
        private Label label12;
        private Button btnReturn;
        private Button btnLogout;
    }
}