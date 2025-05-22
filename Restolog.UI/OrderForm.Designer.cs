namespace Restolog.UI
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
            lblTableName = new Label();
            cmbProduct = new ComboBox();
            label1 = new Label();
            nudQuantity = new NumericUpDown();
            label2 = new Label();
            btnAdd = new Button();
            dgvOrderItems = new DataGridView();
            lblTotal = new Label();
            btnSave = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).BeginInit();
            SuspendLayout();
            // 
            // lblTableName
            // 
            lblTableName.AutoSize = true;
            lblTableName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTableName.Location = new Point(12, 9);
            lblTableName.Name = "lblTableName";
            lblTableName.Size = new Size(71, 17);
            lblTableName.TabIndex = 7;
            lblTableName.Text = "MASA ADI";
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(12, 75);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(121, 23);
            cmbProduct.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(53, 17);
            label1.TabIndex = 9;
            label1.Text = "Ürünler";
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(12, 145);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(120, 23);
            nudQuantity.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 125);
            label2.Name = "label2";
            label2.Size = new Size(95, 17);
            label2.TabIndex = 11;
            label2.Text = "Adet/Porsiyon";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAdd.Location = new Point(12, 193);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(161, 41);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Sipariş Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // dgvOrderItems
            // 
            dgvOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderItems.Location = new Point(217, 63);
            dgvOrderItems.Name = "dgvOrderItems";
            dgvOrderItems.Size = new Size(515, 264);
            dgvOrderItems.TabIndex = 13;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTotal.Location = new Point(217, 340);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(52, 17);
            lblTotal.TabIndex = 14;
            lblTotal.Text = "Toplam";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Green;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSave.Location = new Point(444, 397);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(161, 41);
            btnSave.TabIndex = 15;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Green;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnClose.Location = new Point(627, 397);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(161, 41);
            btnClose.TabIndex = 16;
            btnClose.Text = "Kapat";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(lblTotal);
            Controls.Add(dgvOrderItems);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(nudQuantity);
            Controls.Add(label1);
            Controls.Add(cmbProduct);
            Controls.Add(lblTableName);
            Name = "OrderForm";
            Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTableName;
        private ComboBox cmbProduct;
        private Label label1;
        private NumericUpDown nudQuantity;
        private Label label2;
        private Button btnAdd;
        private DataGridView dgvOrderItems;
        private Label lblTotal;
        private Button btnSave;
        private Button btnClose;
    }
}