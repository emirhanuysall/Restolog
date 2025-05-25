namespace Restolog.UI
{
    partial class TableEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableEditForm));
            btnSave = new Button();
            txtName = new TextBox();
            label1 = new Label();
            cmbStatus = new ComboBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Green;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSave.ForeColor = Color.FromArgb(224, 224, 224);
            btnSave.Location = new Point(209, 182);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(111, 30);
            btnSave.TabIndex = 15;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(209, 68);
            txtName.Name = "txtName";
            txtName.Size = new Size(124, 23);
            txtName.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(209, 50);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 9;
            label1.Text = "Masa Adı";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(209, 118);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 23);
            cmbStatus.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(209, 100);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 17;
            label2.Text = "Durum";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // TableEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(424, 242);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(cmbStatus);
            Controls.Add(btnSave);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "TableEditForm";
            Text = "TableEditForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox txtName;
        private Label label1;
        private ComboBox cmbStatus;
        private Label label2;
        private PictureBox pictureBox1;
    }
}