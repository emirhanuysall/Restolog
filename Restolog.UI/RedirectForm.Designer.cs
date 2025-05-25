namespace Restolog.UI
{
    partial class RedirectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RedirectForm));
            btnOrderManagement = new Button();
            label1 = new Label();
            btnUserManagement = new Button();
            btnDashboard = new Button();
            pictureBox1 = new PictureBox();
            pcboxMenu = new PictureBox();
            btnMenuManagement = new Button();
            pcboxTable = new PictureBox();
            btnTableManagement = new Button();
            pcboxUser = new PictureBox();
            pcboxDashboard = new PictureBox();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcboxMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcboxTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcboxUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcboxDashboard).BeginInit();
            SuspendLayout();
            // 
            // btnOrderManagement
            // 
            btnOrderManagement.BackColor = Color.Green;
            btnOrderManagement.FlatStyle = FlatStyle.Flat;
            btnOrderManagement.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOrderManagement.Location = new Point(114, 98);
            btnOrderManagement.Name = "btnOrderManagement";
            btnOrderManagement.Size = new Size(186, 151);
            btnOrderManagement.TabIndex = 9;
            btnOrderManagement.Text = "Sipariş Yönetimi";
            btnOrderManagement.TextAlign = ContentAlignment.BottomCenter;
            btnOrderManagement.UseVisualStyleBackColor = false;
            btnOrderManagement.Click += btnOrderManagement_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(240, 34);
            label1.Name = "label1";
            label1.Size = new Size(297, 37);
            label1.TabIndex = 10;
            label1.Text = "RESTORAN İŞLEMLERİ";
            // 
            // btnUserManagement
            // 
            btnUserManagement.BackColor = Color.SteelBlue;
            btnUserManagement.FlatStyle = FlatStyle.Flat;
            btnUserManagement.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnUserManagement.Location = new Point(114, 255);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Size = new Size(186, 144);
            btnUserManagement.TabIndex = 12;
            btnUserManagement.Text = "Kullanıcı Yönetimi";
            btnUserManagement.TextAlign = ContentAlignment.BottomCenter;
            btnUserManagement.UseVisualStyleBackColor = false;
            btnUserManagement.Click += btnUserManagement_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Goldenrod;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDashboard.Location = new Point(306, 255);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(378, 144);
            btnDashboard.TabIndex = 15;
            btnDashboard.Text = "DASHBOARD";
            btnDashboard.TextAlign = ContentAlignment.MiddleRight;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Green;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(127, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.Click += btnOrderManagement_Click;
            // 
            // pcboxMenu
            // 
            pcboxMenu.BackColor = Color.Peru;
            pcboxMenu.Image = (Image)resources.GetObject("pcboxMenu.Image");
            pcboxMenu.Location = new Point(319, 108);
            pcboxMenu.Name = "pcboxMenu";
            pcboxMenu.Size = new Size(162, 121);
            pcboxMenu.SizeMode = PictureBoxSizeMode.Zoom;
            pcboxMenu.TabIndex = 20;
            pcboxMenu.TabStop = false;
            pcboxMenu.Click += btnMenuManagement_Click;
            // 
            // btnMenuManagement
            // 
            btnMenuManagement.BackColor = Color.Peru;
            btnMenuManagement.FlatStyle = FlatStyle.Flat;
            btnMenuManagement.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnMenuManagement.Location = new Point(306, 98);
            btnMenuManagement.Name = "btnMenuManagement";
            btnMenuManagement.Size = new Size(186, 151);
            btnMenuManagement.TabIndex = 19;
            btnMenuManagement.Text = "Menü Yönetimi";
            btnMenuManagement.TextAlign = ContentAlignment.BottomCenter;
            btnMenuManagement.UseVisualStyleBackColor = false;
            btnMenuManagement.Click += btnMenuManagement_Click;
            // 
            // pcboxTable
            // 
            pcboxTable.BackColor = Color.DodgerBlue;
            pcboxTable.Image = (Image)resources.GetObject("pcboxTable.Image");
            pcboxTable.Location = new Point(511, 108);
            pcboxTable.Name = "pcboxTable";
            pcboxTable.Size = new Size(162, 121);
            pcboxTable.SizeMode = PictureBoxSizeMode.Zoom;
            pcboxTable.TabIndex = 22;
            pcboxTable.TabStop = false;
            pcboxTable.Click += btnTableManagement_Click;
            // 
            // btnTableManagement
            // 
            btnTableManagement.BackColor = Color.DodgerBlue;
            btnTableManagement.FlatStyle = FlatStyle.Flat;
            btnTableManagement.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnTableManagement.Location = new Point(498, 98);
            btnTableManagement.Name = "btnTableManagement";
            btnTableManagement.Size = new Size(186, 151);
            btnTableManagement.TabIndex = 21;
            btnTableManagement.Text = "Masa Yönetimi";
            btnTableManagement.TextAlign = ContentAlignment.BottomCenter;
            btnTableManagement.UseVisualStyleBackColor = false;
            btnTableManagement.Click += btnTableManagement_Click;
            // 
            // pcboxUser
            // 
            pcboxUser.BackColor = Color.SteelBlue;
            pcboxUser.Image = (Image)resources.GetObject("pcboxUser.Image");
            pcboxUser.Location = new Point(127, 267);
            pcboxUser.Name = "pcboxUser";
            pcboxUser.Size = new Size(162, 110);
            pcboxUser.SizeMode = PictureBoxSizeMode.Zoom;
            pcboxUser.TabIndex = 23;
            pcboxUser.TabStop = false;
            pcboxUser.Click += btnUserManagement_Click;
            // 
            // pcboxDashboard
            // 
            pcboxDashboard.BackColor = Color.Goldenrod;
            pcboxDashboard.Image = (Image)resources.GetObject("pcboxDashboard.Image");
            pcboxDashboard.Location = new Point(319, 267);
            pcboxDashboard.Name = "pcboxDashboard";
            pcboxDashboard.Size = new Size(270, 119);
            pcboxDashboard.SizeMode = PictureBoxSizeMode.Zoom;
            pcboxDashboard.TabIndex = 24;
            pcboxDashboard.TabStop = false;
            pcboxDashboard.Click += btnDashboard_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Firebrick;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnLogout.ForeColor = Color.FromArgb(224, 224, 224);
            btnLogout.Location = new Point(12, 407);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(84, 31);
            btnLogout.TabIndex = 25;
            btnLogout.Text = "Çıkış Yap";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // RedirectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(pcboxDashboard);
            Controls.Add(pcboxUser);
            Controls.Add(pcboxTable);
            Controls.Add(btnTableManagement);
            Controls.Add(pcboxMenu);
            Controls.Add(btnMenuManagement);
            Controls.Add(pictureBox1);
            Controls.Add(btnDashboard);
            Controls.Add(btnUserManagement);
            Controls.Add(label1);
            Controls.Add(btnOrderManagement);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RedirectForm";
            Text = "Yönlendirme Sayfası";
            Load += RedirectForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcboxMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcboxTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcboxUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcboxDashboard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOrderManagement;
        private Label label1;
        private Button btnUserManagement;
        private Button btnDashboard;
        private PictureBox pictureBox1;
        private PictureBox pcboxMenu;
        private Button btnMenuManagement;
        private PictureBox pcboxTable;
        private Button btnTableManagement;
        private PictureBox pcboxUser;
        private PictureBox pcboxDashboard;
        private Button btnLogout;
    }
}