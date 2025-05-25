namespace Restolog.UI
{
    partial class UserEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserEditForm));
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            cmbRole = new ComboBox();
            label3 = new Label();
            chkIsActive = new CheckBox();
            txtPassword = new TextBox();
            label4 = new Label();
            btnSave = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 48);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı";
            // 
            // txtName
            // 
            txtName.Location = new Point(208, 66);
            txtName.Name = "txtName";
            txtName.Size = new Size(132, 23);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(369, 48);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "Rolü";
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(369, 66);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(132, 23);
            cmbRole.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(369, 96);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 4;
            label3.Text = "Kullanıcı Durumu";
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Location = new Point(369, 117);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(51, 19);
            chkIsActive.TabIndex = 5;
            chkIsActive.Text = "Aktif";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(208, 114);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(132, 23);
            txtPassword.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(208, 96);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 6;
            label4.Text = "Şifre";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Green;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSave.ForeColor = Color.FromArgb(224, 224, 224);
            btnSave.Location = new Point(369, 167);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(111, 30);
            btnSave.TabIndex = 16;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // UserEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(537, 242);
            Controls.Add(pictureBox1);
            Controls.Add(btnSave);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(chkIsActive);
            Controls.Add(label3);
            Controls.Add(cmbRole);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "UserEditForm";
            Text = "UserEditForm";
            Load += UserEditForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private ComboBox cmbRole;
        private Label label3;
        private CheckBox chkIsActive;
        private TextBox txtPassword;
        private Label label4;
        private Button btnSave;
        private PictureBox pictureBox1;
    }
}