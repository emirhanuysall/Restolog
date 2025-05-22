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
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            btnReturn = new Button();
            btnLogout = new Button();
            label2 = new Label();
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
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnReturn);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(169, 477);
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
            label4.Size = new Size(115, 13);
            label4.TabIndex = 7;
            label4.Text = "Aktif Kullanıcı Bilgiler";
            // 
            // button6
            // 
            button6.BackColor = Color.DodgerBlue;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button6.Location = new Point(3, 227);
            button6.Name = "button6";
            button6.Size = new Size(161, 41);
            button6.TabIndex = 12;
            button6.Text = "Siparişi Tamamla";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Peru;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button5.Location = new Point(3, 180);
            button5.Name = "button5";
            button5.Size = new Size(161, 41);
            button5.TabIndex = 10;
            button5.Text = "Sipariş Düzenle";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Firebrick;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.Location = new Point(3, 133);
            button4.Name = "button4";
            button4.Size = new Size(161, 41);
            button4.TabIndex = 9;
            button4.Text = "Sipariş Sil";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.Location = new Point(3, 86);
            button3.Name = "button3";
            button3.Size = new Size(161, 41);
            button3.TabIndex = 8;
            button3.Text = "Sipariş Ekle";
            button3.UseVisualStyleBackColor = false;
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
            // pnlTable
            // 
            pnlTable.BorderStyle = BorderStyle.FixedSingle;
            pnlTable.Location = new Point(187, 111);
            pnlTable.Name = "pnlTable";
            pnlTable.Size = new Size(773, 399);
            pnlTable.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(169, 21);
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
            panel3.Location = new Point(187, 33);
            panel3.Name = "panel3";
            panel3.Size = new Size(773, 72);
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
            // OrderManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(969, 521);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(pnlTable);
            Controls.Add(panel1);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel pnlTable;
        private Label label1;
        private Label label2;
        private Button btnLogout;
        private Button btnReturn;
        private Button button5;
        private Button button4;
        private Button button3;
        private Label label3;
        private Panel panel3;
        private Label label7;
        private TextBox txtSearch;
        private Button btnApply;
        private Button button6;
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
    }
}