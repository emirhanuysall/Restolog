﻿namespace Restolog.UI
{
    partial class MenuManagementForm
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
            label1 = new Label();
            panel3 = new Panel();
            label8 = new Label();
            cmbCategories = new ComboBox();
            label7 = new Label();
            txtSearch = new TextBox();
            btnApply = new Button();
            label3 = new Label();
            panel2 = new Panel();
            dgvProducts = new DataGridView();
            panel1 = new Panel();
            btnEdit = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            panel4 = new Panel();
            lblRole = new Label();
            lblUsername = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnReturn = new Button();
            btnLogout = new Button();
            label2 = new Label();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(17, 10);
            label1.Name = "label1";
            label1.Size = new Size(163, 21);
            label1.TabIndex = 17;
            label1.Text = "Menü Yönetim Paneli";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(cmbCategories);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txtSearch);
            panel3.Controls.Add(btnApply);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(188, 34);
            panel3.Name = "panel3";
            panel3.Size = new Size(834, 72);
            panel3.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.Location = new Point(7, 24);
            label8.Name = "label8";
            label8.Size = new Size(63, 13);
            label8.TabIndex = 34;
            label8.Text = "Kategoriler";
            // 
            // cmbCategories
            // 
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(7, 39);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(121, 23);
            cmbCategories.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(144, 12);
            label7.Name = "label7";
            label7.Size = new Size(35, 21);
            label7.TabIndex = 32;
            label7.Text = "Ara";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtSearch.Location = new Point(144, 38);
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
            btnApply.Location = new Point(332, 38);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(71, 23);
            btnApply.TabIndex = 30;
            btnApply.Text = "Uygula";
            btnApply.UseVisualStyleBackColor = false;
            btnApply.Click += btnApply_Click;
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
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dgvProducts);
            panel2.Location = new Point(188, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(834, 399);
            panel2.TabIndex = 15;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(3, 4);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(826, 390);
            dgvProducts.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(btnReturn);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(13, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(169, 477);
            panel1.TabIndex = 14;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Peru;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEdit.ForeColor = Color.FromArgb(224, 224, 224);
            btnEdit.Location = new Point(3, 178);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(161, 41);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "Ürün Düzenle";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Firebrick;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDelete.ForeColor = Color.FromArgb(224, 224, 224);
            btnDelete.Location = new Point(3, 131);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(161, 41);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Ürün Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAdd.ForeColor = Color.FromArgb(224, 224, 224);
            btnAdd.Location = new Point(3, 84);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(161, 41);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Ürün Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
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
            panel4.TabIndex = 11;
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
            btnReturn.ForeColor = Color.FromArgb(224, 224, 224);
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
            btnLogout.ForeColor = Color.FromArgb(224, 224, 224);
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
            // MenuManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1034, 521);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MenuManagementForm";
            Text = "Menü Yönetimi";
            Load += MenuManagementForm_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel3;
        private Label label3;
        private Panel panel2;
        private Panel panel1;
        private Panel panel4;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnReturn;
        private Button btnLogout;
        private Label label2;
        private DataGridView dgvProducts;
        private Label label7;
        private TextBox txtSearch;
        private Button btnApply;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnAdd;
        private ComboBox cmbCategories;
        private Label label8;
        private Label lblUsername;
        private Label lblRole;
    }
}