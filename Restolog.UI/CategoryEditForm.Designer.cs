namespace Restolog.UI
{
    partial class CategoryEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryEditForm));
            txtName = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(215, 97);
            txtName.Name = "txtName";
            txtName.Size = new Size(132, 23);
            txtName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(215, 79);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 2;
            label1.Text = "Kategori Adı";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Green;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSave.ForeColor = Color.FromArgb(224, 224, 224);
            btnSave.Location = new Point(236, 164);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(111, 30);
            btnSave.TabIndex = 19;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // CategoryEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(413, 242);
            Controls.Add(btnSave);
            Controls.Add(pictureBox1);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "CategoryEditForm";
            Text = "CategoryEditForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnSave;
    }
}